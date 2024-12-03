using System;

class Exercicios1{
    static void Main(){
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Digite Dois números para saber qual e o Maior!!");
        Console.WriteLine("-----------------------------------------------");

        Console.Write("Digite o Primeiro Número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Segundo Número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        if(n1 > n2){
            Console.Write("O número Maior e " + n1);
        }else{
            Console.Write("O número Maior e " + n2);
        }    
    }
}