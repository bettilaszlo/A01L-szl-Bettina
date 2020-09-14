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
        static int[] adat = new int[1000];

        private static void Beolvasas()
        {
            StreamReader olv = new StreamReader("adatok.dat");

            while (!olv.EndOfStream)
            {
                string[] adatok = olv.ReadLine().Split(';');
                
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
            int max = 1000;
            for (int i = 0; i < adat.Length; i++)
            {
                if (adat[max] < adat[i])
                {
                    max = i;
                }
            }
            Console.WriteLine("A maximum: {0}", max);

        }
        private static void Egyediek()
        {
            Console.WriteLine("Megszámlálás tétele");
            int x = 0;
            for (int i = 0; i < adat.Length; i++)
            {
                if (adat[i] % 5 == 0 && adat[i] % 7 == 0)
                {
                    x++;
                }

            }
            
            Console.WriteLine("5 és 7 oszthatóak száma: {0}", x);

            StreamWriter ir = File.AppendText("egyediek.txt");
            ir.WriteLine("{0}");
            ir.Close();

        }
        static void Main(string[] args)
        {
            Beolvasas();
            Maximumertek();
            Egyediek();
        }

        

       
    }
}
