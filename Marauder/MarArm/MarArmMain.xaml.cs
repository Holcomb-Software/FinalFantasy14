namespace FinalFantasy14.Marauder.MarArm;

public partial class MarArmMain : ContentPage
{
	public MarArmMain()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MarArm.Head.MarHeadMain());
    }
}