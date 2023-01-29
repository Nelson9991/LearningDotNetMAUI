namespace MvvmDemo.Views;

public partial class ConvertersView : ContentPage
{
	public ConvertersView()
	{
		InitializeComponent();
		BindingContext = new ConvertersViewModel();
	}
}