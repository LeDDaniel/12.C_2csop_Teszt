using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KőPapírOllóOOP
{
    using System;

    namespace KőPapírOllóOOP
    {
        public class Kpo
        {
            private string tip1;
            private string tip2;
            private string eredmeny;

            public Kpo() { }

            public Kpo(string tip1, string tip2)
            {
                this.tip1 = tip1;
                this.tip2 = tip2;
            }

            public void SetTip1(string tip) => tip1 = tip;
            public void SetTip2(string tip) => tip2 = tip;

            public void SetEredmény()
            {
                if (tip1 == tip2) eredmeny = "Döntetlen";
                else if ((tip1 == "Kő" && tip2 == "Olló") || (tip1 == "Papír" && tip2 == "Kő") || (tip1 == "Olló" && tip2 == "Papír"))
                    eredmeny = "Első játékos nyert";
                else
                    eredmeny = "Második játékos nyert";
            }

            public string GetEredmény() => eredmeny;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Kpo kpo = new Kpo("Kő", "Olló");
                kpo.SetEredmény();
                Console.WriteLine("A játék eredménye: " + kpo.GetEredmény());
                Console.ReadKey();
            }
        }
    }
}
