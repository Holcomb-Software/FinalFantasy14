namespace FinalFantasy14.Warrior.WarArm;

public partial class ArmParts : ContentPage
{
	public ArmParts()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Warrior.WarArm.Head.Head());
    }
}