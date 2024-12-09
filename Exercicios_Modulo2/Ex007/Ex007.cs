using System;

class Exercicios7{
     static void Main(){     
        Console.WriteLine("Digite dois número ");

        Console.Write("Digite o primeiro número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qual Operação deseja realizar?: ");
        Console.WriteLine("[1] - Adição ");
        Console.WriteLine("[2] - Subtração ");
        Console.WriteLine("[3] - Multiplicação ");
        Console.WriteLine("[4] - Divisão ");
        Console.Write("Opção Selecionada:  ");
        string res = Console.ReadLine();

        switch(res){
            case "1":
                int soma = numero + numero2;
                Console.Write("A soma entre " + numero + " + " + numero2 + " da o total de : " + soma);
                break;
            case "2":
                int sub = numero - numero2;
                Console.Write("A subtração entre " + numero + " - " + numero2 + " da o total de : " + sub);
                break;
            case "3":
                int mult = numero * numero2;
                Console.Write("A multiplicação entre " + numero + " x " + numero2 + " da o total de : " + mult);
                break;
            case "4":
                int div = numero / numero2;
                Console.Write("A Divisao entre " + numero + " / " + numero2 + " da o total de : " + div);
                break;
        }
    }
}