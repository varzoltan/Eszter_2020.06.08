using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._06._08
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.feladat: Kérj be egy negatív egész számot a felhasználótól, 
            //és írd ki az ettől nagyobb negatív számokat!
            Console.Write("Kérem adjon egy negatív egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            /*for (int i = szam;i<0;i++)
            {
                Console.Write($"{i} ");
            }*/

            //Előltesztelős ciklussal mododva!
            while (szam<0)
            {
                Console.Write($"{szam} ");
                szam++;
            }
            Console.WriteLine();
            //8.feladat: Hozz létre egy 10 elemű tömböt, amit tölts fel a [0;20] intervallumból 
            //véletlen számokkal! Írd ki a tömb páros egyjegyű számait!
            int[] tomb = new int[10];
            Random veletelen = new Random();
            for (int i = 0;i<tomb.Length;i++)
            {
                tomb[i] = veletelen.Next(21);
            }

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0 && tomb[i] != 0 && tomb[i] < 10)
                {
                    Console.Write($"{tomb[i]} ");
                }              
            }
            Console.ReadKey();
        }
    }
}
