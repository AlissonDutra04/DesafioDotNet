/*2) Escreva um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero. */
using System;

class PositivoNegativOuZero
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("O número digitado é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número digitado é negativo.");
        }
        else
        {
            Console.WriteLine("O número digitado é zero.");
        }
    }
}