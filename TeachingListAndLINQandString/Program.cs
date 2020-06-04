using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml.Schema;

namespace TeachingListAndLINQandString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * List<>
            * LINQ
            * string metoder;
            * Split
            * Trim
            * Vise alle
            */
           //int[] list = new int[10]; ---> vanelig Array, stopper på ett viss antall, i dette tilfelle 10
           DemoString();
           //DemoList1();
           //DemoList2();
           //DemoLINQ();
        }

        private static void DemoString()
        {
            var text = "xxxxTerjexxxxxxxxxx;xxxxxxxxxxx59x;xxxx63xxxxxx;xxxxjaxx;xxxxxxxxxxxxxxxxxxxxxgrønn";
            //var text = "       Terje     ;    59 ;   63      ;    ja      ;      grønn";
            var parts = text.Split(';'); // setter text under hverandre mellom hver ; og fjerner ;
            foreach (var part in parts)
            {
                //Console.WriteLine(part.Trim()); //trim tar bort mellomrom før og etter 
                Console.WriteLine(part.Trim('x')); //trim tar bort x'ene før og etter 
            }
        }

        private static void DemoList1()
        {
            var list = new List<int>(); // den fortsetter å legge til random tall
            var random = new Random();
            var count = 0;
            while (true)
            {
                var number = random.Next(0, 100);
                // list[count] = number; ---> vanlig Array
                list.Add(number);
                count++;
                if (random.Next(0, 10) == 5) break;
                //Console.WriteLine(number);
                //Thread.Sleep(1000);
            }

            for (var i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " ");
            }

            Console.WriteLine();


            list[0] = 33; // setter vi det første tallet til å bli 33 i dette tilfelle
            foreach (int numberIndex in list)
            {
                Console.WriteLine("tallet er " + numberIndex + " ");
            }

            Console.WriteLine();
        }
        private static void DemoList2()
        {
            var list = GetPoints();

            foreach (var point in list)
            {
                Console.WriteLine("tallet er " + point + " ");
            }

            Console.WriteLine();
        }

        private static List<Point> GetPoints()
        {
            var list = new List<Point>();
            var random = new Random();
            var count = 0;
            while (true)
            {
                var point = new Point(random.Next(0, 10), random.Next(0, 10));
                list.Add(point);
                count++;
                if (random.Next(0, 50) == 5) break;
            }

            return list;
        }

        private static void DemoLINQ()
        {
            var list = GetPoints();
            //var point= list.FirstOrDefault(p => p.X == p.Y);
            //Console.WriteLine(point == null ? "null" : point.ToString());

            var points = list.Where(p => p.X == p.Y);
            foreach (var p in points)
            {
                Console.WriteLine(p);   
            }
            if(list.Any(p => p.X == p.Y)) { }
            if(list.All(p => p.X == p.Y)) { }
        }
    }
}
