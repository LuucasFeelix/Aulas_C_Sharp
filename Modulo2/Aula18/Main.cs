using System;

class program{
    static void Main(){
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if(idade >=18){
            Console.WriteLine("Voce ja pode beber");
        }
        else{ // Se não
            Console.WriteLine("Voce não pode beber!");
        }
    }
} 