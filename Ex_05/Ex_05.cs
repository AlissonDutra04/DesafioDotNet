/*5) Escreva um programa que leia três notas de um aluno e calcule a média. Informe se o aluno está aprovado (média >= 7), em recuperação (5 <= média < 7) ou reprovado (média < 5). */
using System;

class AprovadoOuReprovado
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira nota");
        float nota1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota");
        float nota2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota");
        float nota3 = float.Parse(Console.ReadLine());

        float media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
        {
            Console.WriteLine("Aluno aprovado com a média: " + media);
        }
        else if (media >= 5 && media < 7)
        {
            Console.WriteLine("Aluno está de recuperação com a média: " + media);
        }
        else 
        {
            Console.WriteLine("Aluno está reprovado com a média: " +media);
        }
    }
}
