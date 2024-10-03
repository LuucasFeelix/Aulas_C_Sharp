// Faça um Programa que converta metros para centímetros.
using System;

class Exercicio4{
    static void Main(){
        Console.Write("Digite quantos metros precisa converter: ");
        int metro = Convert.ToInt32(Console.ReadLine());
         
        int centi = metro * 100;
        Console.Write(+ metro +"m convertido em centimetros fica: " + centi + "cm");

    }
}