using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string text;
   
            Console.WriteLine("1. Reverse a string");
            Console.WriteLine("2. Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the text to be reversed");
                    text = Console.ReadLine();
                    Console.WriteLine(Reverse(text));
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
        }

        static string Reverse(string text)
        {
            string reversed = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            return reversed;
        }
    }

}

    

