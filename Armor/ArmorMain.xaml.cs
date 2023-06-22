namespace FinalFantasy14.Armor;

public partial class ArmorMain : ContentPage
{
	public ArmorMain()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladArm.GladiatorArm());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Warrior.WarArm.WarriorArm());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarArm.MarArmMain());
    }
}