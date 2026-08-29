using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalFantasy14.Items
{
    public class Item_Item
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("item_level")]
        public int ItemLevel { get; set; }

        [JsonPropertyName("attack")]
        public int Attack { get; set; }

        [JsonPropertyName("auto_attack")]
        public int AutoAttack { get; set; }

        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("class_name")]
        public string ClassName { get; set; }

        [JsonPropertyName("level_req")]
        public int LevelReq { get; set; }

        [JsonPropertyName("stat_bonuses")]
        public List<string> StatBonuses { get; set; }
    }
}