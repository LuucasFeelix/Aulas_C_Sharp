 using System;

 class Exercicios10{
    static void Main(){

        Console.Write("Que horas são?: ");
        int hora = Convert.ToInt32(Console.ReadLine());

        if(hora >=5 && hora<=12 ){
            Console.Write("Agora sao exatamente " + hora + " Boa Dia!!");
        }else if (hora >12 && hora <= 19){
            Console.Write("Agora sao exatamente " + hora + " Boa Tarde!!");
        }else{
         Console.Write("Agora sao exatamente " + hora + " Boa Noite!!");
        }
    }  
 }