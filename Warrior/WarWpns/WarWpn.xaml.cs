namespace FinalFantasy14.Warrior.WarWpns;

public partial class WarWpn : ContentPage
{
	public WarWpn()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Warrior.WarWpns.Lvl1_10.Lv1_10());
    }
}