using System;

namespace ONP
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCalculation = true;
            while (newCalculation)
            {
                //Every char in equation should be separated by SPACE 
                Console.WriteLine("Enter RPN equation: ");
                try
                {
                    string equation = Console.ReadLine();
                    ONPLogic onpLogic = new ONPLogic(equation);
                    Console.WriteLine(onpLogic.Calculator());

                }
                catch (Exception)
                {
                    Console.WriteLine("Only numbers and + - * / ^ char.");
                }
                Console.WriteLine("Do you want to enter a new calculation?(y/n)");
                if (Console.ReadLine() != "y")
                    newCalculation = false;
            }
            Console.ReadKey();
        }  
    }

}