using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa un numero");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa otro numero");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1 / num2); }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
               
                Console.WriteLine(e.Message);
            }
            finally
            { }
            Console.ReadKey();
        }
            
        }
    }

