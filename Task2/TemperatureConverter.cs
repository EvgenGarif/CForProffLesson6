
namespace Task2
{

    //Создайте свою пользовательскую сборку, сборка будет использоваться для работы с конвертером температуры.


    public enum Unit
    {
        Celsius,
        Fahrenheit
    }
    public class TemperatureConverter
    {
        public double Convert(Unit unit, double value)
        {
            var celsius = (value - 32) / 1.8;
            var fahrenheit = value * 1.8 + 32;
            return unit == 0 ? celsius : fahrenheit;
        }

    }
}
