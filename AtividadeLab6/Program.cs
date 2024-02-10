/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descricao: Calcula IMC
Entrada: Peso e altura
Saida: Imprime sua situação em relação ao seu IMC
-----------------------------------------------*/
using System;

class Program {
    public static void Main (string[] args) {
        double peso, altura, imc;
        Console.WriteLine("Digite seu peso:");
        peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua altura:");
        altura = double.Parse(Console.ReadLine());

        imc = peso / Math.Pow(altura,2); //Calculo o imc
        Console.WriteLine("\nSeu IMC é {0:F2}",imc);

        switch(imc) {
            case < 20:
                Console.WriteLine("Você está abaixo do peso.");
                break;
            case < 25:
                Console.WriteLine("Você está com peso normal.");
                break;
            case < 30:
                Console.WriteLine("Você está acima do peso.");
                break;
            case < 34:
                Console.WriteLine("Você está obeso.");
                break;
            case >= 34:
                Console.WriteLine("Você está muito obeso.");
                break;
            default:
                Console.WriteLine("Aconteceu um erro!");
                break;
        }
    }
}