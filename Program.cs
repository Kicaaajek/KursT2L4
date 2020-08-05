using System;

namespace Lekcja4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            zadanie1();
            zadanie2();
            zadanie3();
            zadanie4();
            zadanie5();
        }

        public static void zadanie1()
        {

            Console.WriteLine("Program przechowuje dane pracownika");
            string imie;
            string nazwisko;
            int wiek;
            char plec;
            char pesel;
            char nrPracownika;
        }

        public static void zadanie2()
        {
            /* char a='f';
             char b='d';
             char c='r';
             Console.WriteLine ("Zadeklarowane litery to: "+ c + b + a) ;*/

            char a, b, c;
            Console.WriteLine("Podaj literę: ");
            a = char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj literę: ");
            b = char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj literę: ");
            c = char.Parse(Console.ReadLine());
            Console.WriteLine("Zadeklarowane litery to: " + c + b + a);
        }

        public static void zadanie3()
        {
            Console.WriteLine("Program oblicza długość przekątnej prostokąta");
            double a, b, d;
            Console.WriteLine("Podaj długość prostokąta: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokość prostokąta: ");
            b = double.Parse(Console.ReadLine());
            d = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Przekątna prostokąta ma długość: " + d);
        }

        public static void zadanie4()
        {
            int a;
            string name;
            double b;
            a = 10;
            name = "Szkoła Dotneta";
            b = 12.5;
        }

        public static void zadanie5()
        {
            Console.WriteLine("Proszę podaj swoje dane:");
            string imie;
            Console.WriteLine("Imię: ");
            imie = Console.ReadLine();
            string nazwisko;
            Console.WriteLine("Nazwisko: ");
            nazwisko = Console.ReadLine();
            int wiek;
            Console.WriteLine("Wiek: ");
            wiek = int.Parse(Console.ReadLine());
            string nrtel;
            Console.WriteLine("Numer telefonu: ");
            nrtel = (Console.ReadLine());
            double waga;
            Console.WriteLine("Wagę: ");
            waga = double.Parse(Console.ReadLine());
        }

    }
}
