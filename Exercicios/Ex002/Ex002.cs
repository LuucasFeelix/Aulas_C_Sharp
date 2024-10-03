//Faça um Programa que peça dois números e imprima a soma
using System;

class Exercicio2{
    static void Main(){
        Console.Write("Digite o primeiro numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        int tot = num1 + num2;
        Console.Write("A soma entre o numero " + num1 + " eo numero " + num2 + " é: " + tot);
    }
}