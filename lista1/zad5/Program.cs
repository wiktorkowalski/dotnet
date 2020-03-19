using System;
using System.IO;
using System.Reflection;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            // C:\Users\Mikolaj\Documents\dotnet\lista1\zad5\bin\Debug\netcoreapp3.1\lista1\ClassLibrary1\bin\Debug\ClassLibrary1.dll'    
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\QuickMafs\bin\Debug\netcoreapp3.1\QuickMafs.dll");
            string fullPath = Path.GetFullPath(path);
            Console.WriteLine(fullPath);
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
            // w sumie to wszystkie te metody i tak mają tylko po 2 parametry int XD
            // TODO: brać jakoś dynamicznie parametry od użytkownika
            //ParameterInfo[] parameters = methodToCall.GetParameters();
            //Console.WriteLine("Parametry wybranej metody");
            //foreach (var parameter in parameters)
            //{
            //    Console.WriteLine($"{parameter.ParameterType} {parameter.Name}");
            //}
            Console.WriteLine($"Wynik dla parametrów 4,2: {methodToCall.Invoke(instance, new object[] { 4, 2 })}");
        }
    }
}
