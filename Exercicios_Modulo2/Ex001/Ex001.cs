using System;

class Exercicios1{
    static void Main(){
        Console.Write("Digite Dois números para saber qual e o Maior!!");

        Console.Write("Digite o Primeiro Número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Segundo Número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        if(n1 > n2){
            Console.Write("O número Maior e "  n1);
        }else if(n2 > n1){
            Console.Write("O número Maior e "  n2);
        }else{
            Console.Write("Os Dois números são iguais.")
        }
    }
}