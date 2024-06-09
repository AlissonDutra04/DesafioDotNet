/*1) Escreva um programa que leia um número inteiro e informe se ele é par ou ímpar. */
using System;

class ImparOuPar
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número digitado é par.");
        }
        else
        {
            Console.WriteLine("O número digitado é ímpar.");
        }
    }
}