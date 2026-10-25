using System.Threading.Tasks;

namespace FinalFantasy14.Maraudar.MarWpn.Lvl11_20;

public partial class Lvl11_20 : ContentPage
{
	public Lvl11_20()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl11_20.ICie_Bardiche());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl11_20.SpikedBrnzLabrys());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl11_20.IronWarAxe());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl11_20.AethIronWarAxe());
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl11_20.PlunderedBattleaxe());
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl11_20.AethIronLabrys());
    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl11_20.IronLabrys());
    }

    private async void Button_Clicked_7(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl11_20.InfernoAxe());
    }

    private async void Button_Clicked_8(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl11_20.AethInfernoAxe());
    }

    private async void Button_Clicked_9(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maraudar.MarWpn.Lvl11_20.DoctoresBill());
    }
}