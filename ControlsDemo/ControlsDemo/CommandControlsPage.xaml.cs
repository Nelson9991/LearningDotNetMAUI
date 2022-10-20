namespace ControlsDemo;

public partial class CommandControlsPage : ContentPage
{
	public CommandControlsPage()
	{
		InitializeComponent();
	}

	private void btnTest_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Test", "This is a Demo", "OK");
	}

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		DisplayAlert("RadioButton", $"Changed: {e.Value}", "OK");
	}

	private void searchControl_SearchButtonPressed(object sender, EventArgs e)
	{
		DisplayAlert("Searching", $"Searching {searchControl.Text}", "OK");
	}

	private void SwipeItem_Invoked(object sender, EventArgs e)
	{
		DisplayAlert("Swipe View", "Element Tapped", "OK");
	}
}