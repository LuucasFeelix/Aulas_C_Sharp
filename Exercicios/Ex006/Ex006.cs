// Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal, usando a seguinte fórmula: (72.7*altura) – 58

using System;

class Exercicio6{
    static void Main(){
        Console.Write("Digite sua Altura: ");
        double alt = Convert.ToDouble(Console.ReadLine());


        double mp = (72.7 * alt) - 58;
        Console.Write("O seu peso ideal e de: " + mp);

    }
}