using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace Calculator
{

    class program
    {

    static void Main(string[] args)
        {//hello
            Console.WriteLine("1. Addition\n2. Substraction\n3. Multiplication\n4. Division");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter 1st number");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2st number");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int result = num1 + num2;
                    Console.WriteLine("The result is : " + result);

                    break;
                case 2:
                    Console.WriteLine("Enter 1st number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2st number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine("The result is : " + result);
                    break;
                case 3:
                    Console.WriteLine("Enter 1st number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2st number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine("The result is : " + result);
                    break;
                case 4:
                    Console.WriteLine("Enter 1st number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2st number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = num1 / num2;
                    Console.WriteLine("The result is : " + result);
                    break;

            }

        Console.ReadKey();
        }
    }
}