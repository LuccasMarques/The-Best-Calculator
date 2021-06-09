using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool infity = true;
            bool testnumbers = true;
            char test;

            do
            {
            Console.Clear();

            Console.WriteLine("Welcome to the Best CC Basic Calculator!");

            Dados dadosCalc = new Dados();

                do
                {
                    Console.WriteLine("Write the first number");

                    try
                    {
                        dadosCalc.NumberOne = Convert.ToDouble(Console.ReadLine());
                        testnumbers = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Hey bro, just to remeber... I have my eyes on you xD WRITE A REAL NUMBER OKAY?");
                    }
                } while (testnumbers);

                testnumbers = true;
                do
                {
                    Console.WriteLine("Write the second number");

                    try
                    {
                        dadosCalc.NumberTwo = Convert.ToDouble(Console.ReadLine());
                        testnumbers = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Hey bro, just to remeber... I have my eyes on you xD WRITE A REAL NUMBER OKAY?");
                    }
                } while (testnumbers);
                do
            {
                Console.WriteLine("Hey buddy, dont forget to write the right operator ( + - * /)");

                try
                {
                    dadosCalc.Operador = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Hey bro, just put one character in there... I have my eyes on you xD") ;
                }
               
            } while (dadosCalc.Operador != '+' && dadosCalc.Operador != '-' && dadosCalc.Operador != '*' && dadosCalc.Operador != '/'); /*||*/




            Console.WriteLine("The result is: "+dadosCalc.ExecutaOperacao());
                do
                {

                    Console.WriteLine("Do you want to continue? ( y for YES or n for NO I DON'T WANT TO USE THIS PROGRAM ANYMORE)");
                    test = Convert.ToChar(Console.ReadLine());
                    if (test == 'n')
                    {
                        infity = false;
                    }


                } while (test != 'y' && test != 'n');

            } while (infity);


            Console.WriteLine("See ya. If you need me next time, don't forget to open xD");
        }
    }
}
