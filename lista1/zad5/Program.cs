using System;
using System.Reflection;

namespace zad5
{
    // https://stackoverflow.com/questions/18362368/loading-dlls-at-runtime-in-c-sharp
    // todo
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Wiktor\source\repos\lista1\QuickMafs\bin\Debug\netcoreapp3.1\";
            string dllname = Console.ReadLine();
            var DLL = Assembly.LoadFile(path + dllname);

            var theType = DLL.GetType("DLL.Class1");
            var c = Activator.CreateInstance(theType);
            var method = theType.GetMethod("Output");
            method.Invoke(c, new object[] { @"Hello" });

            Console.ReadLine();
        }
    }
}
