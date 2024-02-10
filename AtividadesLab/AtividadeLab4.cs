/*-------------------------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Atividade: 
Neste exercício prático, você vai criar um programa em C#  que permite 
calcular o tamanho do terceiro lado de um triângulo, dado que você já 
possui os comprimentos dos outros dois lados. Você vai aplicar o 
Teorema de Pitágoras para resolver esse problema.

Você deve criar um programa que receba do usuário o comprimento do
primeiro lado do triângulo (a), depois recebe o segundo lado (b) e, 
em seguida, deve calcular e exibir qual é o tamanho do segundo lado 
usando o teorema de Pitágoras.

Após desenvolver o programa você deve realizar testes para validar 
o seu programa, descrevendo quais são as entradas e saídas esperadas,
para pelo menos, 10 casos de testes e enviar junto do seu código, os 
testes realizados, no formato de comentário de código.
-------------------------------------------------------------*/
using System;

class AtividadeLab4 {
  public static void Main (string[] args) {
    double catA, catB, hipt; 
    //catA = cateto A / catB = cateto B / hipt = hipotenusa

    Console.Write("Digite o comprimento do 1° cateto: ");
    catA = double.Parse(Console.ReadLine());
    Console.Write("Digite o comprimento do 2° cateto: ");
    catB = double.Parse(Console.ReadLine());

    hipt = Math.Sqrt((catA * catA) + (catB * catB)); //Calculo a hipotenusa
    
    Console.WriteLine(); //Saltei uma linha para organização
    Console.WriteLine($"A medida da hipotenusa é: {hipt:f2}");
    
  }
  /* Validações:
    Caso 01: catA = 3 | catB = 4 | hipt = 5;
    Caso 02: catA = 5 | catB = 7 | hipt = 8.60;
    Caso 03: catA = 9 | catB = 27 | hipt = 28.46;
    Caso 04: catA = 12 | catB = 18 | hipt = 21.63;
    Caso 05: catA = 24 | catB = 12 | hipt = 26.83;
    Caso 06: catA = 9 | catB = 16 | hipt = 18.36;
    Caso 07: catA = 12 | catB = 16 | hipt = 20;
    Caso 08: catA = 21 | catB = 28 | hipt = 35;
    Caso 09: catA = 36 | catB = 48 | hipt = 60;
    Caso 10: catA = 45 | catB = 60 | hipt = 75;
  */
}