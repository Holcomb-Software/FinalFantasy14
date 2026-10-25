import requests
from bs4 import BeautifulSoup
import json
import time
import os

# Create absolute path tracking so the JSON drops right next to the script
script_dir = os.path.dirname(os.path.abspath(__file__)) if '__file__' in locals() else os.getcwd()
json_path = os.path.join(script_dir, 'armor_accessories.json')

base_url = "https://na.finalfantasyxiv.com"

# Sequential category URLs to extract all armor, shields/off-hands, and accessories
target_categories = [
    "/lodestone/playguide/db/item/?category2=3",  # Armor (Shield, Head, Body, Hands, Legs, Feet)
    "/lodestone/playguide/db/item/?category2=4"   # Accessories (Earrings, Necklace, Bracelets, Ring)
]

headers = {
    'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36',
    'Accept': 'text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8',
    'Accept-Language': 'en-US,en;q=0.5',
}

# Master list that stays alive across pages and categories
final_armor_list = []

# Load existing data if you had to restart the script, otherwise start fresh
if os.path.exists(json_path):
    try:
        with open(json_path, 'r', encoding='utf-8') as f:
            final_armor_list = json.load(f)
        print(f"Loaded {len(final_armor_list)} existing items from armor_accessories.json")
    except Exception:
        final_armor_list = []

print("Connecting to Lodestone and starting real-time extraction...")

page_counter = 1
seen_urls = set()

