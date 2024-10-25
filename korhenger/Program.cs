using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhenger
{
    class Program
    {
        static void Main(string[] args)
        {
            kor k1 = new kor();
            k1.SetSugar(15);
            k1.SetTerulet();
            k1.SetKerulet();
            Console.WriteLine($"A {k1.GetSugar()} sugarú kör kerülete:{k1.GetKerulet()},területe: {k1.GetTerulet()}.");
            Console.ReadKey();
        }
    }
}
