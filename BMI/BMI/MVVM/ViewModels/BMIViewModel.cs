using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMI.MVVM.Models;
using PropertyChanged;

namespace BMI.MVVM.ViewModels;

public class BMIViewModel
{
  public Bmi Bmi { get; set; }

	public BMIViewModel()
	{
		Bmi = new Bmi
		{
			Height = 180,
			Weight = 73
		};
	}
}
