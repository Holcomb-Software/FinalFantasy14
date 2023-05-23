namespace FinalFantasy14.Gladiator;

public partial class GladiatorArm : ContentPage
{

	public GladiatorArm()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.ArmLv1_10());
    }
}