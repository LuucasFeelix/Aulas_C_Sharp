using System;

class Program{
    static void Main(){
        // Double > Float > Long > Int > Char
        // Implicita -> realiza do Menos para o Maior

        // int numero1 = 20;
        // float numero2 = numero1;
        // Console.WriteLine(numero2);

        // Explicita -> Realiza Maior para o Menor

        float numero1 = 20.5f;
        int numero2 = (int)numero1; //TypeCast
        Console.WriteLine(numero2);

    }
}