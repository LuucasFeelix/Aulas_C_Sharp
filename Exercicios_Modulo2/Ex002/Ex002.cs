using System;

class Exercicios2{
    static void Main(){
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Digite um número para saber se e negativo ou positivo!!");
        Console.WriteLine("--------------------------------------------------------");

        Console.Write("Qual Número voce deseja Saber?: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num >= 0){
            Console.Write("O numero " + num +  " ele é Positivo!!");
        }else if(num < 0){
            Console.Write("O numero " + num +  " ele é Negativo!!");
        }
    }
}