using System;
using System.IO;
using System.Reflection;

namespace zad5
{
    class Program
    {
        static void Main()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\QuickMafs\bin\Debug\netcoreapp3.1\QuickMafs.dll");
            string fullPath = Path.GetFullPath(path);
            var dll = Assembly.LoadFile(fullPath);
            var type = dll.GetType("QuickMafs.Class1");
            var instance = Activator.CreateInstance(type);
            MethodInfo[] methods = type.GetMethods();
            Console.WriteLine("Lista dostępnych metod:");
            for (int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine($"{i} {methods[i].Name}");
            }
            Console.WriteLine("Podaj numer metody którą chcesz wywołać");
            int methodIndex = Convert.ToInt32(Console.ReadLine());
            var methodToCall = methods[methodIndex];
            Console.WriteLine($"Wynik dla parametrów 4,2: {methodToCall.Invoke(instance, new object[] { 4, 2 })}");
        }
    }
}
