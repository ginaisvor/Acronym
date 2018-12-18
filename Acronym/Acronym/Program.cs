using System;
using System.Text;
//Acronym
//Write a class with all the logic needed to convert a phrase to its acronym.
//Techies love their TLA(Three Letter Acronyms)!
//Help generate some jargon by writing a program that converts a long name like
//Portable Network Graphics to its acronym(PNG).

namespace Acronym
{
    class Program
    {
        public static void GetAcronym(string name)
        {
            StringBuilder sb = new StringBuilder();
            char[] lista = { ' ', '.' };
            string[] newString = name.Split(lista);
            for (int i = 0; i < newString.Length; i++)
            {
                sb.Append(newString[i][0]);
            }
            Console.WriteLine("The acronym from our string is: {0}", sb.ToString());
        }

        public static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            GetAcronym(text);

        }
    }
}
