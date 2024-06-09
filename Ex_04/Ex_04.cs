/*4 Escreva um programa que leia três lados de um triângulo e verifique se eles formam um triângulo válido. Para isso, a soma de dois lados deve ser sempre maior que o terceiro lado. */
using System;

class PositivoNegativOuZero
{
    static void Main(string[] args)
    {
        Console.Write("Digite o comprimento do primeiro lado: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o comprimento do segundo lado: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o comprimento do terceiro lado: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        // Verifica se os lados formam um triângulo válido
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            Console.WriteLine("Os três lados formam um triângulo válido.");
        }
        else
        {
            Console.WriteLine("Os três lados não formam um triângulo válido.");
        }
    }
}