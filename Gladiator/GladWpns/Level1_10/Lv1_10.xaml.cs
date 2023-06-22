namespace FinalFantasy14.Gladiator.GladWpns;

public partial class Lv1_10 : ContentPage
{
	public Lv1_10()
	{
        InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level1_10.Ultimum());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level1_10.Radiance());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level1_10.TrnFngWlf());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level1_10.HaliSwrd());
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level1_10.TrpSwrd());
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level1_10.AOScimitar());
    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level1_10.HHWarPick());
    }

    private async void Button_Clicked_7(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level1_10.WeatheredShortsword());
    }

    private async void Button_Clicked_8(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level1_10.BrBstSwd());
    }

    private async void Button_Clicked_9(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level1_10.VkgSwd());
    }

    private async void Button_Clicked_10(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level1_10.AshMac());
    }
}