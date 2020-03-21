using System;
using System.Collections.Generic;

namespace ONP
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Every char in equation should be separated by SPACE
             
            Console.WriteLine("Enter RPN equation: ");
            string equation = Console.ReadLine();
            ONPLogic onpLogic = new ONPLogic(equation);

            Console.WriteLine(onpLogic.Calculator());
            Console.ReadKey();
        }  
    }

}