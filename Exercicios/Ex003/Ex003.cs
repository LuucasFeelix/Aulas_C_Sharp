//Faça um Programa que peça as 4 notas bimestrais e mostre a média.
using System;

class Exercicio3{
    static void Main(){
        Console.Write("Digite a primeira Nota: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a segunda Nota: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a terceira Nota: ");
        int n3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a quarta nota: ");
        int n4 = Convert.ToInt32(Console.ReadLine());

        int media = (n1 + n2 + n3 + n4) / 4;
        Console.Write("A soma das notas " + n1 + ", " + n2 + ", " + n3 + ", " + n4 + " Tem a media de: " + media);
    }
}