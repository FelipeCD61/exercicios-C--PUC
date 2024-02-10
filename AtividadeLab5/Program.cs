/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descricao: Analise das notas de uma aluni
Entrada: Notas
Saida: Imprime sua situação por completo da sua aprovação ou reprovação
-----------------------------------------------*/
using System;

class Program {
  public static void Main (string[] args) {
    double A1=0,A2=0,B1=0,B2=0,Ats=0,Total=0,Frequencia=0; //Ats = Atividades

    Console.Write("Digite sua nota na prova 1A: ");
    A1 = double.Parse(Console.ReadLine());
    Console.Write("Digite sua nota na prova 2A: ");
    A2 = double.Parse(Console.ReadLine());
    Console.Write("Digite sua nota na prova 1B: ");
    B1 = double.Parse(Console.ReadLine());
    Console.Write("Digite sua nota na prova 2B: ");
    B2 = double.Parse(Console.ReadLine());
    Console.Write("Digite seus pontos de atividades: ");
    Ats = double.Parse(Console.ReadLine());
    Console.Write("Digite qual é a sua porcentagem de frequência no semestre(75% = 75): ");
    Frequencia = double.Parse(Console.ReadLine());

    Total = A1 + A2 + B1 + B2 + Ats;
    Console.WriteLine("");//Quebra de linha para organização

    Console.WriteLine("Descricão:   |\t Nota:");
    Console.WriteLine("Módulo 1:    |{0,5} \nMódulo 2:    |{1,5} \nAtividades:  |{2,5} \nTotal:       |{3,5} \nFrequência:  |{4,5}%", A1+A2, B1+B2, Ats, Total, Frequencia);
    
    Console.WriteLine("");//Quebra de linha para organização

    if (Frequencia >= 75 && Total >= 60) { 
        Console.WriteLine("Aluno aprovado.");
    } else if (Math.Max(A1+A2, B1+B2) + Ats >= 20 && Frequencia >= 75) {
          Console.WriteLine("Aluno poderá fazer a reavaliação.");
    } else {
          Console.WriteLine("Aluno reprovado.");
    }    
  }
}