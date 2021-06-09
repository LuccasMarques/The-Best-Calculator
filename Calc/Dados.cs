using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class Dados
    {
        private double numberOne;
        private double numberTwo;
        private char operador;

        public double NumberOne { get => numberOne; set => numberOne = value; }
        public double NumberTwo { get => numberTwo; set => numberTwo = value; }
        public char Operador { get => operador; set => operador = value; }

        public double ExecutaOperacao()
        {
            double resultado=0;

            switch (operador)
            {
                case '+':
                    resultado = numberOne + numberTwo;
                break;
                case '-':
                    resultado = numberOne - numberTwo;
                break;
                case '*':
                    resultado = numberOne * numberTwo;
                break;
                case '/':
                    if (numberTwo == 0)
                    {
                        Console.WriteLine("Hey dude... Do you want to explode your PC? how can I divide {0} by zero... that is infinity...",numberOne);
                    }
                    else
                    {
                        resultado = numberOne / numberTwo;
                    }
                    
                break;
            }
            return resultado;
        }


    }
}
