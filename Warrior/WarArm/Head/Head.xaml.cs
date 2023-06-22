namespace FinalFantasy14.Warrior.WarArm.Head;

public partial class Head : ContentPage
{
	public Head()
	{
		InitializeComponent();


	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new WarArm.Head.Level1_10.Head_Level1_10());
    }
}