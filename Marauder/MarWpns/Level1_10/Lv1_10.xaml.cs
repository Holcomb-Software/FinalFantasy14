namespace FinalFantasy14.Marauder.MarWpns.Level1_10;

public partial class Lv1_10 : ContentPage
{
	public Lv1_10()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.BlackHypo());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.BlackBsmReaper());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.Stampede());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.BloodyAnne());
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.Greycloud());
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.TarnishedDarkness());
    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.GiantAxe());
    }

    private async void Button_Clicked_7(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.ShoryuAxe());
    }

    private async void Button_Clicked_8(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.HellhoundAxe());
    }

    private async void Button_Clicked_9(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.WeatheredWarAxe());
    }

    private async void Button_Clicked_10(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.AugmentedHellhoundBattleaxe());
    }

    private async void Button_Clicked_11(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.BronzeWarAxe());
    }

    private async void Button_Clicked_12(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.BronzeLabrys());
    }

    private async void Button_Clicked_13(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marauder.MarWpns.Level1_10.CloudAxe());
    }
}