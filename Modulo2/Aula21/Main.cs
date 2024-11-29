using System;

class program{
    static void Main(){
        Console.Write("Digite Algo: ");
        int res = Convert.ToInt32(Console.ReadLine());
    
        if(res.GetType() == typeof(String)){
            Console.WriteLine("É uma String");
        }else{
            Console.WriteLine("Não e uma String");
        }
    }
}