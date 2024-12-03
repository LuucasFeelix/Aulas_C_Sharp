//Faça um Programa que peça um número e então mostre a mensagem O número informado foi [número].
using System;

class Exercicio1{
    static void Main(){
        Console.WriteLine("Digite um numero:");
        string num = Console.ReadLine();
        Console.WriteLine("O numero Informado foi o: " + num);
    }
}