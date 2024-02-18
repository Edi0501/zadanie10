using System;
namespace zadanie10New
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                Console.WriteLine("Sprawdzmy z podanych przez Ciebie długości mozna stworzyć trojkąt?");
                Console.WriteLine("Podaj pierwszą długość:");
                
                int a = 10;
                int b = 5;
                int c = 3;

                Int32.TryParse(Console.ReadLine(), out a);
                Console.WriteLine("Podaj drugą długość");
                Int32.TryParse(Console.ReadLine(), out b);
                Console.WriteLine("Podaj trzecią trzecią");
                Int32.TryParse(Console.ReadLine(), out c);
                
                {
                    if (c<(a+b))
                    {
                        Console.WriteLine("Można zbudować trójkąt:");
                    }
                    else if (c>=(a+b))
                    {
                        Console.WriteLine("Nie można zbudować trójkąt:");
                    }
                   

                }


            }
        }
    }
}