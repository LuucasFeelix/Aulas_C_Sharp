using System;

class Exercicios3{
    static void Main(){
        Console.Write("Selecione o seu Sexo (F/M): ");
        String sexo = Console.ReadLine();

        if(sexo == "M"){
            Console.Write("Sexo Masculino Selecionado.");
        }else if(sexo == "F"){
            Console.Write("Sexo Feminino Selecionado");
        }else{
            Console.Write("Sexo Invalido!!");
        }
    }
}