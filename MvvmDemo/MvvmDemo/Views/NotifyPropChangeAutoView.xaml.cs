namespace MvvmDemo.Views;

public partial class NotifyPropChangeAutoView : ContentPage
{
	public NotifyPropChangeAutoView()
	{
		InitializeComponent();
		BindingContext = new NotifyPropChangeAutoViewModel();
	}
}