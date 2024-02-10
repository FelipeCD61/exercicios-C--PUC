/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descrição: Calcular e imprimir:
(a) A subtração dos dois números;
(b) O quadrado de cada número;
(c) A média dos dois números digitados.
Entrada: Receber dois números. 
Saída: A subtração dos dois números, o quadrado
de cada número e a média deles.
-----------------------------------------------*/
using System;

class Atividade2Lab1 {
  public static void Main (string[] args) { 
    //DECLARACAO DE VARIAVEIS
    int num1=0, num2=0, subtracao=0, quadradoNum1=0, quadradoNum2=0, media=0;
    //ENTRADA DE DADOS
    Console.WriteLine ("Digite o primeiro número inteiro: ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite o segundo número inteiro: ");
    num2 = int.Parse(Console.ReadLine());
    //PROCESSAMENTO
    subtracao = num1 - num2;
    quadradoNum1 = num1 * num1;
    quadradoNum2 = num2 * num2;
    media = (num1 + num2) / 2;
    //SAIDA
    Console.WriteLine(""); //Coloquei uma quebra de linha para organização
    Console.WriteLine ("Resultados:");
    Console.WriteLine ("Subtração: {0} - {1} = {2}", num1, num2, subtracao);
    Console.WriteLine ("Quadrado do 1° número: {0}", quadradoNum1);
    Console.WriteLine ("Quadrado do 2° número: {0}", quadradoNum2);
    Console.WriteLine ("Média dos dois números: {0}", media);
  }
}