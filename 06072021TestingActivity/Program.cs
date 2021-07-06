using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06072021TestingActivity
{
    
    public class Mathematics
    {
        double result;
        public double Add(double a, double b)
        {
            result = a + b;

            return result;
        }
        public double Subtract(double a, double b)
        {
            result = a - b;

            return result;
        }
        public double Multiply(double a, double b)
        {
            result = a * b;

            return result;
        }
        public double Divide(double a, double b)
        {
            result = a / b;

            return result;
        }

        public double Test(double a)
        {
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();

            Console.WriteLine("Hello!!! Welcome to the option calculator");
            Console.WriteLine("Choose the option: 1(Add), 2(Multiply), 3(Subtract), 4(Test)");

            int Opt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type your first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type your second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            switch (Opt)
            {
                case 1:
                    Console.WriteLine("The result is {0}", math.Add(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("The result is {0}", math.Multiply(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("The result is {0}",math.Subtract(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("The result is {0}",math.Test(num2));
                    break;
            }
            Console.ReadKey();
        }
    }
}
