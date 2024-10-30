using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulátorOOP
{
    public class Calc
    {
      private double szam1;
        private double szam2;
        private char muvelet;
        private double eredmeny;

        public Calc() {}

        public Calc(double szam1, double szam2, char muvelet)
        {
            this.szam1 = szam1;
            this.szam2 = szam2;
            this.muvelet = muvelet;
        }

        public void SetSzám1(double szam) => szam1 = szam;
        public void SetSzám2(double szam) => szam2 = szam;
        public void SetMűveletJel(char jel) => muvelet = jel;

        public void SetEredmény()
        {
            switch (muvelet)
            {
                case '+': eredmeny = szam1 + szam2; break;
                case '-': eredmeny = szam1 - szam2; break;
                case '*': eredmeny = szam1 * szam2; break;
                case '/': eredmeny = szam2 != 0 ? szam1 / szam2 : 0; break;
                default: throw new InvalidOperationException("Ismeretlen művelet");
            }
        }

        public double GetEredmény() => eredmeny;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc(10, 5, '+');
            calc.SetEredmény();
            Console.WriteLine("Az eredmény: " + calc.GetEredmény());
            Console.ReadKey();
        }

    }
}
