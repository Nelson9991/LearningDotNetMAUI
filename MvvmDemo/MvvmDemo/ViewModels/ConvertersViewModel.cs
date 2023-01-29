using MvvmDemo.Models;

namespace MvvmDemo.ViewModels;
public class ConvertersViewModel
{
	public Data Data { get; set; }

	public ConvertersViewModel()
	{
		Data = new Data { Married = "YES" };
	}
}
