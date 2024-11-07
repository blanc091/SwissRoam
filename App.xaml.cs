using Microsoft.Maui.Controls;

namespace SwissRoam.Pages
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage()
		{
			//InitializeComponent();
		}

		private void OnLanguageChanged(object sender, EventArgs e)
		{
			var picker = (Picker)sender;
			var selectedLanguage = (string)picker.SelectedItem;
			DisplayAlert("Language Changed", $"You selected {selectedLanguage}", "OK");
		}

		private void OnNotificationsToggled(object sender, ToggledEventArgs e)
		{
			bool isNotificationsEnabled = e.Value;
			DisplayAlert("Notifications", isNotificationsEnabled ? "Enabled" : "Disabled", "OK");
		}

		private void OnDarkModeToggled(object sender, ToggledEventArgs e)
		{
			bool isDarkModeEnabled = e.Value;
			DisplayAlert("Dark Mode", isDarkModeEnabled ? "Enabled" : "Disabled", "OK");
		}
	}
}
