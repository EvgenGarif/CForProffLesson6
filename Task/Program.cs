using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task
{

    //Создайте программу-рефлектор, которая позволит получить информацию о сборке и входящих в ее состав типах.


    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("Task2");
                Console.WriteLine("Сборка успешно загружена");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(assembly.FullName);

            Type[] types = assembly.GetTypes();

            foreach(Type type in types)
            {
                Console.WriteLine(type);
            }
        }
    }
}
