/*-------------------------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Atividade: 
Faça um algoritmo que encontre as raízes de uma equação do 
segundo grau dados os coeficientes a, b e c. O usuário 
deverá informar com os coeficientes a, b e c da equação e 
o seu programa deve retornar as raízes da equação.
Na tela, os valores de x1 e x2 deverão ser exibidos alinhados,
um embaixo do outro. Por exemplo:
x1 23.00
x2 -145.14
-------------------------------------------------------------*/

using System;

class AtividadeLab3 {
  public static void Main (string[] args) {
    double A=0,B=0,C=0,delta=0,x1=0,x2=0;

    Console.WriteLine("Digite uma equação de 2° grau:\n Ax^2 * Bx * C = 0");
    Console.WriteLine(""); //Quebra de linha para organização

    //Entrada de coeficientes:
    Console.Write("Digite o coeficiente A: ");
    A = double.Parse(Console.ReadLine());
    Console.Write("Digite o coeficiente B: ");
    B = double.Parse(Console.ReadLine());
    Console.Write("Digite o coeficiente C: ");
    C = double.Parse(Console.ReadLine());

    //Aqui calculo o discriminante:
    delta = (B * B) - (4 * A * C);

    //Calculo as raizes:
    x1 = (- B + Math.Sqrt(delta)) / 2 * A;
    x2 = (- B - Math.Sqrt(delta)) / 2 * A;

    //Saida
    Console.WriteLine("x1 = {0:F2} \nx2 = {1:F2}", x1, x2);    
  }
}