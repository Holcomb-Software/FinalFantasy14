namespace FinalFantasy14.Gladiator.GladWpns.Level41_50;

public partial class Lv41_50 : ContentPage
{
	public Lv41_50()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new GladWpns.Level41_50.AeolScimitar());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GladWpns.Level41_50.AethCobSham());
    }
}