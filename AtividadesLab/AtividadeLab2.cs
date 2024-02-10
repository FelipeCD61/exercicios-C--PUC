/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descrição: Práticando diversas formas de saída de dados.
-----------------------------------------------*/
using System;

class AtividadeLab2 {
  public static void Main (string[] args) {
    //Declarção e inscerção de dados
    string nome = "Felipe";
    int idade = 18;
    double altura = 1.77, mensalidade = 777.99;
    //Utilizando linhas com quebras de linha e variáveis de tipos diferentes:
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Idade: " + idade);
    Console.WriteLine("Altura: " + altura);
    Console.WriteLine("Mensalidade: R$" + mensalidade);

    Console.WriteLine(""); // Fiz uma quebra de linha para organização

    //Utilizando placeholders numéricos e placeholders com o formato de interpolação:
    Console.WriteLine("Mensalidade: {0:C}", mensalidade);
    
    Console.WriteLine($"Nome: {nome} | Altura: {altura} | Idade: {idade}");

    Console.WriteLine(""); //Quebra de linha para organização

    //Utilizando placeholders com formatação numérica e alinhamento e preenchimento:
    Console.WriteLine("Idade: {0:D4} | Altura: {1,10}",idade, altura);

    Console.WriteLine(""); //Quebra de linha para organização

    //Utilizando caracteres especiais e Concatenando várias chamadas de Console.Write:
    Console.Write("Descrição:\n \tMeu nome é {0} ",nome);
    Console.Write("e tenho {0} anos.",idade);
  }
}