# Outer loop going through our targeted directories
for category_route in target_categories:
    current_page_url = category_route
    print(f"\n======== STARTING NEW CATEGORY DIRECTORY: {current_page_url} ========")

    while current_page_url:
        if current_page_url.startswith('http'):
            target_url = current_page_url
        else:
            target_url = base_url + current_page_url

        if target_url in seen_urls or not current_page_url.strip():
            break
            
        seen_urls.add(target_url)
        print(f"\n--- [DIRECTORY] Processing Page {page_counter}: {target_url} ---")

        try:
            response = requests.get(target_url, headers=headers)
            if response.status_code != 200:
                print(f"[ERROR] HTTP Server block error: {response.status_code}")
                break
                
            soup = BeautifulSoup(response.text, 'html.parser')
            all_links = soup.find_all('a')
            
            page_links = []
            for link in all_links:
                href = link.get('href', '')
                classes = link.get('class', [])
                
                if "/lodestone/playguide/db/item/" in href and "db-table__txt--detail_link" in classes:
                    name_text = link.text.strip()
                    if name_text and len(name_text) > 1:
                        if not any(item['name'] == name_text for item in page_links):
                            page_links.append({'name': name_text, 'url': href})

            print(f"[DEBUG] Found {len(page_links)} items on page {page_counter}. Deep-scraping them now...")

            # ==================== LIVE DEEP EXTRACTION LOOP ====================
            for idx, item in enumerate(page_links, start=1):
                name = item['name']
                detail_url = item['url'] if item['url'].startswith('http') else base_url + item['url']
                
                # Skip if we already parsed this item on a previous run
                if any(existing['name'] == name for existing in final_armor_list):
                    continue

                try:
                    item_response = requests.get(detail_url, headers=headers)
                    item_soup = BeautifulSoup(item_response.text, 'html.parser')
                    
                    # 1. Item Name Verification
                    name_box = item_soup.find(['h2', 'h3'], class_=['db-view__item__text__name', 'db-view__item_name'])
                    if name_box:
                        name = name_box.text.strip()

                    # 2. Extract Item Level
                    item_lvl = 1
                    item_lvl_element = item_soup.find(class_='db-view__item_level')
                    if item_lvl_element:
                        lvl_digits = ''.join(c for c in item_lvl_element.text if c.isdigit())
                        if lvl_digits:
                            item_lvl = int(lvl_digits)

                    # 3. Extract Armor Defense & Magic Defense
                    defense, magic_defense = 0, 0
                    main_box = item_soup.find(class_=['db-view__item_spec', 'db_view__item_spec', 'db-view__detail__box'])
                    if not main_box:
                        main_box = item_soup.find('body')

                    if main_box:
                        full_text = main_box.text.strip().lower()

                        # Scrape raw Physical Defense value
                        if "defense" in full_text and "magic defense" not in full_text.split("defense")[0]:
                            try:
                                after_def = full_text.split("defense")[1].strip()
                                def_digits = [c for c in after_def.replace(":", "").strip() if c.isdigit()]
                                if def_digits: 
                                    # Take first cluster of digits up to 4 characters long
                                    defense = int(''.join(def_digits[:4]))
                            except Exception: pass

                        # Scrape raw Magic Defense value
                        if "magic defense" in full_text:
                            try:
                                after_mdef = full_text.split("magic defense")[1].strip()
                                mdef_digits = [c for c in after_mdef.replace(":", "").strip() if c.isdigit()]
                                if mdef_digits: 
                                    magic_defense = int(''.join(mdef_digits[:4]))
                            except Exception: pass

                    # 4. Extract Image URL
                    img = ""
                    img_element = item_soup.find('img', class_='db-view__item__icon__item_image')
                    if img_element:
                        img = img_element.get('src', '')

                    # 5. Extract Job Class
                    char_class = "All Classes"
                    class_element = item_soup.find(class_='db-view__item_equipment__class')
                    if class_element:
                        char_class = class_element.text.strip()
                    
                    # 6. Extract Level Requirement
                    lvl = 1
                    lvl_element = item_soup.find(class_='db-view__item_equipment__level')
                    if lvl_element:
                        lvl_digits = ''.join(c for c in lvl_element.text if c.isdigit())
                        if lvl_digits: lvl = int(lvl_digits)

                    # 7. Extract Stat Bonuses
                    bonuses = []
                    full_body_text = item_soup.text
                    if "Bonuses" in full_body_text:
                        try:
                            after_bonuses = full_body_text.split("Bonuses")[1]
                            bonus_section = after_bonuses.split("Crafting")[0].split("Materia")[0]
                            for line in bonus_section.split('\n'):
                                line_text = line.strip().replace("- ", "")
                                if '+' in line_text or '-' in line_text:
                                    cleaned_line = " ".join(line_text.split())
                                    if len(cleaned_line) < 40 and cleaned_line not in bonuses:
                                        bonuses.append(cleaned_line)
                        except Exception: pass

                    # 8. Extract Materia Sockets
                    materia_sockets = 0
                    materia_box = item_soup.find(class_='db-view__materia_socket')
                    if materia_box:
                        materia_sockets = len(materia_box.find_all(class_=lambda c: c and 'socket' in c))

                    # 9. Extract Repair Info and System Flags
                    repair_details = {"repair_level": "Unknown", "materials": "Unknown", "materia_melding": "Unknown"}
                    item_properties = {"extractable": "Unknown", "projectable": "Unknown", "desynthesizable": "Unknown", "dyeable": "Unknown"}
                    
                    repair_box = item_soup.find(class_='db-view__item_repair')
                    if repair_box:
                        repair_text = " ".join([line.strip() for line in repair_box.text.split('\n') if line.strip()])
                        try:
                            if "Repair Level" in repair_text:
                                repair_details["repair_level"] = repair_text.split("Repair Level")[1].split("Materials")[0].strip()
                            if "Materials" in repair_text:
                                repair_details["materials"] = repair_text.split("Materials")[1].split("Materia Melding")[0].strip()
                            if "Materia Melding" in repair_text:
                                repair_details["materia_melding"] = repair_text.split("Materia Melding")[1].strip()
                        except Exception: pass

                    info_list_box = item_soup.find(class_='db-view__item-info__list')
                    if info_list_box:
                        flags_text = " ".join([line.strip() for line in info_list_box.text.split('\n') if line.strip()])
                        item_properties["extractable"] = "Yes" if "Extractable: Yes" in flags_text else "No"
                        item_properties["projectable"] = "Yes" if "Projectable: Yes" in flags_text else "No"
                        item_properties["desynthesizable"] = "Yes" if "Desynthesizable: Yes" in flags_text else "No"
                        item_properties["dyeable"] = "Yes" if "Dyeable: Yes" in flags_text else "No"

                    # 10. Extracting Material Prohibition, Sellability, Market Status
                    market_restrictions = {
                        "advanced_melding_forbidden": "No",
                        "available_for_purchase": "Unknown",
                        "market_prohibited": "No"
                    }

                    material_box = item_soup.find(class_='db-view__cannot_materia_prohibited')
                    if material_box:
                        material_text = material_box.text.strip()
                        if "Advanced Melding Forbidden" in material_text:
                            market_restrictions["advanced_melding_forbidden"] = "Yes"

                    purchase_box = item_soup.find(class_='db-view__unsellable')
                    if purchase_box:
                        purchase_text = purchase_box.text.strip()
                        market_restrictions["available_for_purchase"] = "No" if "Unsellable" in purchase_text else "Yes"

                    market_box = item_soup.find(class_='db-view__market_notsell')
                    if market_box:
                        market_text = market_box.text.strip()
                        if "Market Prohibited" in market_text:
                            market_restrictions["market_prohibited"] = "Yes"

                   # 11. Extract Reward Item / Acquisition Source Hyperlink Data
                    reward_info = {"name": "None", "url": "None"}
                    reward_wrapper = item_soup.find(class_=lambda c: c and 'reward__item__name__wrapper' in c)
                    
                    if not reward_wrapper:
                        reward_wrapper = item_soup.find(class_=['db-view__data__reward__item', 'db-view__data__drop__item'])
                    
                    if reward_wrapper:
                        reward_anchor = reward_wrapper.find('a')
                        if reward_anchor:
                            reward_href = reward_anchor.get('href', '').strip()
                            reward_info["name"] = reward_anchor.text.strip()
                            if reward_href:
                                reward_info["url"] = reward_href if reward_href.startswith('http') else base_url + reward_href
                    else:
                        # Upgraded from 'text' to 'string' to maintain compatibility with modern BeautifulSoup
                        quest_label = item_soup.find(string=lambda t: t and ("Quest" in t or "Duty" in t))
                        if quest_label and quest_label.find_parent():
                            parent_row = quest_label.find_parent(['div', 'tr', 'li'])
                            if parent_row and parent_row.find('a'):
                                anchor = parent_row.find('a')
                                reward_info["name"] = anchor.text.strip()
                                reward_info["url"] = anchor['href'] if anchor['href'].startswith('http') else base_url + anchor['href']

                    # ==================== INSERTED CODE BLOCK START ====================
                    # 11b. Extract "Required Items" Exchange Materials Images
                    required_item_images = []
                    
                    # Target Lodestone's unique CSS wrapper class for token trade-ins
                    exchange_box = item_soup.find(class_=lambda c: c and 'db-view__data__exchange__item' in c)
                    if not exchange_box:
                        # Fallback: String-match the dynamic table header if classes fluctuate
                        required_header = item_soup.find(string=lambda t: t and "Required Items" in t)
                        if required_header:
                            exchange_box = required_header.find_parent(['div', 'table', 'section'])

                    if exchange_box:
                        # Pull all image assets belonging to the token requirements inside this block
                        req_elements = exchange_box.select('img[src*="/itemicon/"]')
                        for req_img in req_elements:
                            img_url = req_img.get('src', '').strip()
                            if img_url and img_url not in required_item_images:
                                required_item_images.append(img_url)
                    # ==================== INSERTED CODE BLOCK END ====================

                    # 12. Extract Table Specifications Data
                    table_specs = {}
                    target_table = item_soup.find('table', class_=lambda c: c and ('db-table' in c or 'detail' in c))
                    
                    if not target_table:
                        table_head = item_soup.find(class_=lambda c: c and 'db-table__head' in c)
                        if table_head:
                            target_table = table_head.find_parent('table') or table_head.find_next('table')

                    if target_table:
                        rows = target_table.find_all('tr')
                        for row in rows:
                            th_cell = row.find(['th', 'td'], class_=lambda c: c and ('head' in c or 'title' in c))
                            td_cell = row.find('td', class_=lambda c: c and 'head' not in c and 'title' not in c)

                            if not th_cell or not td_cell:
                                all_cells = row.find_all(['th', 'td'])
                                if len(all_cells) >= 2:
                                    th_cell, td_cell = all_cells[0], all_cells[1]

                            if th_cell and td_cell:
                                key_text = " ".join(th_cell.text.split()).strip().rstrip(':')
                                val_text = " ".join(td_cell.text.split()).strip()
                                if key_text and val_text:
                                    table_specs[key_text] = val_text

                    # Compile everything into an armor/accessory schema
                    armor_data = {
                        "name": name,
                        "item_level": item_lvl,
                        "defense": defense,
                        "magic_defense": magic_defense,
                        "image_url": img,
                        "class_name": char_class,
                        "level_req": lvl,
                        "stat_bonuses": bonuses,
                        "materia_slots": materia_sockets,
                        "repair_info": repair_details,
                        "flags": item_properties,
                        "market_restrictions": market_restrictions,
                        "reward_source": reward_info,
                        "additional_specs": table_specs
                    }
                    
                    final_armor_list.append(armor_data)
                    print(f"[{idx}/{len(page_links)}] Saved: {name} | Def: {defense} | MDef: {magic_defense} | Lvl: {lvl}")
                    
                    # Save continuously item-by-item to disk
                    with open(json_path, 'w', encoding='utf-8') as f:
                        json.dump(final_armor_list, f, indent=4, ensure_ascii=False)
                    
                    time.sleep(0.3)

                except Exception as e:
                    print(f"[ERROR] Skipped item '{name}' inside loop. Reason: {e}")

            # ==================== PAGINATION HANDLING ====================
            next_url = None
            next_btn = soup.find(class_=lambda c: c and ('btn__next' in c or 'page__next' in c or 'next' in c))
            if next_btn:
                next_anchor = next_btn if next_btn.name == 'a' else next_btn.find('a')
                if next_anchor and next_anchor.get('href'):
                    next_url = next_anchor['href']

            if not next_url:
                for anchor in all_links:
                    anchor_text = anchor.text.strip()
                    anchor_href = anchor.get('href', '')
                    if "Next" in anchor_text or "▶" in anchor_text or "»" in anchor_text:
                        if "category2=3" in anchor_href or "category2=4" in anchor_href:
                            if anchor_href != current_page_url:
                                next_url = anchor_href
                                break

            if next_url:
                current_page_url = next_url
                page_counter += 1
                time.sleep(1.5)
            else:
                print(f"\n[FINISH] Reached the final page for this directory category layout.")
                current_page_url = None
                page_counter = 1  # Reset counter for next directory category
                
        except Exception as e:
            print(f"Error handling system page flow: {e}")
            current_page_url = None

print(f"\nScraping successfully complete. '{json_path}' holds all processed records!")