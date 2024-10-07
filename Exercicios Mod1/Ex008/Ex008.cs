// Faça um programa que peça o raio de um círculo e calcule a sua área. 

using System;

class Exercicio8{
    static void Main(){
        Console.Write("Informe o raio do Circulo: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(raio, 2);
        Console.Write("A area total do circulo e de: "+area);
    }
}

