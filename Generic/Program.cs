using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome To Generic Problems");
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Choose Options: \n 1.find maximum integer\n 2. find max float\n 3.exit \n");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter Three Number to find:");
                            int first = Convert.ToInt32(Console.ReadLine());
                            int second = Convert.ToInt32(Console.ReadLine());
                            int third = Convert.ToInt32(Console.ReadLine());
                            int max = LargestInteger.MaxNumber(first, second, third);
                            Console.WriteLine("Max Number is: " + max);
                            break;
                        case 2:
                            Console.WriteLine("Enter Three Float Numbers to find");
                            double firstNumb = Convert.ToDouble(Console.ReadLine());
                            double secondNumb = Convert.ToDouble(Console.ReadLine());
                            double thirdNumb = Convert.ToDouble(Console.ReadLine());
                            double result = LargestInteger.FindMax(firstNumb, secondNumb, thirdNumb);
                            Console.WriteLine("Max Number is: " + result);
                            break;
                        case 3:
                            flag = false;
                            break;
                    }
                }

            }
        }
    }
}
