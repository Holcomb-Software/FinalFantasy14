namespace FinalFantasy14.Warrior.WarArm.Head.Level1_10;

public partial class Head_Level1_10 : ContentPage
{
	public Head_Level1_10()
	{
		InitializeComponent();

        Picker picker = new Picker { Title = "Select Warrior Helmet" };
        picker.Items.Add("Far Eastern Patriarch's Hat");
        picker.Items.Add("Far Eastern Matriarch's Sun Hat");
        picker.Items.Add("Helm of Light");
        picker.Items.Add("Onion Helm");
        picker.Items.Add("Garlond Goggles");
        picker.Items.Add("Moogle Cap");
        picker.Items.Add("Virtu Ravager's Helm");
        picker.Items.Add("Tarnished Face of Undying Twilight");
        picker.Items.Add("Aka Oni Somen");
        picker.Items.Add("Republic Hoplomachus's Headgear");
        picker.Items.Add("Late Allagan Mask of Fending");
        picker.Items.Add("Prestige Crown of Light");
        picker.Items.Add("Prestige High Allagan Circlet of Fending");
        picker.Items.Add("Lone Wolf Crown");
        picker.Items.Add("Pack Wolf Crow");
        picker.Items.Add("Eaglewing Crown");
        picker.Items.Add("Barghest Helm");
        picker.Items.Add("Moddey Dhoo Helm");
        picker.Items.Add("Hempen Coif");
        picker.Items.Add("Hemp Coif of Gathering");
        picker.Items.Add("Leather Calot");
        picker.Items.Add("Company Hat");
        picker.Items.Add("Spotted Fedora");
        picker.Items.Add("Ultima Horns");
        picker.Items.Add("Tamamo Headband");
        picker.Items.Add("Toad Head");
        picker.Items.Add("Gaja Head");
        picker.Items.Add("Expeditioner's Cap");
        picker.Items.Add("Hellhound Helm");
        picker.Items.Add("Grey Hound Helm");
        picker.Items.Add("Koro Kabuto");
        picker.Items.Add("Gunro Kabuto");
        picker.Items.Add("Shdowstalker's Helm");
        picker.Items.Add("Shadowcleaver's Helm");
        picker.Items.Add("Archfiend Helm");
        picker.Items.Add("False Monarchy Mask");
        picker.Items.Add("Catoblepas Horns");
        picker.Items.Add("Bunny Crown");
        picker.Items.Add("Sharlayan Goggles");
        picker.Items.Add("Bunny Chief Crown");
        picker.Items.Add("Cockscomb");
        picker.Items.Add("Coeurl Mask");
        picker.Items.Add("Succubus Horns");
        picker.Items.Add("Swine Head");
        picker.Items.Add("Arch Demon Horns");
        picker.Items.Add("Shaded Visor");
        picker.Items.Add("Vanu Vanu Head");
        picker.Items.Add("Gnath Head");
        picker.Items.Add("Zundu Head");
        picker.Items.Add("Kabuto of the Blue");
        picker.Items.Add("Namazu Mask");
        picker.Items.Add("Replica Behemoth Helm");
        picker.Items.Add("Replica Heavy Behemoth Helm");
        picker.Items.Add("Goblin Cap");
        picker.Items.Add("Fat Chocobo Head");
        picker.Items.Add("Racing Chocobo Mask");
        picker.Items.Add("Expeditioner's Flyers");
        picker.Items.Add("Dragon Monocle");
        picker.Items.Add("Dynasty Crown");
        picker.Items.Add("Ribbon");
        picker.Items.Add("Migratory Plume");
        picker.Items.Add("Monoa Mask");
        picker.Items.Add("Mended Imperial Pot Helm");
        picker.Items.Add("Sable Death Mask");
        picker.Items.Add("Postmoogle Cap");
        picker.Items.Add("Scion Adventurer's Monocle");
        picker.Items.Add("Inspector's Eyeglasses");
        picker.Items.Add("Scion Rogue's Bandana");
        picker.Items.Add("Head Bandage");
        picker.Items.Add("Scion Traveler's Mask");
        picker.Items.Add("Crystarium Helm");
        picker.Items.Add("Appointed Cap");
        picker.Items.Add("Yakaku Kamidome");
        picker.Items.Add("Leafman Head");
        picker.Items.Add("Highland Hood");
        picker.Items.Add("Coronal Straw Hat");
        picker.Items.Add("Spring Straw Hat");
        picker.Items.Add("Cloche");
        picker.Items.Add("Spriggan Cap");
        picker.Items.Add("Crescent Moon Cone");
        picker.Items.Add("Cresecent Moon Nightcap");
        picker.Items.Add("Oval Spectacles");
        picker.Items.Add("Shaded Spectacles");
        picker.Items.Add("Contemporary Pince-nez");
        picker.Items.Add("Rimless Glasses");
        picker.Items.Add("Thick-rimmed Glasses");
        picker.Items.Add("Gryphonskin Eyepatch");
        picker.Items.Add("Imperial Shadow Visor");
        picker.Items.Add("Ministrel's Spectacles");
        picker.Items.Add("Classic Spectacles");
        picker.Items.Add("Imitation Mistbeard Mask");
        picker.Items.Add("The Emperor's New Hat");
        picker.Items.Add("Oval Reading Glasses");
        picker.Items.Add("Coeurl Eyeglasses");
        picker.Items.Add("Thavnairian Turban");
        picker.Items.Add("Thavnairian Headdress");
        picker.Items.Add("Flat Cap");
        picker.Items.Add("Red Beret");
        picker.Items.Add("Green Beret");
        picker.Items.Add("White Beret");
        picker.Items.Add("Elegant Rimless Glasses");
        picker.Items.Add("Reading Glasses");
        picker.Items.Add("High House Cloche");
        picker.Items.Add("Archaeoskin Cloche");
        picker.Items.Add("Wind Silk Wedge Cap");
        picker.Items.Add("New World Headdress");
        picker.Items.Add("Survival Hat");
        picker.Items.Add("Moonfire Hat");
        picker.Items.Add("Boarskin Survival Hat");
        picker.Items.Add("Ramie Hood");
        picker.Items.Add("Cashmere Hood");
        picker.Items.Add("Wool Night Cap");
        picker.Items.Add("Flannel Knit Cap");
        picker.Items.Add("Taoist's Cap");
        picker.Items.Add("Non La");
        picker.Items.Add("Emperor Hairpin");
        picker.Items.Add("Anemos Hat");
        picker.Items.Add("Anemos Pot Hat");
        picker.Items.Add("Boulevardier's Hat");
        picker.Items.Add("Pagos Bandana");
        picker.Items.Add("Pagos Circlet");
        picker.Items.Add("Quaintrelle's Hat");
        picker.Items.Add("Archaeodemon Horns");
        picker.Items.Add("Rain Hood");
        picker.Items.Add("Replica Sky Pirate's Helm of Fending");
        picker.Items.Add("Replica Sky Pirate's Helm of Maiming");
        picker.Items.Add("Replica Sky Pirate's Mask of Striking");
        picker.Items.Add("Replica Sky Pirate's Beret of Aiming");
        picker.Items.Add("Replica Sky Pirate's Mask of Scouting");
        picker.Items.Add("Replica Sky Pirate's Cap of Healing");
        picker.Items.Add("Replica Sky Pirate's Cap of Casting");
        picker.Items.Add("Replica Sky Rat Mask of Fending");
        picker.Items.Add("Replica Sky Rat Mask of Maiming");
        picker.Items.Add("Replica Sky Rat Mask of Striking");
        picker.Items.Add("Replica Sky Rat Mask of Aiming");
        picker.Items.Add("Replica Sky Rat Mask of Scouting");
        picker.Items.Add("Replica Sky Rat Mask of Healing");
        picker.Items.Add("Replica Sky Rat Mask of Casting");
        picker.Items.Add("Kupo Crown");
        picker.Items.Add("Kupo Knit Cap");
        picker.Items.Add("Hraesvelgr Hat");
        picker.Items.Add("Skyworker's Helmet");
        picker.Items.Add("Calfskin Rider's Cap");
        picker.Items.Add("Frontier Hat");
        picker.Items.Add("Frontier Ribbon");
        picker.Items.Add("Peacelover's Hat");
        picker.Items.Add("Excite-I-Mask");
        picker.Items.Add("Sharlayan Diadema");
        picker.Items.Add("Thavnairian Ribbon");
        picker.Items.Add("Red Ribbon");
        picker.Items.Add("Varsity Flat Cap");
        picker.Items.Add("Isle Explorer's Hat");
        picker.Items.Add("Noir Hat");
        picker.Items.Add("Lawless Enforcer's Hat");
        picker.Items.Add("Isle Shepherd's Headdress");
        picker.Items.Add("Isle Vacationer's Visor");
        picker.Items.Add("Salon Server's Hat");
        picker.Items.Add("Plain Pajama Eye Mask");
        picker.Items.Add("Cactuar Pajama Eye Mask");
        picker.Items.Add("Chocobo Pajama Eye Mask");
        picker.Items.Add("Baronial Hat");
        picker.Items.Add("Island Resort Straw Hat");
        picker.Items.Add("Dried Red Oldrose");
        picker.Items.Add("Dried Blue Oldrose");
        picker.Items.Add("Dried Yellow Oldrose");
        picker.Items.Add("Dried Green Oldrose");
        picker.Items.Add("Dried Orange Oldrose");
        picker.Items.Add("Dried Purple Oldrose");
        picker.Items.Add("Dried White Oldrose");
        picker.Items.Add("Dried Black Oldrose");
        picker.Items.Add("Oldrose Corsage");
        picker.Items.Add("Red Viola Corsage");
        picker.Items.Add("Blue Viola Corsage");
        picker.Items.Add("Yellow Viola Corsage");
        picker.Items.Add("Green Viola Corsage");
        picker.Items.Add("Orange Viola Corsage");
        picker.Items.Add("Purple Viola Corsage");
        picker.Items.Add("White Viola Corsage");
        picker.Items.Add("Black Viola Corsage");
        picker.Items.Add("Rainbow Viola Corsage");
        picker.Items.Add("Red Cherry Blossom Corsage");
        picker.Items.Add("Blue Cherry Blossom Corsage");
        picker.Items.Add("Yellow Cherry Blossom Corsage");
        picker.Items.Add("Green Cherry Blossom Corsage");
        picker.Items.Add("Orange Cherry Blossom Corsage");
        picker.Items.Add("Purple Cherry Blossom Corsage");
        picker.Items.Add("White Cherry Blossom Corsage");
        picker.Items.Add("Black Cherry Blossom Corsage");
        picker.Items.Add("Pink Cherry Blossom Corsage");
        picker.Items.Add("Red Daisy Corsage");
        picker.Items.Add("Blue Daisy Corsage");
        picker.Items.Add("Yellow Daisy Corsage");
        picker.Items.Add("Green Daisy Corsage");
        picker.Items.Add("Orange Daisy Corsage");
        picker.Items.Add("Purple Daisy Corsage");
        picker.Items.Add("White Daisy Corsage");
        picker.Items.Add("Black Daisy Corsage");
        picker.Items.Add("Rainbow Daisy Corsage");
        picker.Items.Add("Red Brightlily Corsage");
        picker.Items.Add("Blue Brightlily Corsage");
        picker.Items.Add("Yellow Brightlily Corsage");
        picker.Items.Add("Green Brightlily Corsage");
        picker.Items.Add("Orange Brightlily Corsage");
        picker.Items.Add("Purple Brightlily Corsage");
        picker.Items.Add("White Brightlily Corsage");
        picker.Items.Add("Black Brightlily Corsage");
        picker.Items.Add("Rainbow Brightlily Corsage");
        picker.Items.Add("Red Dahlia Corsage");
        picker.Items.Add("Blue Dahlia Corsage");
        picker.Items.Add("Yellow Dahlia Corsage");
        picker.Items.Add("Green Dahlia Corsage");
        picker.Items.Add("Orange Dahlia Corsage");
        picker.Items.Add("Purple Dahlia Corsage");
        picker.Items.Add("White Dahlia Corsage");
        picker.Items.Add("Black Dahlia Corsage");
        picker.Items.Add("Rainbow Dahlia Corsage");
        picker.Items.Add("Red Arum Corsage");
        picker.Items.Add("Blue Arum Corsage");
        picker.Items.Add("Yellow Arum Corsage");
        picker.Items.Add("Green Arum Corsage");
        picker.Items.Add("Orange Arum Corsage");
        picker.Items.Add("Purple Arum Corsage");
        picker.Items.Add("White Arum Corsage");
        picker.Items.Add("Black Arum Corsage");
        picker.Items.Add("Rainbow Arum Corsage");
        picker.Items.Add("Red Lily of the Valley Corsage");
        picker.Items.Add("Blue Lily of the Valley Corsage");
        picker.Items.Add("Yellow Lily of the Valley Corsage");
        picker.Items.Add("Green Lily of the Valley Corsage");
        picker.Items.Add("Orange Lily of the Valley Corsage");
        picker.Items.Add("Purple Lily of the Valley Corsage");
        picker.Items.Add("White Lily of the Valley Corsage");
        picker.Items.Add("Black Lily of the Valley Corsage");
        picker.Items.Add("Rainbow Lily of the Valley Corsage");
        picker.Items.Add("Red Hydrangea Corsage");
        picker.Items.Add("Blue Hydrangea Corsage");
        picker.Items.Add("Yellow Hydrangea Corsage");
        picker.Items.Add("Green Hydrangea Corsage");
        picker.Items.Add("Orange Hydrangea Corsage");
        picker.Items.Add("Purple Hydrangea Corsage");
        picker.Items.Add("White Hydrangea Corsage");
        picker.Items.Add("Black Hydrangea Corsage");
        picker.Items.Add("Rainbow Hydrangea Corsage");
        picker.Items.Add("Red Campanula Corsage");
        picker.Items.Add("Blue Campanula Corsage");
        picker.Items.Add("Yellow Campanula Corsage");
        picker.Items.Add("Green Campanula Corsage");
        picker.Items.Add("Orange Campanula Corsage");
        picker.Items.Add("Purple Campanula Corsage");
        picker.Items.Add("White Campanula Corsage");
        picker.Items.Add("Black Campanula Corsage");
        picker.Items.Add("Rainbow Campanula Corsage");
        picker.Items.Add("Red Hyacinth Corsage");
        picker.Items.Add("Blue Hyacinth Corsage");
        picker.Items.Add("Yellow Hyacinth Corsage");
        picker.Items.Add("Green Hyacinth Corsage");
        picker.Items.Add("Orange Hyacinth Corsage");
        picker.Items.Add("Purple Hyacinth Corsage");
        picker.Items.Add("White Hyacinth Corsage");
        picker.Items.Add("Black Hyacinth Corsage");
        picker.Items.Add("Rainbow Hyacinth Corsage");
        picker.Items.Add("Red Cosmos Corsage");
        picker.Items.Add("Blue Cosmos Corsage");
        picker.Items.Add("Yellow Cosmos Corsage");
        picker.Items.Add("Green Cosmos Corsage");
        picker.Items.Add("Orange Cosmos Corsage");
        picker.Items.Add("Purple Cosmos Corsage");
        picker.Items.Add("White Cosmos Corsage");
        picker.Items.Add("Black Cosmos Corsage");
        picker.Items.Add("Rainbow Cosmos Corsage");
        picker.Items.Add("Red Morning Glory Corsage");
        picker.Items.Add("Blue Morning Glory Corsage");
        picker.Items.Add("Yellow Morning Glory Corsage");
        picker.Items.Add("Green Morning Glory Corsage");
        picker.Items.Add("Orange Morning Glory Corsage");
        picker.Items.Add("Purple Morning Glory Corsage");
        picker.Items.Add("White Morning Glory Corsage");
        picker.Items.Add("Black Morning Glory Corsage");
        picker.Items.Add("Rainbow Morning Glory Corsage");
        picker.Items.Add("Red Chrysanthemum Corsage");
        picker.Items.Add("Blue Chrysanthemum Corsage");
        picker.Items.Add("Yellow Chrysanthemum Corsage");
        picker.Items.Add("Green Chrysanthemum Corsage");
        picker.Items.Add("Orange Chrysanthemum Corsage");
        picker.Items.Add("Purple Chrysanthemum Corsage");
        picker.Items.Add("White Chrysanthemum Corsage");
        picker.Items.Add("Black Chrysanthemum Corsage");
        picker.Items.Add("Rainbow Chrysanthemum Corsage");
        picker.Items.Add("Usagi Kabuto");
        picker.Items.Add("Dragon Kabuto");
        picker.Items.Add("Crimson Dragon Kabuto");
        picker.Items.Add("Golden Dragon Kabuto");
        picker.Items.Add("Black Dragon Kabuto");
        picker.Items.Add("Silver Snake Kabuto");
        picker.Items.Add("Uma Kabuto");
        picker.Items.Add("Crimson Uma Kabuto");
        picker.Items.Add("Golden Uma Kabuto");
        picker.Items.Add("Black Uma Kabuto");
        picker.Items.Add("Hitsuji Kabuto");
        picker.Items.Add("Black Hitsuji Kabuto");
        picker.Items.Add("Crimson Hitsuji Kabuto");
        picker.Items.Add("White Hitsuji Kabuto");
        picker.Items.Add("See No Helm");
        picker.Items.Add("Speak No Helm");
        picker.Items.Add("Hear No Helm");
        picker.Items.Add("Red Tori Kabuto");
        picker.Items.Add("Black Tori Kabuto");
        picker.Items.Add("White Inu Kabuto");
        picker.Items.Add("Black Inu Kabuto");
        picker.Items.Add("Inoshishi Kabuto");
        picker.Items.Add("Crimson Inoshishi Kabuto");
        picker.Items.Add("Crimson Nezumi Kabuto");
        picker.Items.Add("Cobalt Nezumi Kabuto");
        picker.Items.Add("Crimson Ushi Kabuto");
        picker.Items.Add("Black Ushi Kabuto");
        picker.Items.Add("Golden Tora Kabuto");
        picker.Items.Add("Silver Tora Kabuto");
        picker.Items.Add("Valentione Hat");
        picker.Items.Add("Black-featherd Flat Hat");
        picker.Items.Add("Red-feathered Flat Hat");
        picker.Items.Add("Valentione Rose Hat");
        picker.Items.Add("Valentione Forget-me-not Hat");
        picker.Items.Add("Valentione Acacia Hat");
        picker.Items.Add("Valentione Rose Ribboned Hat");
        picker.Items.Add("Valentione Forget-me-not Ribboned Hat");
        picker.Items.Add("Valentione Acacia Ribboned Hat");
        picker.Items.Add("Lovely Moogle Cap");
        picker.Items.Add("Valentione Emissary's Hat");
        picker.Items.Add("Valentione Emissary's Dress Hat");
        picker.Items.Add("Songbird Hat");
        picker.Items.Add("Royal Seneschal's Chapeau");
        picker.Items.Add("Flower Crown");
        picker.Items.Add("Seneschal's Monocle");
        picker.Items.Add("Princess's Peach Corsage");
        picker.Items.Add("Little Lady's Crown");
        picker.Items.Add("Rabbit Head");
        picker.Items.Add("Chicken Head");
        picker.Items.Add("Tonberry Head");
        picker.Items.Add("Oschon Roselle Capeline");
        picker.Items.Add("Gold Roselle Capeline");
        picker.Items.Add("Pearl Roselle Capeline");
        picker.Items.Add("Straw Capeline");
        picker.Items.Add("Endless Summer Glasses");
        picker.Items.Add("Moonfire Hachimaki");
        picker.Items.Add("White Painted Moogle Mask");
        picker.Items.Add("Black Painted Moogle Mask");
        picker.Items.Add("Painted Namazu Mask");
        picker.Items.Add("Summer's Flame Hat");
        picker.Items.Add("Summer Sunset Bandana");
        picker.Items.Add("Pumpkin Head");
        picker.Items.Add("Unripened Pumpkin Head");
        picker.Items.Add("White Pumpkin Head");
        picker.Items.Add("Ripened Pumpkin Head");
        picker.Items.Add("Eerie Hat");
        picker.Items.Add("Witch's Hat");
        picker.Items.Add("Werewolf Head");
        picker.Items.Add("Clown's Hat");
        picker.Items.Add("Wake Doctor's Mask");
        picker.Items.Add("Dream Hat");
        picker.Items.Add("Reindeer Antlers");
        picker.Items.Add("Snowman Head");
        picker.Items.Add("Starlight Sugarloaf Hat");
        picker.Items.Add("False Mustache");
        picker.Items.Add("Reindeer Antler Headband");
        picker.Items.Add("Saint's Beard");
        picker.Items.Add("Saint's Cap");
        picker.Items.Add("Choir Hat");
        picker.Items.Add("Baron Helm");
        picker.Items.Add("Baron Circlet");
        picker.Items.Add("Wild Rose Bandana");
        picker.Items.Add("Amatsu Hachigane");
        picker.Items.Add("Legacy Warrior Coronet");
        picker.Items.Add("King Slime Crown");
        picker.Items.Add("Augmented Rathalos Helm [M]");
        picker.Items.Add("Augmented Rathalos Helm [F]");
        picker.Items.Add("Rathalos Helm [M]");
        picker.Items.Add("Rathalos Helm [F]");
        picker.Items.Add("No.2 Type B Goggles");
        picker.Items.Add("Sweet Dream Cap");
        picker.Items.Add("Tetsuji Usagi Kabuto");
        picker.Items.Add("Black Tetsuji Usagi Kabuto");
        picker.Items.Add("Silver Tetsuji Usagi Kabuto");
        picker.Items.Add("Veil of Eternal Innocence");
        picker.Items.Add("Veil of Eternal Passion");
        picker.Items.Add("Veil of Eternal Devotion");
        picker.Items.Add("Moogle Head");
        picker.Items.Add("Yellow-pommed Moogle Cap");
        picker.Items.Add("Scion Striker's Visor");
        picker.Items.Add("Scion Thaumaturge's Monocle");
        picker.Items.Add("Head Engineer's Goggles");
        picker.Items.Add("Ironworks Engineer's Goggles");
        picker.Items.Add("Housemaid's Brim");
        picker.Items.Add("Butler's Monocle");
        picker.Items.Add("Far Eastern Noble's Mortarboard");
        picker.Items.Add("Angelic Circlet");
        picker.Items.Add("Demonic Horns");
        picker.Items.Add("Far Eastern Gentleman's Hat");
        picker.Items.Add("Far Eastern Beauty's Hairpin");
        picker.Items.Add("Star of the Nezha Lord");
        picker.Items.Add("Star of the Nezha Lady");
        picker.Items.Add("Loyal Housemaid's Brim");
        picker.Items.Add("Loyal Butler's Monocle");
        picker.Items.Add("Blackbosom Hat");
        picker.Items.Add("Emerald Carbuncle Ears");
        picker.Items.Add("Topaz Carbuncle Ears");
        picker.Items.Add("Faerie Tale Prince's Circlet");
        picker.Items.Add("Faerie Tale Princess's Tiara");
        picker.Items.Add("Cracked Manderville Monocle");
        picker.Items.Add("Mun'gaek Hat");
        picker.Items.Add("Eastern Socialite's Hat");
        picker.Items.Add("Far Eastern Officer's Hat");
        picker.Items.Add("Far Eastern Maiden's Hat");
        picker.Items.Add("Leal Samurai's Kasa");
        picker.Items.Add("Far Eastern Schoolboy's Hat");
        picker.Items.Add("Far Eastern Schoolgirl's Hair Ribbon");
        picker.Items.Add("Scion Hearer's Hood");
        picker.Items.Add("Peacock Hat");
        picker.Items.Add("Eastern Lord Errant's Hat");
        picker.Items.Add("Eastern Lady Errant's Hat");
        picker.Items.Add("Mheg Deaca Circlet");
        picker.Items.Add("Scion Sorceress's Headdress");
        picker.Items.Add("Ruby Carbuncle Ears");
        picker.Items.Add("Bergsteiger's Hat");
        picker.Items.Add("Dirndl's Hat");
        picker.Items.Add("Resshi Hachigane");
        picker.Items.Add("Street Cap");
        picker.Items.Add("Fat Cat Hood");
        picker.Items.Add("Far Northern Headpiece");
        picker.Items.Add("Educand's Cap");
        picker.Items.Add("Scarf of Wondrous Wit");
        picker.Items.Add("Friendship Circlet");
        picker.Items.Add("Inferno Mask");
        picker.Items.Add("Crag Mask");
        picker.Items.Add("Eastern Journey Circlet");
        picker.Items.Add("Cait Sith Ears");
        picker.Items.Add("Exclusive Eastern Journey Circlet");
        picker.Items.Add("Matoya's Hat");
        picker.Items.Add("Leather Eyepatch");
        picker.Items.Add("Hempen Bandana");
        picker.Items.Add("Hempen Hat");
        picker.Items.Add("Bronze Chain Coif");
        picker.Items.Add("Hard Leather Pot Helm");
        picker.Items.Add("Bronze Sallet");
        picker.Items.Add("Straw Hat");
        picker.Items.Add("Amateur's Headgear");
        picker.Items.Add("Amateur's Hempen Coif");
        picker.Items.Add("Pristine Egg Cap");
        picker.Items.Add("Thug's Mug");
        picker.Items.Add("Eaglebeak Crown");
    }

