using System.Threading.Tasks;

namespace FinalFantasy14.Maraudar.MarWpn.Lvl21_30;

public partial class Lvl21_30 : ContentPage
{
	public Lvl21_30()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.SerpPvtAxe());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.StormPvtAxe());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.FlamePvtAxe());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.AethIronBill());
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.IronBill());
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.AethThunderstormAxe());
    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.ThunderstormAxe());
    }

    private async void Button_Clicked_7(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.ElmlordTusk());
    }

    private async void Button_Clicked_8(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.AethSpikedSteelLab());
    }

    private async void Button_Clicked_9(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.SpikedSteelLab());
    }

    private async void Button_Clicked_10(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.PawCrimsonCat());
    }

    private async void Button_Clicked_11(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.CharredAxe());
    }

    private async void Button_Clicked_12(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.SerpPvtLab());
    }

    private async void Button_Clicked_13(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.StormPvtLab());
    }

    private async void Button_Clicked_14(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl21_30.FlamePvtLab());
    }
}