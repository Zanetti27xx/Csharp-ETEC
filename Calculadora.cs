/*
 Matheus Fumani Zanetti
 RM = 50081
 */

using System;

namespace Calculadora
{
    class Calculadora
    {
        public double m1;
        public double m2;

        public void somar()
        {
            Console.WriteLine("\nO resultado da soma é: " + (m1 + m2));
        }

        public void subtrair()
        {
            Console.WriteLine("\nO resultado da subtração é " + (m1 - m2));
        }

        public void multiplicar()
        {
            Console.WriteLine("\nO resultado da multiplicãção é " + (m1 * m2));
        }

        public void dividir()
        {
            Console.WriteLine("\nO resultado da divisão é " + (m1 / m2));
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Calculadora c1 = new Calculadora();
            Calculadora c2 = new Calculadora();
            c1.m1 = 2;
            c1.m2 = 5;
            c2.m1 = 8;
            c2.m2 = 10;

            c1.somar();
            c1.subtrair();
            c1.multiplicar();
            c1.dividir();
            c2.somar();
            c2.subtrair();
            c2.multiplicar();
            c2.dividir();
        }
    }
}

