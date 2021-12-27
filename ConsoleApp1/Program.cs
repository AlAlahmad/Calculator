using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( ; ; )
            {
                string equation = Console.ReadLine();
                if (equation.Contains("x"))
                {
                    Environment.Exit(0); 
                }
               else if (equation.Contains("+"))
                {

                    string[] values = equation.Split('+');
                    int result = int.Parse(values[0]) + int.Parse(values[1]);
                    Console.WriteLine(result);
                    Console.WriteLine(".............");
                }
                else if (equation.Contains("-"))
                {

                    string[] values = equation.Split('-');
                    int result = int.Parse(values[0]) - int.Parse(values[1]);
                    Console.WriteLine(result);
                    Console.WriteLine(".............");
                }
                else if (equation.Contains("*"))
                {

                    string[] values = equation.Split('*');
                    int result = int.Parse(values[0]) * int.Parse(values[1]);
                    Console.WriteLine(result);
                    Console.WriteLine(".............");
                }
                else if (equation.Contains("/"))
                {
                    string[] values = equation.Split('/');
                    if ((values[1]) == null)
                    {
                        throw new DivideByZeroException("Can Not Divide By Zero");
                    }
                    {
                    
                      int result = int.Parse(values[0]) / int.Parse(values[1]);
                      Console.WriteLine(result);
                      Console.WriteLine(".............");
                    }
                }
            }

        }
    }
}
