using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2021aoc7
{
    class Program
    {
        static int tav(int x, int y) => Math.Abs(x - y);
        static int tav2(int x, int y) => (tav(x, y) * (tav(x, y) + 1) / 2);
        static void Main(string[] args)
        {
            IEnumerable<int> t = File.ReadAllText("teszt.txt").Split(',').Select(int.Parse);
            Console.WriteLine(t.Select((e, i) => i).Min(i => t.Select(x=>tav(x,i)).Sum()));
            Console.WriteLine(t.Select((e, i) => i).Min(i => t.Select(x=>tav2(x,i)).Sum()));
        }
    }
}
