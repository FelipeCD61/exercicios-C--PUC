/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descricao: Calcula as estatísticas de jogos entre Cruzeiro e Atlético.
Entrada: Gols do Atlético, gols do Cruzeiro, iniciar novo duelo.
Saida: Estatísticas dos jogos, empates, quantas vitórias cada time obteve, quem venceu mais duelos.
-----------------------------------------------*/

using System;

class Program {
    static public void Main(string[] args) {
        int goalsC, goalsA, draw = 0, newDuel = 0, winC = 0, winA = 0, matches = 0;
        string winner;

        while (newDuel != 2) {
            Console.WriteLine("\nDigite o número de gols marcados pelo Cruzeiro:");
            goalsC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de gols marcados pelo Atlético:");
            goalsA = int.Parse(Console.ReadLine());

            if (goalsA > goalsC) {
                Console.WriteLine("Atlético é o vitorioso!");
                winA++;
            } else if (goalsC > goalsA) {
                Console.WriteLine("Cruzeiro é o vitorioso!");
                winC++;
            } else {
                Console.WriteLine("Ocorreu um empate.");
                draw++;
            }

            matches++;

            Console.WriteLine("\nNovo duelo? \n1.SIM \n2.NÃO \n-----------------");
            newDuel = int.Parse(Console.ReadLine());
        }

        if(winA > winC) {
            winner = "Atlético";
        } else if(winC > winA) {
            winner = "Cruzeiro";
        } else {
            winner = "Não houve vencedor";
        }

        Console.WriteLine($"\nEstatísticas: \n\nJogos realizados: {matches}");
        Console.WriteLine($"Vitórias do Atlético: {winA}");
        Console.WriteLine($"Vitórias do Cruzeiro: {winC}");
        Console.WriteLine($"Empates: {draw}");
        Console.WriteLine($"Maior número de duelos ganhos: {winner}");
    }
}