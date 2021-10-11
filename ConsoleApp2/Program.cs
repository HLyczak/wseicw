using System;

namespace HelloBatch2
{
    class Program
    {
        static void Main(string[] args)

        {
            if (args.Length == 0)
            {

                Console.WriteLine("Podaj imię ");
                string imie = Console.ReadLine();

                Console.WriteLine("Podaj nazwisko ");
                string nazwisko = Console.ReadLine();
                Console.WriteLine("Witaj {0} {1}", imie, nazwisko);


                Console.ReadKey();

            }
            else if (args.Length == 1)
            {

                string imie = args[0];

                Console.WriteLine("Podaj nazwisko ");
                string nazwisko = Console.ReadLine();

                Console.WriteLine("Podaj wiek ");             
                int wiek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Witaj {0} {1} {2}", imie, nazwisko, wiek);

                Console.ReadKey();

            }

            else if (args.Length == 2)
            {

                string imie = args[0];
                string nazwisko = args[1];

                Console.WriteLine("Podaj wiek ");
                int wiek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Witaj {0} {1} {2}", imie, nazwisko, wiek);
                
                Console.ReadKey();

            }

            else
            {

                string imie = args[0];
                string nazwisko = args[1];
                int wiek = Convert.ToInt32(args[2]);
                Console.WriteLine("Witaj {0} {1} masz {2} lat", imie, nazwisko, wiek);

            }


            Console.ReadKey();




        }
    }
}