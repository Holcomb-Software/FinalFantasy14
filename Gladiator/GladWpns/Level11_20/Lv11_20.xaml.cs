namespace FinalFantasy14.Gladiator.GladWpns.Level11_20;

public partial class Lv11_20 : ContentPage
{
	public Lv11_20()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level11_20.AethBrassBstdSwrd());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level11_20.AethBrassVkngSwrd());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level11_20.AethCrngSwrd());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level11_20.BlazefireSaber());
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level11_20.BrassBstdSwrd());
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level11_20.BrassVkngSwrd());
    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level11_20.BronzeSpatha());
    }

    private async void Button_Clicked_7(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level11_20.CarnageSword());
    }

    private async void Button_Clicked_8(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level11_20.DoctoresScimitar());
    }

    private async void Button_Clicked_9(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level11_20.PlunderedFlachion());
    }
}