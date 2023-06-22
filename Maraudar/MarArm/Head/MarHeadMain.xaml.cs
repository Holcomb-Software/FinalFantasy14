namespace FinalFantasy14.Maraudar.MarArm.Head;

public partial class MarHeadMain : ContentPage
{
	public MarHeadMain()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MarArm.Head.Level1_10.Level1_10());
    }
}