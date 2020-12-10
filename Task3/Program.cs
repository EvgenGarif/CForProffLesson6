using System;
using System.Reflection;
using Task2;

namespace Task3
{
    //Создайте программу, в которой предоставьте пользователю доступ к сборке из Задания 2.
    //Реализуйте использование метода конвертации значения температуры из шкалы Цельсия в
    //шкалу Фаренгейта. Выполняя задание используйте только рефлексию.

    class Program
    {
        static void Main(string[] args)
        {

            Assembly assembly = null;
            assembly = Assembly.Load("Task2");

            Type type = assembly.GetType("Task2.TemperatureConverter");
            dynamic temperatureConverter = Activator.CreateInstance(type);

            var temperature = temperatureConverter.Convert(Unit.Fahrenheit, 100);
            Console.WriteLine(temperature);
        }
    }
}
