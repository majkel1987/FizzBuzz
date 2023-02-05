using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_v2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program sprawdza czy liczba jest podzielna przez 3 lub przez 5. " +
               "\nJeżeli liczba jest podzielna przez 3, dostaniesz powiadomienie Fizz." +
               "\nJeżeli liczba jest podzielna przez 5, dostaniesz powiadomienie Buzz." +
               "\nJeżeli liczba jest podzielna przez 3 i 5, dostaniesz powiadomienie FizzBuzz." +
               "\nJeżeli liczba nie jest podzielna przez 3 i 5 zostanie ona zwrócona.");
            
           var wynik = new FizzBuzz();
            
            while (true)
            {
                Console.WriteLine("Podaj liczbę:");
                var liczba = GetNumber();
                Console.WriteLine(wynik.CheckDiv(liczba));
            }

            Console.ReadKey();
        }
        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int num))

                {
                    Console.WriteLine("Wprowadziłeś błędne dane. Sprbuj ponownie.");
                    continue;
                }
                return num;
            }
        }
    }
    class FizzBuzz
    {
        public string CheckDiv(int number)
        {
                if (number % 15 == 0)
                    return "FizzBuzz";
                
                if (number % 3 == 0)
                    return "Fizz";
            
                if (number % 5 == 0)
                    return "Buzz";

                return number.ToString();
        }
    }
}
