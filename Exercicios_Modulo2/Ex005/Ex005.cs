using System;

class Exercicios5{
    static void Main(){
        Console.WriteLine("--------------------");
        Console.WriteLine("Verificar se o número e impar ou par!!");
        Console.WriteLine("--------------------");

        Console.Write("Digite um número para Verificar se e 'PAR' ou 'IMPAR': ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num % 2 == 0){
            Console.Write("O Número " + num + " que voce digitou e PAR");
        }else{
            Console.Write("O Número " + num + " que voce digitou e IMPAR");
        }      
    }
}