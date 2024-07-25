using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;

namespace Cheatjockey2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        // Set the BindingContext to the ViewModel
        BindingContext = new MainPageViewModel();
	}

	private void SubmitButton_Click(object sender, EventArgs e)
	{
		count++;
		Console.WriteLine($"Submitted: {count}");
	}

	private void SearchButton_Click(object sender, EventArgs e)
	{
		count++;
		Console.WriteLine($"Searched: {count}");
	}

	private async void SettingsButton_Click(object sender, EventArgs e)
	{
   	 await Shell.Current.GoToAsync("///SettingsPage");
	}

	private void FolderButton_Click(object sender, EventArgs e)
	{
		count++;
		Console.WriteLine($"Folder: {count}");
	}

	private void MoreButton_Click(object sender, EventArgs e)
	{
		count++;
		Console.WriteLine($"More: {count}");
	}
}

