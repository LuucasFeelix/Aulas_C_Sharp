//Faça um programa que peça a altura e o comprimento de um quadrilátero e mostre a sua área.

using System;

class Exercicio5{
    static void Main(){
        Console.Write("Digite a altura: ");
        double alt = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o comprimento: ");
        double comp = Convert.ToDouble(Console.ReadLine());

        double area = alt * comp;
        Console.Write("A area do Quadrilatero é: " +area);
    }
}