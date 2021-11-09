using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FugaMemoria
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Inicando carga!");

            List<byte[]> datos = new List<byte[]>();
            Random rnd = new Random();
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();

            for (int i = 0; i < 10000; i++)
            {
                Stopwatch timeMeasure2 = new Stopwatch();
                timeMeasure2.Start();
                byte[] buffer = new byte[10000000];
                rnd.NextBytes(buffer);
                timeMeasure2.Stop();
                Console.WriteLine($"buffer: {i} - {timeMeasure2.Elapsed.TotalMilliseconds}");
                datos.Add(buffer);
            }
            timeMeasure.Stop();
            Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");

            return 0;
        }
    }
}
