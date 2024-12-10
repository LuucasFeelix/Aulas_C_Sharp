 using System;


 class Exercicios9{
    static void Main(){
        Console.WriteLine("--------------------");
        Console.WriteLine("Digite 3 Número para saber o maior!!!");
        Console.WriteLine("--------------------");

        Console.Write("Digite o Primeiro número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Segundo número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Terceiro número: ");
        int n3 = Convert.ToInt32(Console.ReadLine());

        if(n1 > n2 && n1 > n3){
            Console.Write("O Numero Maior e o Primeiro: " + n1);
        }else if (n2 > n1 && n2 > n3){
            Console.Write("O Numero Maior e o Segundo: " + n2);
        }else{
         Console.Write("O Numero Maior e o Terceiro: "+ n3);
        }
    }  
 }