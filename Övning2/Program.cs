using System;

namespace Execise2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Mata in 3 tal, addera dem och skriver ut summan.
            ////Skriv sedan ut dem i storleks ordning, störst först.
            //int nr1, nr2, nr3, sum;
            //Console.WriteLine("Mata in 3 heltal");
            //Console.Write("Mata in ditt första tal: ");
            //nr1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Mata in ditt andra tal: ");
            //nr2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Mata in ditt tredje tal: ");
            //nr3 = Convert.ToInt32(Console.ReadLine());
            //sum = nr1 + nr2 + nr3;
            //Console.WriteLine($"Summan av dessa tal blir {sum}");

            ///*Jag har löst uppgiften genom att ställa upp alla villkorer i en if-sats
            //för att sortera de 3 talen.*/
            //int highestNr = 0, nextHighestNr = 0, lowestNr = 0;
            //if (nr1 > nr2 && nr1 > nr3 && nr2 > nr3)
            //{
            //    highestNr = nr1;
            //    nextHighestNr = nr2;
            //    lowestNr = nr3;
            //}
            //else if (nr1 > nr2 && nr1 > nr3 && nr2 < nr3)
            //{
            //    highestNr = nr1;
            //    nextHighestNr = nr3;
            //    lowestNr = nr2;
            //}
            //else if (nr1 < nr2 && nr1 > nr3 && nr2 < nr3)
            //{
            //    highestNr = nr2;
            //    nextHighestNr = nr1;
            //    lowestNr = nr3;
            //}
            //else if (nr1 < nr2 &&  nr1 < nr3 && nr2 > nr3)
            //{
            //    highestNr = nr2;
            //    nextHighestNr = nr3;
            //    lowestNr = nr1;
            //}
            //else if (nr1 > nr2 && nr1 < nr3 && nr2 < nr3)
            //{
            //    highestNr = nr3;
            //    nextHighestNr = nr1;
            //    lowestNr = nr2;
            //}
            //else if (nr1 < nr2 && nr1 < nr3 && nr2 < nr3)
            //{
            //    highestNr = nr3;
            //    nextHighestNr = nr2;
            //    lowestNr = nr1;
            //}
            //Console.WriteLine($"{highestNr} {nextHighestNr} {lowestNr}");

            ////Mata in 2 tal sen byter vi värdet och skriver ut.
            //int nr1, nr2;
            //Console.WriteLine("Mata in två tal");
            //Console.Write("Mata in ditt första tal: ");
            //nr1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Mata in ditt andra tal: ");
            //nr2 = Convert.ToInt32(Console.ReadLine());

            //int newNr1 = nr2;
            //int newNr2 = nr1;
            //Console.WriteLine($"Vi byter plats med talen, tal1 blir {newNr1} och tal2 blir {newNr2}");


            //Användaren matar in sin ålder, skriver ut hur många år kvar till pension.
            int myAge, yearsToPension;
            char answer;
            Console.Write("Mata in din ålder: ");
            myAge = Convert.ToInt32(Console.ReadLine());
            yearsToPension = 65 - myAge;
            Console.WriteLine($"Du har {yearsToPension} år kvar till pension.");
            //Fråga om man vill spola fram tiden.
            Console.WriteLine("Vill du spola fram tiden till pension? j/n");
            answer = Convert.ToChar(Console.ReadLine());
            //Om "Ja" så sätter vi programmet i en loop tills man är 65.
            if (answer == 'j')
            {
                while (myAge < 65)
                {
                    myAge++;
                }
                Console.WriteLine($"Du har du spolat fram åldern, nu är du {myAge} år.");
                //Man får välja antingen stanna på denna ålder eller spola tillbaka.
                Console.WriteLine("Nu har du 2 val.");
                Console.WriteLine("[1] Jag vill stanna på denna ålder");
                Console.WriteLine("[2] Jag ångrar mig! Ta mig tillbaks!");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Njut av livet för nu är du pensionär.");
                }
                else if (choice == "2")
                {
                    myAge = myAge - yearsToPension;
                    Console.WriteLine($"Du har valt att hoppa tillbaka i tiden. Nu är du {myAge} år");
                }

            }
            else if (answer == 'n')
            {
                Console.WriteLine("Bra! Du vill inte fuska.");
            }





        }
    }
}
