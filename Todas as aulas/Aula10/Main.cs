using System;

class Program{
    static void Main(){
        // Metodos para Conversão
        // Convert.ToString();
        // Convert.ToDouble();
        // Convert.ToInt32();

        // string t1 = "3";
        // int numero1 = Convert.ToInt32(t1);
        // Console.WriteLine(numero1);

        Console.Write("Digite o Primeiro Numero: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o Segundo Numero: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int res = n1+n2;

        Console.WriteLine("A soma entre o "+n1+ " + " +n2+ " e igual a = "+res);
        
    }
}