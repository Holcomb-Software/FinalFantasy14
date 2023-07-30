namespace FinalFantasy14.Gladiator.GladWpns;

public partial class GladWpn : ContentPage
{

	public GladWpn()
	{
        InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladWpns.Level1_10.Lv1_10());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladWpns.Level11_20.Lv11_20());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladWpns.Level21_30.Lv21_30());
    }
}