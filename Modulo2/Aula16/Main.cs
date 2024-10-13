using System;

class Aula16{
    static void Main(){
        // Operadores Logicos
        bool b1 = true;
        bool b2 = false;
        int n1 = 20;
        int n2 = 30;


        bool exp = b1 && b2; // AND (e)
        bool exp2 = b1 || b2; //OR (ou)
        bool exp3 = b1 == b2 && n1 == n2;
        
        Console.WriteLine(exp);
        Console.WriteLine(exp2);
        Console.WriteLine(exp3);

    }
}