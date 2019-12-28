using System;
using System.Collections.Generic;

namespace ONP
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = Console.ReadLine();
            Program program = new Program(c);
            Console.ReadKey();
        }
        public Program(string input)
        {
            string[] output = input.Split(' ');
            double[] num = new double[output.Length];

            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == "+" || output[i] == "-" || output[i] == "*" || output[i] == "/" || output[i] == "^")
                    continue;
                else
                    num[i] = double.Parse(output[i]);
            }

            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == "+") 
                    num[i] = num[i - 1] + num[i - 2];
                else if (output[i] == "-")
                    num[i] = num[i - 1] - num[i - 2];
                else if (output[i] == "*")
                    num[i] = num[i - 1] * num[i - 2];
                else if (output[i] == "/")
                    num[i] = num[i - 1] / num[i - 2];
                else if (output[i] == "^")
                    num[i] = Math.Pow(num[i - 1], num[i - 2]);
            }

            Console.WriteLine(num[output.Length - 1]);
            //ps. program działa nieprawidłowo po wpisaniu wiecej niż dwóch liczb przed pierwszym znakiem i więcej niż jednej liczby po pierwszym znaku
        }
    }

}