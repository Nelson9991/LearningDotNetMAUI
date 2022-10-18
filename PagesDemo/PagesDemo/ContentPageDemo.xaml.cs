namespace PagesDemo;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}