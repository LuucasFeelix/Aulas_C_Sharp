using System;

class program{
    static void Main(){
        inicio:
        Console.Write("Digite um Numero: (0-10): ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        if(n1 >= 0 && n1 <= 10){
            Console.WriteLine("Valor Entergue");
        }else{
            Console.WriteLine("ERRO: Valor invalido");
            goto inicio; //Vai para
        }

    }
}