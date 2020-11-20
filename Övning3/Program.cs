using System.Collections.Generic;
using System;

namespace Execise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Skapa en array med 3 element 5,7,2
            ////Skriv ut varje element i arrayen
            //int[] myArray = new int[3] { 5, 7, 2 };
            //int i = 0;
            //while(i < myArray.Length)
            //{
            //    Console.Write(myArray[i] + " ");
            //    i++;
            //}


            ////Skapa en lista av stränger, be användare mat in namn.
            ////Om det är en tom sträng, så avslutar programmet och skrivar ut listan.
            //List<string> myList = new List<string>();
            //string name = String.Empty;
            //bool keepGoing = false;
            //do
            //{
            //    Console.Write("Mata in ett namn: ");
            //    name = Console.ReadLine();
            //    if (name != String.Empty)
            //    {
            //        keepGoing = true;
            //        myList.Add(name);

            //    }
            //    else
            //    {
            //        keepGoing = false;
            //        for (int i = 0; i < myList.Count; i++)
            //        {
            //            Console.WriteLine(myList[i]);
            //        }
            //    }
            //}
            //while (keepGoing == true);


            ////Mata in ett heltal och loppa och spara talets gångentabell(1-10) i en array.
            ////Skriv ut arrayen.
            //int userNumber;
            //int[] numbers = new int[10];

            //Console.Write("Mata in ett heltal: ");
            //userNumber = Convert.ToInt32(Console.ReadLine());
            //for (int index = 0; index < 10; index++)
            //{
            //    numbers[index] = (index + 1) * userNumber;
            //}
            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    Console.Write(numbers[index] + " ");
            //}


            ////Användaren matar in ett namn, spara namnet baklänges genom en lopp i en lista.
            ////Första bokstaven i det nya namnet ska vara storbokstav och de andra är små.
            ////Skriv ut det nya namnet.
            //string userName;
            //List<char> nameList = new List<char>();
            //int i = 0;

            //Console.Write("Mata in ditt namn: ");
            //userName = Console.ReadLine();
            //char[] nameArray = userName.ToCharArray();

            //for (i = 0; i < nameArray.Length; i++)
            //{
            //    nameList.Add(nameArray[i]);
            //}
            //nameList.Reverse();
            //Console.Write("Ditt nya namn baklänges blir " + Char.ToUpper(nameList[0]));
            //for (i = 1; i < nameList.Count; i++)
            //{
            //    Console.Write(Char.ToLower(nameList[i]));
            //}


            //Skapa ett program där användaren matar in en sträng.
            //Loopa över varje char i strängen, Skriv ut konsonanten följt av ett o
            //och sedan konsonanten igen. Annars skriv bara ut tecknet.
            string userStr;
            char[] vocals = new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'y', 'Y', 'å', 'Å', 'ä', 'Ä', 'ö', 'Ö'};

            Console.Write("Mata in en kort mening: ");
            userStr = Console.ReadLine();
            char[] strArray = userStr.ToCharArray();
            foreach(char ch in strArray)
            {

            }
        }
    }
}
