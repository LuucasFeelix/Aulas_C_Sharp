// Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre: o produto
// do dobro do primeiro com metade do segundo. a soma do triplo do primeiro com o terceiro. o
// terceiro elevado ao cubo. 

using System;

class Exercicio9{
    static void Main(){
        Console.Write("Digite um numero inteiro: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite um numero real: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        double n3 = (n1*2)*(n2/2);
        double n4 = (n1*3)+n3;
        double n5 = Math.Pow(n4,3);

        Console.Write(n3+" "+n4+" "+n5);

    }
}

