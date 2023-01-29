namespace MvvmDemo.Converters;
public sealed class BoolConverter : IValueConverter
{
  // Este metodo Convert es para convertir el valor desde el Modelo hacia la UI
  public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
  {
    var answer = value.ToString();
    if (answer == "YES")
    {
      return true;
    }

    return false;
  }

  // Este metodo ConvertBack es para convertir el valor desde la UI hacia el Modelo
  public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
  {
    var booleanVal = (bool)value;
    if (booleanVal)
    {
      return "YES";
    }
    return "NO";
  }
}
