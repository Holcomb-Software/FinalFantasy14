using System.IO;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace FinalFantasy14.Items;

public partial class Item_Viewer : ContentPage
{
    public Item_Viewer()
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

            Item_Item armor = JsonSerializer.Deserialize<Item_Item>(jsonString);
            this.BindingContext = armor;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Failed to load JSON: {ex.Message}");
        }
    }
}