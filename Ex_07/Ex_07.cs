/*7) Escreva um programa que leia a idade de uma pessoa e informe se ela é uma criança (0-12 anos), adolescente (13-17 anos), adulto (18-59 anos) ou idoso (60 anos ou mais). */

using System;

using System;

public class IdadePessoa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a idade da pessoa");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 0 && idade <= 12)
        {
            Console.WriteLine("É uma criança");
        }
        else if (idade >= 13 && idade <= 17)
        {
            Console.WriteLine("É um adolescente");
        }
        else if (idade >= 18 && idade <= 59)
        {
            Console.WriteLine("É um adulto");
        }
        else if (idade >= 60)
        {
            Console.WriteLine("É um idoso");
        }
    }
}
