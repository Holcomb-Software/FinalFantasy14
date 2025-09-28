namespace FinalFantasy14.Maraudar.MarWpn;

public partial class MarWpnMain : ContentPage
{
	public MarWpnMain()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl1_10.Lvl1_10());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl11_20.Lvl11_20());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.Lvl21_30());
    }
}