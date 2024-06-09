/*8) Escreva um programa que leia a nota de um aluno e converta-a para conceito: A (nota >= 9), B (7 <= nota < 9), C (5 <= nota < 7), D (3 <= nota < 5) e F (nota < 3). */
using System;

class NotaConceito
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a nota do aluno:");
        float nota = float.Parse(Console.ReadLine());

        if (nota >= 9)
        {
            Console.WriteLine("Conceito: A");
        }
        else if (nota >= 7 && nota < 9)
        {
            Console.WriteLine("Conceito: B");
        }
        else if (nota >= 5 && nota < 7)
        {
            Console.WriteLine("Conceito: C");
        }
        else if (nota >= 3 && nota < 5)
        {
            Console.WriteLine("Conceito: D");
        }
        else if (nota < 3)
        {
            Console.WriteLine("Conceito: F");
        }
    }
}
