íusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzámTesztOOP
{
    public class SzámTeszt
    {
        private int szam1;
        private int szam2;
        private int eredmeny;

        public SzámTeszt() { }

        public SzámTeszt(int szam1, int szam2)
        {
            this.szam1 = szam1;
            this.szam2 = szam2;
        }

        public void SetSzám1(int szam) => szam1 = szam;
        public void SetSzám2(int szam) => szam2 = szam;

        public void SetEredmény()
        {
            if (szam1 == szam2) eredmeny = 0;
            else if (szam1 > szam2) eredmeny = 1;
            else eredmeny = 2;
        }

        public int GetEredmény() => eredmeny;
    }

    class Program
    {
        static void Main(string[] args)
        {
            SzámTeszt szamTeszt = new SzámTeszt(7, 5);
            szamTeszt.SetEredmény();
            Console.WriteLine("Az eredmény: " + szamTeszt.GetEredmény());
            Console.ReadKey();
        }
    }
}
