// Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade
// de um link de Internet (em Mbps), calcule e informe o tempo aproximado de download do
// arquivo usando este link (em minutos)

using System;

class Exercicio10{
    static void Main(){
         Console.Write("Digite o tamanho de um arquivo (MB): ");
        int mb = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a velocidade da internet (mbps): ");
        int mbps = Convert.ToInt32(Console.ReadLine());

        int tamanhoMb = mb * 8;
        int tempoDownload = tamanhoMb / mbps;
     

        Console.Write("O tempo par realizar download sera: " +tempoDownload);
    }
}

