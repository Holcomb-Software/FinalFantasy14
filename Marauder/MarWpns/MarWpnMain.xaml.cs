namespace FinalFantasy14.Marauder.MarWpns;

public partial class MarWpnMain : ContentPage
{
	public MarWpnMain()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.Lv1_10());
    }
}