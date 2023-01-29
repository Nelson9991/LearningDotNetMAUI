using MvvmDemo.Models;

namespace MvvmDemo.ViewModels;
public sealed class PersonViewModel
{
  public Person Person { get; set; }

  public PersonViewModel()
  {
    Person = new Person
    {
      Name = "Test",
      Age = 20,
      Married = true,
      BirthDate = DateTime.Now,
      Weight = 20,
      LunchTime = TimeSpan.FromHours(1),
    };
  }
}
