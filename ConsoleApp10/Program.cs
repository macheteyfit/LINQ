using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "Hello", "World", "One", "Three", "!" };

            var strsLenght = strs.Select(s => s.Length);

            foreach (int l in strsLenght)
            {
                Console.WriteLine(l);
               
            }
            Console.WriteLine(strs.Length.GetType());
            var strsLenghtArr = strsLenght.ToArray();
            Console.WriteLine(strsLenghtArr.GetType());

            var person = new { Name = "John", Age = 25 };
            Console.WriteLine(person.GetType());
            
            var strsLenghtAndText = 
                strs.Select(s => new {Text = s, Lenght = s.Length});

            foreach(var o in strsLenghtAndText)
            {
                Console.WriteLine(o.Text + " " + o.Lenght);
            }

            var strsOrdered = strs.OrderBy(s => s.Length);
            foreach (string str in strsOrdered)
            {
                Console.WriteLine(str);
            }

            var strsLenghtAndTextOrdered = strs.Where(s => s.Length > 1)
                .Select(s => new { Text = s, Lenght = s.Length })
                .OrderBy(s => s.Lenght);
            foreach (var o in strsLenghtAndTextOrdered)
            {
                Console.WriteLine(o.Text + " " + o.Lenght);
            }

            int MaxLenght = strs.Max(s => s.Length);
            Console.WriteLine($"maxLenght = {MaxLenght}");
            int[] numbers = { 5, 7, 6, 8, 10, 2 };
            int maxInt = numbers.Max(n => n);
            int minInt = numbers.Min(n => n);
            int sumInt = numbers.Where(n => n%2 == 0).Sum(n => n);
            double avgInt = numbers.Average(n => n);

            Console.ReadKey();
        }
    }
}
