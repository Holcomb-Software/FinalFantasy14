namespace FinalFantasy14.Gladiator.GladWpns;

public partial class GladWpn : ContentPage
{

	public GladWpn()
	{
        InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladWpns.Lv1_10());
    }
}