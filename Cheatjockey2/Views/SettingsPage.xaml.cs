using Microsoft.Maui.Controls;

namespace Cheatjockey2
{
    public partial class SettingsPage : ContentPage
    {
		int count = 0;
        public SettingsPage()
        {
            InitializeComponent();
        }
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");            
        }

		private void SearchButton_Click(object sender, EventArgs e)
		{
			count++;
			Console.WriteLine($"Searched: {count}");
		}

        private void OnGeneralSettingsClicked(object sender, EventArgs e)
        {
            // Load general settings content
        }

        private void OnAccountSettingsClicked(object sender, EventArgs e)
        {
            // Load account settings content
        }

        private void OnPrivacySettingsClicked(object sender, EventArgs e)
        {
            // Load privacy settings content
        }

    }
}