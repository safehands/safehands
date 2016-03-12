using CalculatorNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCal
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            float y, z = 0, w = 0;
            try
            {
                Console.WriteLine("Enter two numbers");

                if (float.TryParse(Console.ReadLine(), out y))
                {
                    if (float.TryParse(Console.ReadLine(), out z))
                    {
                        Console.WriteLine("Enter operation");
                        Console.WriteLine("add=1\nsub=2\nmul=3\ndiv=4");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Number ");
                }
                x = Int32.Parse(Console.ReadLine());

                Calculator myObj = new Calculator();
                switch (x)
                {
                    case 1:
                        w = myObj.add(y,z);
                            break;

                    case 2:
                        w = myObj.sub(y, z);
                        break;

                    case 3:
                        w = myObj.mul(y, z);
                        break;

                    case 4:
                        w = myObj.div(y, z);
                        break;
                    default:
                        Console.WriteLine("INVALID Operation");
                        break;

                }
                Console.WriteLine("result is " + w);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
            }

            Console.ReadLine();

        }
    }
}
