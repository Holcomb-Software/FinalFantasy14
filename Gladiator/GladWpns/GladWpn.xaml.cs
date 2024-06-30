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

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladWpns.Level31_40.Lv31_40());
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladWpns.Level41_50.Lv41_50());
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladWpns.Level51_60.Lv51_60());
    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladWpns.Level61_70.Level61_70());
    }

    private async void Button_Clicked_7(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladWpns.Level71_80.Lv71_80());
    }
}