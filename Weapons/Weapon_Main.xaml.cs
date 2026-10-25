using System.IO;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace FinalFantasy14.Weapons;

public partial class Weapon_Main : ContentPage
{
	public Weapon_Main()
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
			using var stream = await FileSystem.OpenAppPackageFileAsync("weapons.json");
			using var reader = new StreamReader(stream);
			string jsonString = await reader.ReadToEndAsync();

			WeaponItem weapon = JsonSerializer.Deserialize<WeaponItem>(jsonString);
			this.BindingContext = weapon;
		}
		catch (Exception ex)
		{
			System.Diagnostics.Debug.WriteLine($"Failed to load JSON: {ex.Message}");
		}
	}
}