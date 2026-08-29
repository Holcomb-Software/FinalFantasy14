using System.IO;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace FinalFantasy14.Armor;

public partial class Armor_Viewer : ContentPage
{
	public Armor_Viewer()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadWeaponDataAsync();
    }

    private async Task LoadWeaponDataAsync()
    {
        try
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("armor_accessories.json");
            using var reader = new StreamReader(stream);
            string jsonString = await reader.ReadToEndAsync();

            ArmorItem armor = JsonSerializer.Deserialize<ArmorItem>(jsonString);
            this.BindingContext = armor;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Failed to load JSON: {ex.Message}");
        }
    }
}