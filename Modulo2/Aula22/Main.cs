using System;

class program{
    static void Main(){
        //Estrutura Switch - case
        Console.WriteLine("Escolha um Opção");
        Console.WriteLine("[1] - Opção 1");
        Console.WriteLine("[2] - Opção 2");
        Console.WriteLine("[3] - Opção 3");
        int res = Convert.ToInt32(Console.ReadLine());

        switch(res){
            case 1: 
                Console.WriteLine("Voce Escolheu a Opção 1");
                break;
            case 2:
                Console.WriteLine("Voce Escolheu a Opção 2");
                break;
            case 3:
                Console.WriteLine("Voce Escolheu a Opção 3");
                break;
            default:
                Console.WriteLine("Isso nao e uma Opção!!");
                break;
        }
    }
}