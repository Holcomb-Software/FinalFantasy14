namespace FinalFantasy14.Gladiator.GladArm.Shield;

public partial class ShieldMain : ContentPage
{
	public ShieldMain()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladArm.Shield.Level1_10.ShieldLv1_10());
    }
}