 using System;


 class Exercicios8{
    static void Main(){
        Console.WriteLine("--------------------");
        Console.WriteLine("Verificar se o ano e Bissexto!!");
        Console.WriteLine("--------------------");

        Console.Write("Digite o Ano que deseja saber se ele e Bissexto: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        if (ano % 4 == 0){
            Console.Write("O Ano " + ano + " ele e um ano Bissexto!!");
        }else{
            Console.Write("O Ano " + ano + " ele não e um ano Bissexto!!");
        }  
    }  
 }
        