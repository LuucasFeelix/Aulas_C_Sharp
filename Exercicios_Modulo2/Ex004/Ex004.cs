using System;

class Exercicios4{
    static void Main(){
        Console.WriteLine("--------------------");
        Console.WriteLine("Calculador de Media!!");
        Console.WriteLine("--------------------");

        Console.Write("Digite a primeira nota do aluno(a): ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a segunda nota do aluno(a): ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int soma = (n1 + n2) / 2;

        if(soma == 10){
            Console.Write("Sua media foi " + soma + " Aluno(a) Aprovado com Distinção, PARABENS!!!");
        }else if(soma >= 7){
            Console.Write("Sua media foi " + soma + " Aluno(a) Aprovado(a), PARABENS!!!");
        }else{
            Console.Write("Sua media foi " + soma + " Aluno(a) Reprovado(a), Estude Mais!!");
        }
    }
}