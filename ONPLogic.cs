using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONP
{
    class ONPLogic
    {
        List<string> listOfEwerything;
        List<double> listOfNumbers;
        public ONPLogic(string equation)
        {
            listOfEwerything = new List<string>();
            listOfNumbers = new List<double>();
            AddToList(equation);
            NubmersConverter();
        }
        private void NubmersConverter()
        {
            for(int i = 0; i < listOfEwerything.Count(); i++)
                if (listOfEwerything[i] != "+" && listOfEwerything[i] != "-" && listOfEwerything[i] != "*" &&
                    listOfEwerything[i] != "/" && listOfEwerything[i] != "^")
                {
                    double temporary = double.Parse(listOfEwerything[i]);
                    listOfNumbers.Add(temporary);
                }
        }
        private void AddToList(string str)
        {
            string[] elements = str.Split(' ');
            for (int i = 0; i < elements.Length; i++)
                listOfEwerything.Add(elements[i]);
        }
        public double Calculator()
        {
            for (int i = 0; i < listOfEwerything.Count(); i++)
            { 
                if (listOfEwerything[i] == "+")
                {
                    listOfEwerything.RemoveAt(i);
                    listOfNumbers[i - 2] += listOfNumbers[i - 1];
                    listOfNumbers.RemoveAt(i - 1);
                    listOfEwerything.RemoveAt(i - 1);
                    i = 0;
                }
                else if(listOfEwerything[i] == "-")
                {
                    listOfEwerything.RemoveAt(i);
                    listOfNumbers[i - 2] -= listOfNumbers[i - 1];
                    listOfNumbers.RemoveAt(i - 1);
                    listOfEwerything.RemoveAt(i - 1);
                    i = 0;
                }
                else if (listOfEwerything[i] == "*")
                {
                    listOfEwerything.RemoveAt(i);
                    listOfNumbers[i - 2] *= listOfNumbers[i - 1];
                    listOfNumbers.RemoveAt(i - 1);
                    listOfEwerything.RemoveAt(i - 1);
                    i = 0;
                }
                else if (listOfEwerything[i] == "/")
                {
                    listOfEwerything.RemoveAt(i);
                    listOfNumbers[i - 2] /= listOfNumbers[i - 1];
                    listOfNumbers.RemoveAt(i - 1);
                    listOfEwerything.RemoveAt(i - 1);
                    i = 0;
                }
            }
            return listOfNumbers[0];
        }
    }
}
