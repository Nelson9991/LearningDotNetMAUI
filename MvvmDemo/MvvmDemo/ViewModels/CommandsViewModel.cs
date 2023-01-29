using System.Windows.Input;

namespace MvvmDemo.ViewModels;
public sealed class CommandsViewModel
{
  public string SearchTerm { get; set; }

  public ICommand ClickCommand { get; }
  public ICommand SearchCommand { get; }

  public CommandsViewModel()
  {
    ClickCommand = new Command(Alert);
    SearchCommand = new Command<string>(OnSearch);
  }

  private void Alert()
  {
    App.Current.MainPage.DisplayAlert("Title", "Hola!", "OK");
  }

  private void OnSearch(string searchTerm)
  {
    var data = searchTerm;
  }
}
