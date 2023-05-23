namespace FinalFantasy14.Armor;

public partial class ArmorMain : ContentPage
{
	public ArmorMain()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gladiator.GladiatorArm());
    }
}