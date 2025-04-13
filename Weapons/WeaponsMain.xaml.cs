namespace FinalFantasy14.Weapons;

public partial class WeaponsMain : ContentPage
{	
	public WeaponsMain()
	{
		InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladWpns.GladWpn());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Warrior.WarWpns.WarWpn());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.MarWpnMain());
    }
}