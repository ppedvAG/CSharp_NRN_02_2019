using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> echteListe;
            MeineListe liste = new MeineListe();

            liste.Add(2);
            liste.Add(5);
            liste.Add(10);

            int[] asdas = new int[] { 23, 232, 23 };
            foreach (var item in asdas)
            {

            }

            foreach (int item in liste)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
