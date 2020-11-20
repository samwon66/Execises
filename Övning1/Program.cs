using System;
using System.Reflection.Metadata;

namespace Execise1

{
    class Program

    {
        static void Main(string[] args)
        {
            //jag deklarerar och tilldelar olika heltal och string variblar först.
            string firstOne = "Hej", secondOne = "hur ", thirdOne = "är ", fourthOne = "läget", fifthOne = "!";
            int myFirstInt = 12, mySecondInt = 35, myThirdInt = 5, myFourthInt = 60, myFifthInt = 186;
            //skriver ut första string-variabel och första heltalsvaribel osv.
            Console.WriteLine("hello sammy!");
            Console.WriteLine(firstOne + myFirstInt);
            Console.WriteLine(secondOne + mySecondInt);
            Console.WriteLine(thirdOne + myThirdInt);
            Console.WriteLine(fourthOne + myFourthInt);
            Console.WriteLine(fifthOne + myFifthInt);

            string date = "2020-11-11";
            Console.WriteLine($"Välkommen till dagens möte, {date}");
            Console.Write("Här skrivs det ut på samma rad");
            Console.WriteLine("Och här skrivs det ut på en ny rad");
            Console.WriteLine("Ännu en ny rad");

            //char aNewChar = 's';

            string name = "Sammy Wong";
            int age = 54;
            int length = 176;
            string town = "Åmål";
            string hobby = "fotografering";
            string superPower = "healing";

            Console.WriteLine($"Mitt namn är {name}, jag är {age} år gammal, {length}cm lång och bor i {town}.");
            Console.WriteLine($"Min hobby är {hobby} och jag har {superPower} som min superkraft.");


        }

    }

}
