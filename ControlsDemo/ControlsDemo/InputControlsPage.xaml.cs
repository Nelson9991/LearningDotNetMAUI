namespace ControlsDemo;

public partial class InputControlsPage : ContentPage
{
	public InputControlsPage()
	{
		InitializeComponent();
	}

	private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		lblSlider.Text = ((int)e.NewValue).ToString();
	}

	private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		if (stepper != null)
		{
			lblStepper.Text = ((int)stepper.Value).ToString();
		}
	}
}