    private async void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex == 0)
        {
            await Navigation.PushAsync(new FEPatHat());
        }
        else if (selectedIndex == 1)
        {
            await Navigation.PushAsync(new FEMatSunHat());
        }
        else if (selectedIndex == 2)
        {
            await Navigation.PushAsync(new HelmofLight());
        }
        else if (selectedIndex == 3)
        {
            await Navigation.PushAsync(new OnionHelm());
        }
        else if (selectedIndex == 4)
        {
            await Navigation.PushAsync(new GarlondGoggles());
        }
        else if (selectedIndex == 5)
        {
            await Navigation.PushAsync(new MoggleCap());
        }
        else if (selectedIndex == 6)
        {
            await Navigation.PushAsync(new VirtuRavagerHelm());
        }
        else if (selectedIndex == 7)
        {
            await Navigation.PushAsync(new TarnishedFaceUndyingTwilight());
        }
        else if (selectedIndex == 8)
        {
            await Navigation.PushAsync(new AkaOniSomen());
        }
        else if (selectedIndex == 9)
        {
            await Navigation.PushAsync(new RepubHopHead());
        }
        else if (selectedIndex == 10)
        {
            await Navigation.PushAsync(new LateAllMskFnd());
        }
        else if (selectedIndex == 11)
        {
            await Navigation.PushAsync(new PrestCrwnLght());
        }
        else if (selectedIndex == 12)
        {
            await Navigation.PushAsync(new PresHghAllCicltFnd());
        }
        else if (selectedIndex == 13)
        {
            await Navigation.PushAsync(new LneWlfCrn());
        }
        else if (selectedIndex == 14)
        {
            await Navigation.PushAsync(new PckWlfCwn());
        }
        else if (selectedIndex == 15)
        {
            await Navigation.PushAsync(new EglwngCwn());
        }
        else if (selectedIndex == 16)
        {
            await Navigation.PushAsync(new BarghestHelm());
        }
        else if (selectedIndex == 17)
        {
            await Navigation.PushAsync(new ModDhoHelm());
        }
        else if (selectedIndex == 18)
        {
            await Navigation.PushAsync(new HmpnCoif());
        }
        else if (selectedIndex == 19)
        {
            await Navigation.PushAsync(new HmpnCoifGathering());
        }
        else if (selectedIndex == 20)
        {
            await Navigation.PushAsync(new LeatherCalot());
        }
        else if (selectedIndex == 21)
        {
            await Navigation.PushAsync(new CompanyHat());
        }
        else if (selectedIndex == 22)
        {
            await Navigation.PushAsync(new SpottedFedora());
        }
        else if (selectedIndex == 23)
        {
            await Navigation.PushAsync(new UltimaHorns());
        }
        else if (selectedIndex == 24)
        {
            await Navigation.PushAsync(new TamHeadband());
        }
        else if (selectedIndex == 25)
        {
            await Navigation.PushAsync(new ToadHead());
        }
        else if (selectedIndex == 26)
        {
            await Navigation.PushAsync(new GajaHead());
        }
        else if (selectedIndex == 27)
        {
            await Navigation.PushAsync(new ExpedCap());
        }
        else if (selectedIndex == 28)
        {
            await Navigation.PushAsync(new HellhoundHelm());
        }
        else if (selectedIndex == 29)
        {
            await Navigation.PushAsync(new GreyHoundHelm());
        }
        else if (selectedIndex == 30)
        {
            await Navigation.PushAsync(new KoroKabuto());
        }
        else if (selectedIndex == 31)
        {
            await Navigation.PushAsync(new GunroKabuto());
        }
        else if (selectedIndex == 32)
        {
            await Navigation.PushAsync(new ShadowstalkerHelm());
        }
        else if (selectedIndex == 33)
        {
            await Navigation.PushAsync(new ShadowcleaverHelm());
        }
        else if (selectedIndex == 34)
        {
            await Navigation.PushAsync(new ArchfiendHelm());
        }
        else if (selectedIndex == 35)
        {
            await Navigation.PushAsync(new FalseMonMask());
        }
        else if (selectedIndex == 36)
        {
            await Navigation.PushAsync(new CatoHorns());
        }
        else if (selectedIndex == 37)
        {
            await Navigation.PushAsync(new BunnyCrown());
        }
        else if (selectedIndex == 38)
        {
            await Navigation.PushAsync(new SharaGoggles());
        }
        else if (selectedIndex == 39)
        {
            await Navigation.PushAsync(new BunnyChiefCrown());
        }
        else if (selectedIndex == 40)
        {
            await Navigation.PushAsync(new Cockscomb());
        }
        else if (selectedIndex == 41)
        {
            await Navigation.PushAsync(new CoeurlMask());
        }
        else if (selectedIndex == 42)
        {
            await Navigation.PushAsync(new SuccubusHorns());
        }
        else if (selectedIndex == 43)
        {
            await Navigation.PushAsync(new SwineHead());
        }
        else if (selectedIndex == 44)
        {
            await Navigation.PushAsync(new ArchDemonHorns());
        }
        else if (selectedIndex == 45)
        {
            await Navigation.PushAsync(new ShadedVisor());
        }
        else if (selectedIndex == 46)
        {
            await Navigation.PushAsync(new VanuVanuHead());
        }
        else if (selectedIndex == 47)
        {
            await Navigation.PushAsync(new GnathHead());
        }
        else if (selectedIndex == 48)
        {
            await Navigation.PushAsync(new ZunduHead());
        }
        else if (selectedIndex == 49)
        {
            await Navigation.PushAsync(new KabutooftheBlue());
        }
        else if (selectedIndex == 50)
        {
            await Navigation.PushAsync(new NamazuMask());
        }
        else if (selectedIndex == 51)
        {
            await Navigation.PushAsync(new ReplicaBehemothHelm());
        }
        else if (selectedIndex == 52)
        {
            await Navigation.PushAsync(new ReplicaHeavyBehemothHelm());
        }
        else if (selectedIndex == 53)
        {
            await Navigation.PushAsync(new GoblinCap());
        }
        else if (selectedIndex == 54)
        {
            await Navigation.PushAsync(new FatChocoboHead());
        }
        else if (selectedIndex == 55)
        {
            await Navigation.PushAsync(new RacingChocoboMask());
        }
        else if (selectedIndex == 56)
        {
            await Navigation.PushAsync(new ExpedFlyer());
        }
        else if (selectedIndex == 57)
        {
            await Navigation.PushAsync(new DragonMon());
        }
        else if (selectedIndex == 58)
        {
            await Navigation.PushAsync(new DynastyCrown());
        }
        else if (selectedIndex == 59)
        {
            await Navigation.PushAsync(new Ribbon());
        }
        else if (selectedIndex == 60)
        {
            await Navigation.PushAsync(new MigratoryPlume());
        }
        else if (selectedIndex == 61)
        {
            await Navigation.PushAsync(new MonoaMask());
        }
        else if (selectedIndex == 62)
        {
            await Navigation.PushAsync(new MendedImpPotHelm());
        }
        else if (selectedIndex == 63)
        {
            await Navigation.PushAsync(new SableDeathMask());
        }
        else if (selectedIndex == 64)
        {
            await Navigation.PushAsync(new PostmoogleCap());
        }
        else if (selectedIndex == 65)
        {
            await Navigation.PushAsync(new ScionAdvMono());
        }
        else if (selectedIndex == 66)
        {
            await Navigation.PushAsync(new InspectEyeglasses());
        }
        else if (selectedIndex == 67)
        {
            await Navigation.PushAsync(new ScionRogueBandana());
        }
        else if (selectedIndex == 68)
        {
            await Navigation.PushAsync(new HeadBandage());
        }
        else if (selectedIndex == 69)
        {
            await Navigation.PushAsync(new ScionTravelerMask());
        }
        else if (selectedIndex == 70)
        {
            await Navigation.PushAsync(new CrystariumHelm());
        }
        else if (selectedIndex == 71)
        {
            await Navigation.PushAsync(new AppointedCap());
        }
        else if (selectedIndex == 72)
        {
            await Navigation.PushAsync(new YakakuKami());
        }
        else if (selectedIndex == 73)
        {
            await Navigation.PushAsync(new LeafmanHead());
        }
        else if (selectedIndex == 74)
        {
            await Navigation.PushAsync(new HighlandHood());
        }
        else if (selectedIndex == 75)
        {
            await Navigation.PushAsync(new CoronalStrawHat());
        }
        else if (selectedIndex == 76)
        {
            await Navigation.PushAsync(new SpringStrawHat());
        }
        else if (selectedIndex == 77)
        {
            await Navigation.PushAsync(new Cloche());
        }
        else if (selectedIndex == 78)
        {
            await Navigation.PushAsync(new SprigganCap());
        }
        else if (selectedIndex == 79)
        {
            await Navigation.PushAsync(new CrescentMoonCone());
        }
        else if (selectedIndex == 80)
        {
            await Navigation.PushAsync(new CrescentMoonNightcap());
        }
        else if (selectedIndex == 81)
        {
            await Navigation.PushAsync(new OvalSpectacles());
        }
        else if (selectedIndex == 82)
        {
            await Navigation.PushAsync(new ShadedSpectacles());
        }
        else if (selectedIndex == 83)
        {
            await Navigation.PushAsync(new ContempPince());
        }
        else if (selectedIndex == 84)
        {
            await Navigation.PushAsync(new RimlessGlasses());
        }
        else if (selectedIndex == 85)
        {
            await Navigation.PushAsync(new ThickrimmedGlasses());
        }
        else if (selectedIndex == 86)
        {
            await Navigation.PushAsync(new GryphonskinEyepatch());
        }
        else if (selectedIndex == 87)
        {
            await Navigation.PushAsync(new ImpShadVis());
        }
        else if (selectedIndex == 88)
        {
            await Navigation.PushAsync(new MinistrelSpectacle());
        }
        else if (selectedIndex == 89)
        {
            await Navigation.PushAsync(new ClassicSpectacle());
        }
        else if (selectedIndex == 90)
        {
            await Navigation.PushAsync(new ImitationMistbeardMask());
        }
        else if (selectedIndex == 91)
        {
            await Navigation.PushAsync(new TheEmperorNewHat());
        }
        else if (selectedIndex == 92)
        {
            await Navigation.PushAsync(new OvalReadingGlasses());
        }
        else if (selectedIndex == 93)
        {
            await Navigation.PushAsync(new CoeurlEyeglasses());
        }
        else if (selectedIndex == 93)
        {
            await Navigation.PushAsync(new ThavnarianTurban());
        }
        else if (selectedIndex == 94)
        {
            await Navigation.PushAsync(new ThavnarianHeaddress());
        }
        else if (selectedIndex == 95)
        {
            await Navigation.PushAsync(new FlatCap());
        }
        else if (selectedIndex == 96)
        {
            await Navigation.PushAsync(new RedBeret());
        }
        else if (selectedIndex == 97)
        {
            await Navigation.PushAsync(new GreenBeret());
        }
        else if (selectedIndex == 98)
        {
            await Navigation.PushAsync(new WhiteBeret());
        }
        else if (selectedIndex == 99)
        {
            await Navigation.PushAsync(new ElegRimlessGlass());
        }
        else if (selectedIndex == 100)
        {
            await Navigation.PushAsync(new ReadingGlasses());
        }
        else if (selectedIndex == 101)
        {
            await Navigation.PushAsync(new HighHouseCloche());
        }
        else if (selectedIndex == 102)
        {
            await Navigation.PushAsync(new ArchaeoskinCloche());
        }
        else if (selectedIndex == 103)
        {
            await Navigation.PushAsync(new WindSilkWedgeCap());
        }
        else if (selectedIndex == 104)
        {
            await Navigation.PushAsync(new NewWorldHeaddress());
        }
        else if (selectedIndex == 105)
        {
            await Navigation.PushAsync(new SurvivalHat());
        }
        else if (selectedIndex == 106)
        {
            await Navigation.PushAsync(new MoonfireHat());
        }
        else if (selectedIndex == 107)
        {
            await Navigation.PushAsync(new BoarskinSurvivalHat());
        }
        else if (selectedIndex == 108)
        {
            await Navigation.PushAsync(new RamieHood());
        }
        else if (selectedIndex == 109)
        {
            await Navigation.PushAsync(new CashmereHood());
        }
        else if (selectedIndex == 110)
        {
            await Navigation.PushAsync(new WoolKnitCap());
        }
        else if (selectedIndex == 111)
        {
            await Navigation.PushAsync(new FlannelKnitCap());
        }
        else if (selectedIndex == 112)
        {
            await Navigation.PushAsync(new TaoistCap());
        }
        else if (selectedIndex == 113)
        {
            await Navigation.PushAsync(new NonLa());
        }
        else if (selectedIndex == 114)
        {
            await Navigation.PushAsync(new EmperorHairpin());
        }
        else if (selectedIndex == 115)
        {
            await Navigation.PushAsync(new AnemosHat());
        }
        else if (selectedIndex == 116)
        {
            await Navigation.PushAsync(new AnemosPotHat());
        }
        else if (selectedIndex == 117)
        {
            await Navigation.PushAsync(new BouleHat());
        }
        else if (selectedIndex == 118)
        {
            await Navigation.PushAsync(new PagosBandana());
        }
        else if (selectedIndex == 119)
        {
            await Navigation.PushAsync(new PagosCirclet());
        }
        else if (selectedIndex == 120)
        {
            await Navigation.PushAsync(new QuainHat());
        }
        else if (selectedIndex == 121)
        {
            await Navigation.PushAsync(new ArcaheodHorns());
        }
        else if (selectedIndex == 122)
        {
            await Navigation.PushAsync(new RainHood());
        }
        else if (selectedIndex == 123)
        {
            await Navigation.PushAsync(new ReplSkyPirHelmFending());
        }
        else if (selectedIndex == 124)
        {
            await Navigation.PushAsync(new ReplSkyPirHelmMaiming());
        }
        else if (selectedIndex == 125)
        {
            await Navigation.PushAsync(new ReplSkyPirMaskStriking());
        }
        else if (selectedIndex == 126)
        {
            await Navigation.PushAsync(new ReplSkyPirBeretAiming());
        }
        else if (selectedIndex == 127)
        {
            await Navigation.PushAsync(new ReplSkyPirMaskScouting());
        }
        else if (selectedIndex == 128)
        {
            await Navigation.PushAsync(new ReplSkyPirCapHealing());
        }
        else if (selectedIndex == 129)
        {
            await Navigation.PushAsync(new ReplSkyPirCapCasting());
        }
        else if (selectedIndex == 130)
        {
            await Navigation.PushAsync(new ReplSkyRatMaskFending());
        }
        else if (selectedIndex == 131)
        {
            await Navigation.PushAsync(new ReplSkyRatMaskMaiming());
        }
        else if (selectedIndex == 132)
        {
            await Navigation.PushAsync(new ReplSkyRatMaskStriking());
        }
        else if (selectedIndex == 133)
        {
            await Navigation.PushAsync(new ReplSkyRatMaskAiming());
        }
        else if (selectedIndex == 134)
        {
            await Navigation.PushAsync(new ReplSkyRatMaskScouting());
        }
        else if (selectedIndex == 135)
        {
            await Navigation.PushAsync(new ReplSkyRatMaskHealing());
        }
        else if (selectedIndex == 136)
        {
            await Navigation.PushAsync(new ReplSkyRatMaskCasting());
        }
        else if (selectedIndex == 137)
        {
            await Navigation.PushAsync(new KupoCrown());
        }
        else if (selectedIndex == 138)
        {
            await Navigation.PushAsync(new KupoKnitCap());
        }
        else if (selectedIndex == 139)
        {
            await Navigation.PushAsync(new HraeHat());
        }
        else if (selectedIndex == 140)
        {
            await Navigation.PushAsync(new SkyworkerHelmet());
        }
        else if (selectedIndex == 141)
        {
            await Navigation.PushAsync(new CalfskinRiderCap());
        }
        else if (selectedIndex == 142)
        {
            await Navigation.PushAsync(new FrontierHat());
        }
        else if (selectedIndex == 143)
        {
            await Navigation.PushAsync(new FrontierRibbon());
        }
        else if (selectedIndex == 144)
        {
            await Navigation.PushAsync(new PeaceloverHat());
        }
        else if (selectedIndex == 145)
        {
            await Navigation.PushAsync(new ExciteIMask());
        }
        else if (selectedIndex == 150)
        {
            await Navigation.PushAsync(new SharlayanDiadema());
        }
        else if (selectedIndex == 151)
        {
            await Navigation.PushAsync(new ThavnairianRibbon());
        }
        else if (selectedIndex == 152)
        {
            await Navigation.PushAsync(new RedRibbon());
        }
        else if (selectedIndex == 153)
        {
            await Navigation.PushAsync(new VarsityFlatCap());
        }
        else if (selectedIndex == 154)
        {
            await Navigation.PushAsync(new IsleExplorerHat());
        }
        else if (selectedIndex == 155)
        {
            await Navigation.PushAsync(new NoirHat());
        }
        else if (selectedIndex == 156)
        {
            await Navigation.PushAsync(new LawlessEnforcerHat());
        }
        else if (selectedIndex == 157)
        {
            await Navigation.PushAsync(new IsleShepherdHeaddress());
        }
        else if (selectedIndex == 158)
        {
            await Navigation.PushAsync(new IsleVacationerVisor());
        }
        else if (selectedIndex == 159)
        {
            await Navigation.PushAsync(new SalonServerHat());
        }
        else if (selectedIndex == 160)
        {
            await Navigation.PushAsync(new PlainPajamaEyeMask());
        }
        else if (selectedIndex == 161)
        {
            await Navigation.PushAsync(new CactuarPajamaEyeMask());
        }
        else if (selectedIndex == 162)
        {
            await Navigation.PushAsync(new ChocoboPajamaEyeMask());
        }
        else if (selectedIndex == 163)
        {
            await Navigation.PushAsync(new BaronialHat());
        }
        else if (selectedIndex == 164)
        {
            await Navigation.PushAsync(new IslandResortStrawHat());
        }
        else if (selectedIndex == 165)
        {
            await Navigation.PushAsync(new DriedRedOldrose());
        }
        else if (selectedIndex == 166)
        {
            await Navigation.PushAsync(new DriedBlueOldrose());
        }
        else if (selectedIndex == 167)
        {
            await Navigation.PushAsync(new DriedYellowOldrose());
        }
        else if (selectedIndex == 168)
        {
            await Navigation.PushAsync(new DriedGreenOldrose());
        }
        else if (selectedIndex == 169)
        {
            await Navigation.PushAsync(new DriedOrangeOldrose());
        }
        else if (selectedIndex == 170)
        {
            await Navigation.PushAsync(new DriedPurpleOldrose());
        }
        else if (selectedIndex == 171)
        {
            await Navigation.PushAsync(new DriedWhiteOldrose());
        }
        else if (selectedIndex == 172)
        {
            await Navigation.PushAsync(new DriedBlackOldrose());
        }
        else if (selectedIndex == 173)
        {
            await Navigation.PushAsync(new OldroseCorsage());
        }
        else if (selectedIndex == 174)
        {
            await Navigation.PushAsync(new RedViolaCorsage());
        }
        else if (selectedIndex == 175)
        {
            await Navigation.PushAsync(new BlueViolaCorsage());
        }
        else if (selectedIndex == 176)
        {
            await Navigation.PushAsync(new YellowViolaCorsage());
        }
        else if (selectedIndex == 177)
        {
            await Navigation.PushAsync(new GreenViolaCorsage());
        }
        else if (selectedIndex == 178)
        {
            await Navigation.PushAsync(new OrangeViolaCorsage());
        }
        else if (selectedIndex == 179)
        {
            await Navigation.PushAsync(new PurpleViolaCorsage());
        }
        else if (selectedIndex == 180)
        {
            await Navigation.PushAsync(new WhiteViolaCorsage());
        }
        else if (selectedIndex == 181)
        {
            await Navigation.PushAsync(new BlackViolaCorsage());
        }
        else if (selectedIndex == 182)
        {
            await Navigation.PushAsync(new RainbowViolaCorsage());
        }
        else if (selectedIndex == 183)
        {
            await Navigation.PushAsync(new RedCherryBlossomCorsage());
        }
        else if (selectedIndex == 184)
        {
            await Navigation.PushAsync(new BlueCherryBlossomCorsage());
        }
        else if (selectedIndex == 185)
        {
            await Navigation.PushAsync(new YellowCherryBlossomCorsage());
        }
        else if (selectedIndex == 186)
        {
            await Navigation.PushAsync(new GreenCherryBlossomCorsage());
        }
        else if (selectedIndex == 187)
        {
            await Navigation.PushAsync(new OrangeCherryBlossomCorsage());
        }
        else if (selectedIndex == 188)
        {
            await Navigation.PushAsync(new PurpleCherryBlossomCorsage());
        }
        else if (selectedIndex == 189)
        {
            await Navigation.PushAsync(new WhiteCherryBlossomCorsage());
        }
        else if (selectedIndex == 190)
        {
            await Navigation.PushAsync(new BlackCherryBlossomCorsage());
        }
        else if (selectedIndex == 191)
        {
            await Navigation.PushAsync(new PinkCherryBlossomCorsage());
        }
        else if (selectedIndex == 192)
        {
            await Navigation.PushAsync(new RedDaisyCorsage());
        }
        else if (selectedIndex == 193)
        {
            await Navigation.PushAsync(new BlueDaisyCorsage());
        }
        else if (selectedIndex == 194)
        {
            await Navigation.PushAsync(new YellowDaisyCorsage());
        }
        else if (selectedIndex == 195)
        {
            await Navigation.PushAsync(new GreenDaisyCorsage());
        }
        else if (selectedIndex == 196)
        {
            await Navigation.PushAsync(new OrangeDaisyCorsage());
        }
        else if (selectedIndex == 197)
        {
            await Navigation.PushAsync(new PurpleDaisyCorsage());
        }
        else if (selectedIndex == 198)
        {
            await Navigation.PushAsync(new WhiteDaisyCorsage());
        }
        else if (selectedIndex == 199)
        {
            await Navigation.PushAsync(new BlackDaisyCorsage());
        }
        else if (selectedIndex == 200)
        {
            await Navigation.PushAsync(new RainbowDaisyCorsage());
        }
        else if (selectedIndex == 201)
        {
            await Navigation.PushAsync(new RedBrightlilyCorsage());
        }
        else if (selectedIndex == 202)
        {
            await Navigation.PushAsync(new BlueBrightlilyCorsage());
        }
        else if (selectedIndex == 203)
        {
            await Navigation.PushAsync(new YellowBrightlilyCorsage());
        }
        else if (selectedIndex == 204)
        {
            await Navigation.PushAsync(new GreenBrightlilyCorsage());
        }
        else if (selectedIndex == 205)
        {
            await Navigation.PushAsync(new OrangeBrightlilyCorsage());
        }
        else if (selectedIndex == 206)
        {
            await Navigation.PushAsync(new PurpleBrightlilyCorsage());
        }
        else if (selectedIndex == 207)
        {
            await Navigation.PushAsync(new WhiteBrightlilyCorsage());
        }
        else if (selectedIndex == 208)
        {
            await Navigation.PushAsync(new BlackBrightlilyCorsage());
        }
        else if (selectedIndex == 209)
        {
            await Navigation.PushAsync(new RainbowBrightlilyCorsage());
        }
        else if (selectedIndex == 210)
        {
            await Navigation.PushAsync(new RedDhaliaCorsage());
        }
        else if (selectedIndex == 211)
        {
            await Navigation.PushAsync(new BlueDhaliaCorsage());
        }
        else if (selectedIndex == 212)
        {
            await Navigation.PushAsync(new YellowDhaliaCorsage());
        }
        else if (selectedIndex == 213)
        {
            await Navigation.PushAsync(new GreenDhaliaCorsage());
        }
        else if (selectedIndex == 214)
        {
            await Navigation.PushAsync(new OrangeDhaliaCorsage());
        }
        else if (selectedIndex == 215)
        {
            await Navigation.PushAsync(new PurpleDhaliaCorsage());
        }
        else if (selectedIndex == 216)
        {
            await Navigation.PushAsync(new WhiteDhaliaCorsage());
        }
        else if (selectedIndex == 217)
        {
            await Navigation.PushAsync(new BlackDhaliaCorsage());
        }
        else if (selectedIndex == 218)
        {
            await Navigation.PushAsync(new RainbowDhaliaCorsage());
        }
        else if (selectedIndex == 219)
        {
            await Navigation.PushAsync(new RedArumCorsage());
        }
        else if (selectedIndex == 220)
        {
            await Navigation.PushAsync(new BlueArumCorsage());
        }
        else if (selectedIndex == 221)
        {
            await Navigation.PushAsync(new YellowArumCorsage());
        }
        else if (selectedIndex == 222)
        {
            await Navigation.PushAsync(new GreenArumCorsage());
        }
        else if (selectedIndex == 223)
        {
            await Navigation.PushAsync(new OrangeArumCorsage());
        }
        else if (selectedIndex == 224)
        {
            await Navigation.PushAsync(new PurpleArumCorsage());
        }
        else if (selectedIndex == 225)
        {
            await Navigation.PushAsync(new WhiteArumCorsage());
        }
        else if (selectedIndex == 226)
        {
            await Navigation.PushAsync(new BlackArumCorsage());
        }
        else if (selectedIndex == 227)
        {
            await Navigation.PushAsync(new RainbowArumCorsage());
        }
        else if (selectedIndex == 228)
        {
            await Navigation.PushAsync(new RedLilyValleyCorsage());
        }
        else if (selectedIndex == 229)
        {
            await Navigation.PushAsync(new BlueLilyValleyCorsage());
        }
        else if (selectedIndex == 229)
        {
            await Navigation.PushAsync(new YellowLilyValleyCorsage());
        }
        else if (selectedIndex == 230)
        {
            await Navigation.PushAsync(new GreenLilyValleyCorsage());
        }
        else if (selectedIndex == 231)
        {
            await Navigation.PushAsync(new OrangeLilyValleyCorsage());
        }
        else if (selectedIndex == 232)
        {
            await Navigation.PushAsync(new PurpleLilyValleyCorsage());
        }
        else if (selectedIndex == 233)
        {
            await Navigation.PushAsync(new WhiteLilyValleyCorsage());
        }
        else if (selectedIndex == 234)
        {
            await Navigation.PushAsync(new BlackLilyValleyCorsage());
        }
        else if (selectedIndex == 235)
        {
            await Navigation.PushAsync(new RainbowLilyValleyCorsage());
        }
        else if (selectedIndex == 236)
        {
            await Navigation.PushAsync(new RedHydrangeaCorsage());
        }
        else if (selectedIndex == 237)
        {
            await Navigation.PushAsync(new BlueHydrangeaCorsage());
        }
        else if (selectedIndex == 238)
        {
            await Navigation.PushAsync(new YellowHydrangeaCorsage());
        }
        else if (selectedIndex == 239)
        {
            await Navigation.PushAsync(new GreenHydrangeaCorsage());
        }
        else if (selectedIndex == 240)
        {
            await Navigation.PushAsync(new OrangeHydrangeaCorsage());
        }
        else if (selectedIndex == 241)
        {
            await Navigation.PushAsync(new PurpleHydrangeaCorsage());
        }
        else if (selectedIndex == 242)
        {
            await Navigation.PushAsync(new WhiteHydrangeaCorsage());
        }
        else if (selectedIndex == 243)
        {
            await Navigation.PushAsync(new BlackHydrangeaCorsage());
        }
        else if (selectedIndex == 244)
        {
            await Navigation.PushAsync(new RainbowHydrangeaCorsage());
        }
        else if (selectedIndex == 245)
        {
            await Navigation.PushAsync(new RedCampanulaCorsage());
        }
        else if (selectedIndex == 246)
        {
            await Navigation.PushAsync(new BlueCampanulaCorsage());
        }
        else if (selectedIndex == 247)
        {
            await Navigation.PushAsync(new YellowCampanulaCorsage());
        }
        else if (selectedIndex == 248)
        {
            await Navigation.PushAsync(new GreenCampanulaCorsage());
        }
        else if (selectedIndex == 249)
        {
            await Navigation.PushAsync(new OrangeCampanulaCorsage());
        }
        else if (selectedIndex == 250)
        {
            await Navigation.PushAsync(new PurpleCampanulaCorsage());
        }
        else if (selectedIndex == 251)
        {
            await Navigation.PushAsync(new WhiteCampanulaCorsage());
        }
        else if (selectedIndex == 252)
        {
            await Navigation.PushAsync(new BlackCampanulaCorsage());
        }
        else if (selectedIndex == 253)
        {
            await Navigation.PushAsync(new RainbowCampanulaCorsage());
        }
        else if (selectedIndex == 254)
        {
            await Navigation.PushAsync(new RedHyacinthCorsage());
        }
        else if (selectedIndex == 255)
        {
            await Navigation.PushAsync(new BlueHyacinthCorsage());
        }
        else if (selectedIndex == 256)
        {
            await Navigation.PushAsync(new YellowHyacinthCorsage());
        }
        else if (selectedIndex == 257)
        {
            await Navigation.PushAsync(new GreenHyacinthCorsage());
        }
        else if (selectedIndex == 258)
        {
            await Navigation.PushAsync(new OrangeHyacinthCorsage());
        }
        else if (selectedIndex == 259)
        {
            await Navigation.PushAsync(new PurpleHyacinthCorsage());
        }
        else if (selectedIndex == 260)
        {
            await Navigation.PushAsync(new WhiteHyacinthCorsage());
        }
        else if (selectedIndex == 261)
        {
            await Navigation.PushAsync(new BlackHyacinthCorsage());
        }
        else if (selectedIndex == 262)
        {
            await Navigation.PushAsync(new RainbowHyacinthCorsage());
        }
        else if (selectedIndex == 263)
        {
            await Navigation.PushAsync(new RedCosmosCorsage());
        }
        else if (selectedIndex == 264)
        {
            await Navigation.PushAsync(new BlueCosmosCorsage());
        }
        else if (selectedIndex == 265)
        {
            await Navigation.PushAsync(new YellowCosmosCorsage());
        }
        else if (selectedIndex == 266)
        {
            await Navigation.PushAsync(new GreenCosmosCorsage());
        }
        else if (selectedIndex == 267)
        {
            await Navigation.PushAsync(new OrangeCosmosCorsage());
        }
        else if (selectedIndex == 268)
        {
            await Navigation.PushAsync(new PurpleCosmosCorsage());
        }
        else if (selectedIndex == 269)
        {
            await Navigation.PushAsync(new WhiteCosmosCorsage());
        }
        else if (selectedIndex == 270)
        {
            await Navigation.PushAsync(new BlackCosmosCorsage());
        }
        else if (selectedIndex == 271)
        {
            await Navigation.PushAsync(new RainbowCosmosCorsage());
        }
        else if (selectedIndex == 272)
        {
            await Navigation.PushAsync(new RedMorningGloryCorsage());
        }
        else if (selectedIndex == 273)
        {
            await Navigation.PushAsync(new BlueMorningGloryCorsage());
        }
        else if (selectedIndex == 274)
        {
            await Navigation.PushAsync(new YellowMorningGloryCorsage());
        }
        else if (selectedIndex == 275)
        {
            await Navigation.PushAsync(new GreenMorningGloryCorsage());
        }
        else if (selectedIndex == 276)
        {
            await Navigation.PushAsync(new OrangeMorningGloryCorsage());
        }
        else if (selectedIndex == 277)
        {
            await Navigation.PushAsync(new PurpleMorningGloryCorsage());
        }
        else if (selectedIndex == 278)
        {
            await Navigation.PushAsync(new WhiteMorningGloryCorsage());
        }
        else if (selectedIndex == 279)
        {
            await Navigation.PushAsync(new BlackMorningGloryCorsage());
        }
        else if (selectedIndex == 280)
        {
            await Navigation.PushAsync(new RainbowMorningGloryCorsage());
        }
        else if (selectedIndex == 281)
        {
            await Navigation.PushAsync(new RedChrysanthemumCorsage());
        }
        else if (selectedIndex == 282)
        {
            await Navigation.PushAsync(new BlueChrysanthemumCorsage());
        }
        else if (selectedIndex == 283)
        {
            await Navigation.PushAsync(new YellowChrysanthemumCorsage());
        }
        else if (selectedIndex == 284)
        {
            await Navigation.PushAsync(new GreenChrysanthemumCorsage());
        }
        else if (selectedIndex == 285)
        {
            await Navigation.PushAsync(new OrangeChrysanthemumCorsage());
        }
        else if (selectedIndex == 286)
        {
            await Navigation.PushAsync(new PurpleChrysanthemumCorsage());
        }
        else if (selectedIndex == 287)
        {
            await Navigation.PushAsync(new WhiteChrysanthemumCorsage());
        }
        else if (selectedIndex == 288)
        {
            await Navigation.PushAsync(new BlackChrysanthemumCorsage());
        }
        else if (selectedIndex == 289)
        {
            await Navigation.PushAsync(new RainbowChrysanthemumCorsage());
        }
        else if (selectedIndex == 290)
        {
            await Navigation.PushAsync(new UsagiKabuto());
        }
        else if (selectedIndex == 291)
        {
            await Navigation.PushAsync(new DragonKabuto());
        }
        else if (selectedIndex == 292)
        {
            await Navigation.PushAsync(new CrimsonDragonKabuto());
        }
        else if (selectedIndex == 293)
        {
            await Navigation.PushAsync(new GoldenDragonKabuto());
        }
        else if (selectedIndex == 294)
        {
            await Navigation.PushAsync(new BlackDragonKabuto());
        }
        else if (selectedIndex == 295)
        {
            await Navigation.PushAsync(new SilverSnakeKabuto());
        }
        else if (selectedIndex == 296)
        {
            await Navigation.PushAsync(new UmaKabuto());
        }
        else if (selectedIndex == 297)
        {
            await Navigation.PushAsync(new CrimsonUmaKabuto());
        }
        else if (selectedIndex == 298)
        {
            await Navigation.PushAsync(new GoldenUmaKabuto());
        }
        else if (selectedIndex == 299)
        {
            await Navigation.PushAsync(new BlackUmaKabuto());
        }
        else if (selectedIndex == 300)
        {
            await Navigation.PushAsync(new HitsujiKabuto());
        }
        else if (selectedIndex == 301)
        {
            await Navigation.PushAsync(new BlackHitsujiKabuto());
        }
        else if (selectedIndex == 302)
        {
            await Navigation.PushAsync(new CrimsonHitsujiKabuto());
        }
        else if (selectedIndex == 303)
        {
            await Navigation.PushAsync(new SeeNoHelm());
        }
        else if (selectedIndex == 304)
        {
            await Navigation.PushAsync(new SpeakNoHelm());
        }
        else if (selectedIndex == 305)
        {
            await Navigation.PushAsync(new HearNoHelm());
        }
        else if (selectedIndex == 306)
        {
            await Navigation.PushAsync(new RedToriKabuto());
        }
        else if (selectedIndex == 307)
        {
            await Navigation.PushAsync(new BlackToriKabuto());
        }
        else if (selectedIndex == 308)
        {
            await Navigation.PushAsync(new WhiteInuKabuto());
        }
        else if (selectedIndex == 309)
        {
            await Navigation.PushAsync(new BlackInuKabuto());
        }
        else if (selectedIndex == 310)
        {
            await Navigation.PushAsync(new InoshishiKabuto());
        }
        else if (selectedIndex == 311)
        {
            await Navigation.PushAsync(new CrimsonInoshishiKabuto());
        }
        else if (selectedIndex == 312)
        {
            await Navigation.PushAsync(new CrimsonNezumiKabuto());
        }
        else if (selectedIndex == 313)
        {
            await Navigation.PushAsync(new CobaltNezumiKabuto());
        }
        else if (selectedIndex == 314)
        {
            await Navigation.PushAsync(new CrimsonUshiKabuto());
        }
        else if (selectedIndex == 315)
        {
            await Navigation.PushAsync(new BlackUshiKabuto());
        }
        else if (selectedIndex == 316)
        {
            await Navigation.PushAsync(new GoldenToraKabuto());
        }
        else if (selectedIndex == 317)
        {
            await Navigation.PushAsync(new SilverToraKabuto());
        }
        else if (selectedIndex == 318)
        {
            await Navigation.PushAsync(new ValentioneHat());
        }
        else if (selectedIndex == 319)
        {
            await Navigation.PushAsync(new BlackfeatheredFlatHat());
        }
        else if (selectedIndex == 320)
        {
            await Navigation.PushAsync(new RedfeatheredFlatHat());
        }
        else if (selectedIndex == 321)
        {
            await Navigation.PushAsync(new ValentioneRoseHat());
        }
        else if (selectedIndex == 322)
        {
            await Navigation.PushAsync(new ValentioneForgetmenotHat());
        }
        else if (selectedIndex == 323)
        {
            await Navigation.PushAsync(new ValentioneAcaciaHat());
        }
        else if (selectedIndex == 324)
        {
            await Navigation.PushAsync(new ValentioneRoseRibbonedHat());
        }
        else if (selectedIndex == 325)
        {
            await Navigation.PushAsync(new ValentioneForgetMeNotRibbonedHat());
        }
        else if (selectedIndex == 326)
        {
            await Navigation.PushAsync(new ValentioneAcaciaRibbonedHat());
        }
        else if (selectedIndex == 327)
        {
            await Navigation.PushAsync(new LovelyMoogleCap());
        }
        else if (selectedIndex == 328)
        {
            await Navigation.PushAsync(new ValentioneEmissaryHat());
        }
        else if (selectedIndex == 329)
        {
            await Navigation.PushAsync(new ValentioneEmissaryDressHat());
        }
        else if (selectedIndex == 330)
        {
            await Navigation.PushAsync(new SongbirdHat());
        }
        else if (selectedIndex == 331)
        {
            await Navigation.PushAsync(new FlowerCrown());
        }
        else if (selectedIndex == 332)
        {
            await Navigation.PushAsync(new SeneschalsMonocle());
        }
        else if (selectedIndex == 333)
        {
            await Navigation.PushAsync(new PrincessPeachCorsage());
        }
        else if (selectedIndex == 334)
        {
            await Navigation.PushAsync(new LittleLadyCrown());
        }
        else if (selectedIndex == 335)
        {
            await Navigation.PushAsync(new RabbitHead());
        }
        else if (selectedIndex == 336)
        {
            await Navigation.PushAsync(new ChickenHead());
        }
        else if (selectedIndex == 337)
        {
            await Navigation.PushAsync(new TonberryHead());
        }
        else if (selectedIndex == 338)
        {
            await Navigation.PushAsync(new OschonRoselleCapeline());
        }
        else if (selectedIndex == 339)
        {
            await Navigation.PushAsync(new GoldRoselleCapeline());
        }
        else if (selectedIndex == 340)
        {
            await Navigation.PushAsync(new PearlRoselleCapeline());
        }
        else if (selectedIndex == 341)
        {
            await Navigation.PushAsync(new StrawCapeline());
        }
        else if (selectedIndex == 342)
        {
            await Navigation.PushAsync(new EndlessSummerGlasses());
        }
        else if (selectedIndex == 343)
        {
            await Navigation.PushAsync(new MoonfireHachimaki());
        }
        else if (selectedIndex == 344)
        {
            await Navigation.PushAsync(new WhitePaintedMoogleMask());
        }
        else if (selectedIndex == 345)
        {
            await Navigation.PushAsync(new BlackPaintedMoogleMask());
        }
        else if (selectedIndex == 346)
        {
            await Navigation.PushAsync(new PaintedNamazuMask());
        }
        else if (selectedIndex == 347)
        {
            await Navigation.PushAsync(new SummerFlameHat());
        }
        else if (selectedIndex == 348)
        {
            await Navigation.PushAsync(new SummerSunsetBandana());
        }
        else if (selectedIndex == 349)
        {
            await Navigation.PushAsync(new PumpkinHead());
        }
        else if (selectedIndex == 350)
        {
            await Navigation.PushAsync(new UnripenedPumpkinHead());
        }
        else if (selectedIndex == 351)
        {
            await Navigation.PushAsync(new WhitePumpkinHead());
        }
        else if (selectedIndex == 352)
        {
            await Navigation.PushAsync(new RipenedPumpkinHead());
        }
        else if (selectedIndex == 353)
        {
            await Navigation.PushAsync(new EerieHat());
        }
        else if (selectedIndex == 354)
        {
            await Navigation.PushAsync(new WitchsHat());
        }
        else if (selectedIndex == 355)
        {
            await Navigation.PushAsync(new WerewolfHead());
        }
        else if (selectedIndex == 356)
        {
            await Navigation.PushAsync(new ClownsHat());
        }
        else if (selectedIndex == 357)
        {
            await Navigation.PushAsync(new WakeDoctorsMask());
        }
        else if (selectedIndex == 358)
        {
            await Navigation.PushAsync(new DreamHat());
        }
        else if (selectedIndex == 359)
        {
            await Navigation.PushAsync(new ReindeerAntlers());
        }
        else if (selectedIndex == 360)
        {
            await Navigation.PushAsync(new SnowmanHead());
        }
        else if (selectedIndex == 361)
        {
            await Navigation.PushAsync(new StarlightSugarloafHat());
        }
        else if (selectedIndex == 362)
        {
            await Navigation.PushAsync(new FalseMustache());
        }
        else if (selectedIndex == 363)
        {
            await Navigation.PushAsync(new ReindeerAntlerHeadband());
        }
        else if (selectedIndex == 364)
        {
            await Navigation.PushAsync(new SaintsBeard());
        }
        else if (selectedIndex == 365)
        {
            await Navigation.PushAsync(new SaintsCap());
        }
        else if (selectedIndex == 366)
        {
            await Navigation.PushAsync(new ChoirHat());
        }
        else if (selectedIndex == 367)
        {
            await Navigation.PushAsync(new BaronHelm());
        }
        else if (selectedIndex == 368)
        {
            await Navigation.PushAsync(new BaronCirclet());
        }
        else if (selectedIndex == 369)
        {
            await Navigation.PushAsync(new WildRoseBandana());
        }
        else if (selectedIndex == 370)
        {
            await Navigation.PushAsync(new AmatsuHachigane());
        }
        else if (selectedIndex == 371)
        {
            await Navigation.PushAsync(new LegacyWarriorCoronet());
        }
        else if (selectedIndex == 372)
        {
            await Navigation.PushAsync(new KingSlimeCrown());
        }
        else if (selectedIndex == 373)
        {
            await Navigation.PushAsync(new AugRathHelmM());
        }
        else if (selectedIndex == 374)
        {
            await Navigation.PushAsync(new AugRathHelmF());
        }
        else if (selectedIndex == 375)
        {
            await Navigation.PushAsync(new RathHelmM());
        }
        else if (selectedIndex == 376)
        {
            await Navigation.PushAsync(new RathHelmF());
        }
        else if (selectedIndex == 377)
        {
            await Navigation.PushAsync(new No2TypeBGoggles());
        }
        else if (selectedIndex == 378)
        {
            await Navigation.PushAsync(new SweetDreamCap());
        }
        else if (selectedIndex == 379)
        {
            await Navigation.PushAsync(new TetsujiUsagiKabuto());
        }
        else if (selectedIndex == 380)
        {
            await Navigation.PushAsync(new BlackTetsujiUsagiKabuto());
        }
        else if (selectedIndex == 381)
        {
            await Navigation.PushAsync(new SilverTetsujiUsagiKabuto());
        }
        else if (selectedIndex == 382)
        {
            await Navigation.PushAsync(new VeilEternalInnocence());
        }
        else if (selectedIndex == 383)
        {
            await Navigation.PushAsync(new VeilEternalPassion());
        }
        else if (selectedIndex == 384)
        {
            await Navigation.PushAsync(new VeilEternalDevotion());
        }
        else if (selectedIndex == 385)
        {
            await Navigation.PushAsync(new MoogleHead());
        }
        else if (selectedIndex == 386)
        {
            await Navigation.PushAsync(new YellowpommedMoogleCap());
        }
        else if (selectedIndex == 387)
        {
            await Navigation.PushAsync(new ScionStrikersVisor());
        }
        else if (selectedIndex == 388)
        {
            await Navigation.PushAsync(new ScionThauMonocle());
        }
        else if (selectedIndex == 389)
        {
            await Navigation.PushAsync(new HeadEngineerGoggles());
        }
        else if (selectedIndex == 390)
        {
            await Navigation.PushAsync(new IronworksEngineerGoggles());
        }
        else if (selectedIndex == 391)
        {
            await Navigation.PushAsync(new HousemaidsBrim());
        }
        else if (selectedIndex == 392)
        {
            await Navigation.PushAsync(new ButlersMonocle());
        }
        else if (selectedIndex == 393)
        {
            await Navigation.PushAsync(new FarEasternNobleMortarboard());
        }
        else if (selectedIndex == 394)
        {
            await Navigation.PushAsync(new AngelicCirclet());
        }
        else if (selectedIndex == 395)
        {
            await Navigation.PushAsync(new DemonicHorns());
        }
        else if (selectedIndex == 396)
        {
            await Navigation.PushAsync(new FarEastGentlemansHat());
        }
        else if (selectedIndex == 397)
        {
            await Navigation.PushAsync(new FarEasternBeautysHairpin());
        }
        else if (selectedIndex == 398)
        {
            await Navigation.PushAsync(new StarNezhaLord());
        }
        else if (selectedIndex == 399)
        {
            await Navigation.PushAsync(new StarNezhaLady());
        }
        else if (selectedIndex == 400)
        {
            await Navigation.PushAsync(new LoyalHousemaidsBrim());
        }
        else if (selectedIndex == 401)
        {
            await Navigation.PushAsync(new LoyalButlersMonocle());
        }
        else if (selectedIndex == 402)
        {
            await Navigation.PushAsync(new BlackbosomHat());
        }
        else if (selectedIndex == 403)
        {
            await Navigation.PushAsync(new EmeraldCarbuncleEars());
        }
        else if (selectedIndex == 404)
        {
            await Navigation.PushAsync(new TopazCarbuncleEars());
        }
        else if (selectedIndex == 405)
        {
            await Navigation.PushAsync(new FaerieTalePrincesCirclet());
        }
        else if (selectedIndex == 406)
        {
            await Navigation.PushAsync(new FaerieTalePrincessTiara());
        }
        else if (selectedIndex == 407)
        {
            await Navigation.PushAsync(new CrackedMandervilleMonocle());
        }
        else if (selectedIndex == 408)
        {
            await Navigation.PushAsync(new MungaekHat());
        }
        else if (selectedIndex == 409)
        {
            await Navigation.PushAsync(new EasternSocialiteHat());
        }
        else if (selectedIndex == 410)
        {
            await Navigation.PushAsync(new FarEasternOfficerHat());
        }
        else if (selectedIndex == 411)
        {
            await Navigation.PushAsync(new FarEasternMaidenHat());
        }
        else if (selectedIndex == 412)
        {
            await Navigation.PushAsync(new LealSamuraiKasa());
        }
        else if (selectedIndex == 413)
        {
            await Navigation.PushAsync(new FESchoolboyHat());
        }
        else if (selectedIndex == 414)
        {
            await Navigation.PushAsync(new FESchoolgirlHairRibbon());
        }
        else if (selectedIndex == 415)
        {
            await Navigation.PushAsync(new ScionHearerHood());
        }
        else if (selectedIndex == 416)
        {
            await Navigation.PushAsync(new PeacockHat());
        }
        else if (selectedIndex == 417)
        {
            await Navigation.PushAsync(new EasternLordErrantHat());
        }
        else if (selectedIndex == 418)
        {
            await Navigation.PushAsync(new EasternLadyErrantHat());
        }
        else if (selectedIndex == 419)
        {
            await Navigation.PushAsync(new MhegDeacaCirclet());
        }
        else if (selectedIndex == 420)
        {
            await Navigation.PushAsync(new ScionSorceressHeaddress());
        }
        else if (selectedIndex == 421)
        {
            await Navigation.PushAsync(new RubyCarbuncleEars());
        }
        else if (selectedIndex == 422)
        {
            await Navigation.PushAsync(new BergHat());
        }
        else if (selectedIndex == 423)
        {
            await Navigation.PushAsync(new DirndlHat());
        }
        else if (selectedIndex == 424)
        {
            await Navigation.PushAsync(new ResshiHachigane());
        }
        else if (selectedIndex == 425)
        {
            await Navigation.PushAsync(new StreetCap());
        }
        else if (selectedIndex == 426)
        {
            await Navigation.PushAsync(new FatCatHood());
        }
        else if (selectedIndex == 427)
        {
            await Navigation.PushAsync(new FarNorthernHeadpiece());
        }
        else if (selectedIndex == 428)
        {
            await Navigation.PushAsync(new EducandsCap());
        }
        else if (selectedIndex == 429)
        {
            await Navigation.PushAsync(new ScarfWondrousWit());
        }
        else if (selectedIndex == 430)
        {
            await Navigation.PushAsync(new FriendshipCirclet());
        }
        else if (selectedIndex == 431)
        {
            await Navigation.PushAsync(new InfernoMask());
        }
        else if (selectedIndex == 432)
        {
            await Navigation.PushAsync(new CragMask());
        }
        else if (selectedIndex == 433)
        {
            await Navigation.PushAsync(new EasternJourneyCirclet());
        }
        else if (selectedIndex == 434)
        {
            await Navigation.PushAsync(new CaitSithEars());
        }
        else if (selectedIndex == 435)
        {
            await Navigation.PushAsync(new ExclusiveEasternJourneyCirclet());
        }
        else if (selectedIndex == 436)
        {
            await Navigation.PushAsync(new MatoyaHat());
        }
        else if (selectedIndex == 437)
        {
            await Navigation.PushAsync(new LeatherEyepatch());
        }
        else if (selectedIndex == 438)
        {
            await Navigation.PushAsync(new HempenBandana());
        }
        else if (selectedIndex == 439)
        {
            await Navigation.PushAsync(new HempenHat());
        }
        else if (selectedIndex == 440)
        {
            await Navigation.PushAsync(new BronzeChainCoif());
        }
        else if (selectedIndex == 441)
        {
            await Navigation.PushAsync(new HardLeatherPotHelm());
        }
        else if (selectedIndex == 442)
        {
            await Navigation.PushAsync(new BronzeSallet());
        }
        else if (selectedIndex == 443)
        {
            await Navigation.PushAsync(new StrawHat());
        }
        else if (selectedIndex == 444)
        {
            await Navigation.PushAsync(new AmateurHeadgear());
        }
        else if (selectedIndex == 445)
        {
            await Navigation.PushAsync(new AmateurHempenCoif());
        }
        else if (selectedIndex == 446)
        {
            await Navigation.PushAsync(new PristineEggCap());
        }
        else if (selectedIndex == 447)
        {
            await Navigation.PushAsync(new ThugsMug());
        }
        else
        {
            await Navigation.PushAsync(new EglbkCwn());
        }
    }
}