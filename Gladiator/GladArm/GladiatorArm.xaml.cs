namespace FinalFantasy14.Gladiator.GladArm;

public partial class GladiatorArm : ContentPage
{

	public GladiatorArm()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladArm.Shield.ShieldMain());
    }
}