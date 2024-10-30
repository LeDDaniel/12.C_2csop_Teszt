using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorMinMaxOOP
{
    public class VektorMinMax
    {
        private int[] vektor;
        private int min;
        private int minIndex;
        private int max;
        private int maxIndex;

        public VektorMinMax() { }

        public VektorMinMax(int[] vektor)
        {
            SetVektor(vektor);
        }

        public void SetVektor(int[] vektor)
        {
            this.vektor = vektor;
            SetMin();
            SetMax();
        }

        public void SetMin()
        {
            min = vektor.Min();
            minIndex = Array.IndexOf(vektor, min);
        }

        public void SetMax()
        {
            max = vektor.Max();
            maxIndex = Array.IndexOf(vektor, max);
        }

        public (int, int) GetMin() => (min, minIndex);
        public (int, int) GetMax() => (max, maxIndex);
        
        public (int, int)[] GetMinMax() => new[] { (min, minIndex), (max, maxIndex) };
    }

    class Program
    {
        static void Main(string[] args)
        {
            VektorMinMax vektorMinMax = new VektorMinMax(new[] { 3, 8, 1, 9, 2 });
            Console.WriteLine("A legkisebb elem és indexe: " + vektorMinMax.GetMin());
            Console.WriteLine("A legnagyobb elem és indexe: " + vektorMinMax.GetMax());
            Console.ReadKey();
        }
    }
}