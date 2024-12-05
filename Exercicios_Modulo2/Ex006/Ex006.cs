using System;

class Exercicios6{
    static void Main(){
        Console.WriteLine("--------------------");
        Console.WriteLine("Verificar se o número e inteiro ou decimal!!");
        Console.WriteLine("--------------------");
     
        Console.Write("Digite um número para verificar se e inteiro ou decimal: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if(numero % 1 == 0){
            Console.Write("O número " + numero + " ele é INTEIRO");
        }else{
            Console.Write("O número " + numero + " ele é DECIMAL");
        }
    }
}