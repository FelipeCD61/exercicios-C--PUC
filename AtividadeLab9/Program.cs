/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descricao: Brincadeira de pedra, papel, tesoura contra o computador várias vezes.
Entrada: Número correspodente a uma jogada.
Saida: Imprime o resultado da partida.
-----------------------------------------------*/
using System;

class Program{
    public static void Main(String[] args){
        Random random = new Random();
        int userPlay, again=1;
        String userPlayWrite=".", randomNumberWrite=".";

        Console.WriteLine("Vamos jogar pedra, papel, tesoura!!");

        do{
            int randomNumber = random.Next(3);

            do{
                Console.WriteLine("\nDigite sua jogada: \n0- Pedra \n1- Papel \n2- Tesoura");
                userPlay=int.Parse(Console.ReadLine());
                if(userPlay<0 || userPlay>2) {
                    Console.WriteLine("Digite uma jogada válida!");
                }
            }while(userPlay<0 || userPlay>2);

            /* Aqui é a parte estética do código */
            if (userPlay == 0) {
                userPlayWrite="Pedra";
            } else if (userPlay == 1) {
                userPlayWrite="Papel";
            } else {
                userPlayWrite="Tesoura";
            }

            if (randomNumber == 0) {
                randomNumberWrite="Pedra";
            } else if (randomNumber == 1) {
                randomNumberWrite="Papel";
            } else {
                randomNumberWrite="Tesoura";
            }

            Console.WriteLine("\nPARTIDA:");
            Console.WriteLine("Sua jogada: {0}", userPlayWrite);
            Console.WriteLine("Computador: {0}", randomNumberWrite);
            /*Aqui termino a parte estética do código */

            if(userPlay == randomNumber) {
                Console.WriteLine("Empatou!");
            } else if(userPlay==0 && randomNumber==2 || userPlay==1 && randomNumber==0 || userPlay==2 && randomNumber==1) {
                Console.WriteLine("Você ganhou!!");
            } else {
                Console.WriteLine("Você perdeu!");
            }

            do{
                Console.WriteLine("\nJogar novamente? 1-Sim | 2-Não");
                again=int.Parse(Console.ReadLine());
                if (again!=1 && again!=2){
                    Console.WriteLine("Por favor, digite uma opção válida!");
                }
            }while (again != 1 && again != 2);

            Console.WriteLine("\n------------------------------------");

        }while(again==1);

    }
}