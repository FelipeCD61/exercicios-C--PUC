/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descricao: Análise de Matrizes e por minha opção, aplicação de funções.
Entrada: Nome de 60 alunos de uma class e suas 4 notas.
Saída: Nome do aluno, a soma de suas nota, sua situação(Aprovado, reporvado
e reavaliação) e a média da classe.
-----------------------------------------------*/
using System;
class Program {
    public static void Main (String[] args){
        double [,] notas = new double [60,4];
        String [] nomes = new String [60];

        for(int i=0;i<60;i++){
            Console.WriteLine($"Digite o nome do aluno {i + 1}°:");
            nomes[i] = (Console.ReadLine());
        }

        for(int x=0;x<60;x++){
            for(int y=0;y<4;y++){
                do{
                    string breakLine = y == 3 ? "\n" : ""; //Fiz essa quebra para separar as notas de um aluno para outro
                    Console.WriteLine($"Digite a {y + 1}° nota do {x + 1}° aluno:");
                    notas[x,y] = double.Parse(Console.ReadLine());
                    Console.Write($"{breakLine}");

                    if(notas[x,y]>=25){
                        Console.WriteLine("Favor digitar uma nota menor que 25");
                    }
                }while(notas[x,y]>=25);
            }
        }
        for(int i=0;i<60;i++){
            Console.WriteLine($"\nAluno: {nomes[i]}");
            Console.WriteLine($"Soma das notas: {soma(notas[i,0], notas[i,1], notas[i,2], notas[i,3])}");
            Console.WriteLine($"Situação: {status(notas[i,0], notas[i,1], notas[i,2], notas[i,3])}");
        }
        Console.WriteLine($"\nMédia da classe: {mediaClasse(notas)}\n"); //Usei \n para deixar a média da classe mais vísivel
    }

    static double soma (double n1, double n2, double n3, double n4){
        double somaNotas = 0;
        somaNotas = n1+n2+n3+n4;
        return somaNotas;
    }

    static double mediaNotas (double n1, double n2, double n3, double n4){
        double media = 0;
        media = n1+n2+n3+n4 / 4;
        return media;
    }

    static String status (double n1, double n2, double n3, double n4){
       if (soma(n1,n2,n3,n4)>=60){
           return "Aprovado";
       } else if(soma(n1,n2,n3,n4)<35){
           return "Reprovado";
       } else {
           return "Reavaliação";
       }
    }

    static double mediaClasse (double [,] nota){
        double media = 0, cont = 0;
        for(int x=0;x<3;x++){
            for(int y=0;y<4;y++){
                cont += nota[x,y];
            }
        }
        media = cont / 12;
        return media;
    }
}