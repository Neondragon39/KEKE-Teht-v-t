using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
        label:
            // Try block: The code which may raise exception at runtime
            try
            {
                int num1, num2;
                decimal result;

                Console.WriteLine("Jakolasku Ohjelma. Sinun pitää antaa jaettava ja jakaja");
                Console.WriteLine("Anna jaettava: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Anna jakaja: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                result = (decimal)num1 / (decimal)num2;
                Console.WriteLine("Jaettuna : " + result.ToString());
                Console.ReadLine();
            }

            //Multiple Catch block to handle exception

            catch (DivideByZeroException dex)
            {
                Console.WriteLine("Jakaja ei voi olla 0");
                Console.WriteLine("Lisätietoja virheestä: \n\n" + dex.ToString() + "\n\n");
                goto label;
            }

            catch (FormatException fex)
            {
                Console.WriteLine("Eipä ollut luku");
                Console.WriteLine("Lisätietoa virheestä: \n\n" + fex.ToString() + "\n\n");
                goto label;
            }

            //Parent Exception: Catch all type of exception

            catch (Exception ex)
            {
                Console.WriteLine("Muut Vaihtoehdot nostettu " + ex.ToString() + "\n\n");
                goto label;
            }

            //Finally block: it always executes

            finally
            {
                Console.WriteLine("Viimeinen blocki: Jatkoa varten. Pianakaa Enter Ja poistumista varten painakaa Ctrl + c");
                Console.ReadLine();
            }
        }
    }
}