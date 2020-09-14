using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A01LászlóBettina
{
    class Program
    {
        static StreamReader olv = new StreamReader("adatok.dat");
        private static void Beolvasas()
        {
            string[] sor ;

            while (!olv.EndOfStream)
            {
                string[] adatok = olv.ReadLine().Split(';');
                int[] adat = new int[1000];
                Console.WriteLine(adatok);


                for (int i = 0; i < adat.Length; i++)
                {
                    adat[i] = int.Parse(adatok[i]);
                }
            }
                olv.Close();
        }
        private static void Maximumertek()
        {
            int max = 0;
            for (int i = 0; i < olv.Length; i++)
            {
                if (olv[max] < olv[i])
                {
                    max = i;
                }
            }
            Console.WriteLine("Maximum szám: {0} ami a {1}, indexű helyen van", olv[max], max);

        }
        private static void Egyediek()
        {
            
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Maximumertek();
            Egyediek();
        }

        

       
    }
}
