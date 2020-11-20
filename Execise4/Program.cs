using System;
using System.Collections.Generic;

namespace Execise4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Skapa en lista med 10 elements
            //List<string> favoritBrand = new List<string>()
            //{"BMW", "Honda", "Audi", "Saab", "VW", "Alfa Romeo", "Mercedes", "Volvo", "Toyota", "Renault"};
            //int i = 0;
            ////Skriv ut alla elements i listan mha do-while, while och for
            //do
            //{
            //    Console.Write(" " + favoritBrand[i]);
            //    i++;
            //} while (i < favoritBrand.Count);

            //while (i < favoritBrand.Count)
            //{
            //    Console.Write(" " + favoritBrand[i]);
            //    i++;
            //}

            //for (i = 0; i < favoritBrand.Count; i++)
            //{
            //    Console.Write(" " + favoritBrand[i]);
            //}

            //Skapa en array av char som innehåller mitt personnummer
            char[] personNumber = {'1','9','6','6','0','5','2','8','3','4','3','8'};
            for(int i = 8; i < personNumber.Length; i++)
            {
                Random newNumb = new Random();
                int slump = newNumb.Next(0, 9);
                Console.WriteLine(slump);
                //personNumber[i] = Convert.ToChar(slump);
                //Console.WriteLine(personNumber[i]);
            }


        }
    }
}
