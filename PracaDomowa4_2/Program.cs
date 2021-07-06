using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj proszę liczbę: ");
                
                var fizzBuzz = new GetString();

                while (true)
                {
                    int number = GetNumber();

                    Console.WriteLine(fizzBuzz.FizzBuzz(number));
                }
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }



        }
        private static int GetNumber()
        {
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                throw new Exception("Podana wartość jest nieprawidłowa!");
            }
            return number;
        }

        
    }
}
