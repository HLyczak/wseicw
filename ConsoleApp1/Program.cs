using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie");

            Console.WriteLine("Podaj imię: ");
            string imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj " + imie + " " + nazwisko );
            Console.WriteLine("Witaj {0}", imie);

            Console.WriteLine("Podaj wiek ");
            int wiek = Convert.ToInt32(Console.ReadLine());

            if (wiek <0)
            {
                Console.WriteLine("Błędne dane");

            }
            else if (wiek<65)
            {
                   
                Console.WriteLine("Do emerytury pozostało Ci: {0}", 65 - wiek);
            }
            else
            {
                Console.WriteLine("Jesteś emerytem.");

            }

            Console.ReadKey();



            


        
        }
    }
}
