using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace zadanie5
{
    class Program
    {

        private static ConcurrentBag<double> minValuesFromThreads = new ConcurrentBag<double>();
        private static ConcurrentBag<double> maxValuesFromThreads = new ConcurrentBag<double>();

        private static readonly int LENGTH = 500000000;
        private static readonly int THREADS = 8;
        private static readonly int CHUNK_SIZE = LENGTH / THREADS;

        static void Main(string[] args)
        {
            double[] array = new double[LENGTH];
            Thread[] threadsArray = new Thread[THREADS];
            var random = new Random();
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Generowanie tablicy...");
            stopWatch.Start();
            for (int i = 0; i < LENGTH; i++)
            {
                array[i] = random.NextDouble() * random.Next(int.MinValue, int.MaxValue);
            }
            stopWatch.Stop();
            Console.WriteLine($"Tablica wygenerowana w: {stopWatch.Elapsed}");

            Console.WriteLine("Szukanie wartosci najwiekszej i najmniejszej za pomoca 1 wątku");
            stopWatch.Reset();

            double max = 0;
            double min = 0;

            stopWatch.Start();
            for (int i = 0; i < LENGTH; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            stopWatch.Stop();
            Console.WriteLine($"Najmniejsza: {min}, Największa: {max}. Czas: {stopWatch.Elapsed}");
            stopWatch.Reset();
            Console.WriteLine($"Wyszukiwanie mina i maxa za pomocą {THREADS} wątków:");

            max = 0; min = 0;

            stopWatch.Start();

            for (var i = 0; i < THREADS; i++)
            {
                int localNum = i;
                threadsArray[i] = new Thread(() => findMinMax(array.Skip(localNum * CHUNK_SIZE).Take(CHUNK_SIZE).ToArray()));
            }

            for (var i = 0; i < THREADS; i++)
            {
                threadsArray[i].Start();
            }

            for (var i = 0; i < THREADS; i++)
            {
                threadsArray[i].Join();
            }


            min = minValuesFromThreads.Min();
            max = maxValuesFromThreads.Max();

            stopWatch.Stop();
            Console.WriteLine($"Najmniejsza: {min}, Największa: {max}. Czas: {stopWatch.Elapsed}");
        }
        private static void findMinMax(double[] chunk)
        {
            double min = 0;
            double max = 0;
            foreach (var element in chunk)
            {
                if (element > max)
                {
                    max = element;
                }
                if (element < min)
                {
                    min = element;
                }
            }
            minValuesFromThreads.Add(min);
            maxValuesFromThreads.Add(max);
        }
    }
}