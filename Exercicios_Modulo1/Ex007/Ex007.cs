// Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês.

using System;

class Exercicio7{
    static void Main(){
        Console.Write("Quanto voce ganha por Hora?: ");
        double ph = Convert.ToDouble(Console.ReadLine());
        Console.Write("Numero de Horas Trabalhadas por mes?: ");
        double pm = Convert.ToDouble(Console.ReadLine());

        double totHoras = ph * pm;
        Console.Write("O total do seu salario no mes e de: " +totHoras);
    }
}