using System;

class program{
    static void Main(){
        Console.Write("Escreva um numero (0-9): ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O numero é maior que 5? (s/n)");
        string res = Console.ReadLine();

        if(res == "s"){
            Console.WriteLine("O numero é par? (s/n)");
            string res2 = Console.ReadLine();
            if(res2 == "s"){
                Console.WriteLine("O numero é 6? (s/n)");
                string res3 = Console.ReadLine();
                if (res3 == "s"){
                    Console.Write("Acertei");
                }else{
                    Console.WriteLine("O numero e 8!");
                }
            }else{
                Console.WriteLine("O numero é 7? (s/n)");
                string res3 = Console.ReadLine();
                if (res3 == "s"){
                    Console.Write("Acertei");
                }else{
                    Console.WriteLine("O numero e 9!");
                }
            }
        } else if (res == "n"){

        }else{
            Console.WriteLine("Nao conheço a resposta.");
        }

    }
}