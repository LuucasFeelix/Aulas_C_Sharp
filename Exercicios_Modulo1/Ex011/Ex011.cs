// Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros
// quadrados da área a ser pintada.
// Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados e que a tinta é
// vendida em latas de 18 litros, que custam R$ 80,00.
// Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

using System;

class Exercicio11{
    static void Main(){
        Console.Write("Digite o tamanho da area a ser pitanda (m2): ");
        double area = Convert.ToInt32(Console.ReadLine());
        double latas = Math.Ceiling(area/54);
        double preco = latas * 80.00;
        Console.WriteLine("Sao precisas "+latas+ " latas de Lintas.");
        Console.WriteLine("Com o valor de: "+preco+"R$");
    }
}

