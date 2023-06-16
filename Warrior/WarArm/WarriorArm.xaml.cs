namespace FinalFantasy14.Warrior.WarArm;

public partial class WarriorArm : ContentPage
{

	public WarriorArm()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Warrior.WarArm.ArmParts());
    }
}