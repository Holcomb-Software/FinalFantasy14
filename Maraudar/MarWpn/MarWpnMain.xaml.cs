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
}