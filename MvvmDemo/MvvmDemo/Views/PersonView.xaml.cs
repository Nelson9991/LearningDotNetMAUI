namespace MvvmDemo.Views;

public partial class PersonView : ContentPage
{
  public PersonView()
  {
    InitializeComponent();
    BindingContext = new PersonViewModel();
  }
}