using System;
using System.Globalization;

namespace Exerciocio04
{
    class Program
    {
        static void Main(string[] args)
        {

            //Programa para demosntrar o uso de classe Statica!!!


            Console.Write("Qual é a cotação do Dólar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           
            double result = ConversorDeMoeda.Calculo(cotacao,quantia);
            Console.Write("Valor a ser pago em Reais:  " + result.ToString("F2",CultureInfo.InvariantCulture));
        }
        
    }
}
