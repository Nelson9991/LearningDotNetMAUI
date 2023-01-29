namespace MvvmDemo.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
		BindingContext = new PeopleViewModel();
	}
}