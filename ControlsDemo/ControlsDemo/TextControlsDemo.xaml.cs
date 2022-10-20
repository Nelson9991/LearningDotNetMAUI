namespace ControlsDemo;

public partial class TextControlsDemo : ContentPage
{
	public TextControlsDemo()
	{
		InitializeComponent();
	}

	private void Entry_TextChanged(object sender, TextChangedEventArgs e)
	{
		//DisplayAlert("Nuevo Carater", e.NewTextValue, "OK");
	}

	private void Entry_Completed(object sender, EventArgs e)
	{
		DisplayAlert("Nuevo texto", txtNombre.Text, "OK");
	}
}