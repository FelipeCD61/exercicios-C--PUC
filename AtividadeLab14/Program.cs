/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descricao: Funções - Capicuas e Primos.
Entrada: Não possui entrada pelo usuário.
Saida: Dentre os números de 1 a 5000 são capicuas,
os que são primos e os que são capicuas e primos simultaneamente.
-----------------------------------------------*/
using System;
class Program {
    public static void Main (String[] args){
        for(int num=1;num<5000;num++){
            if(primo(num) && capicua(num)){
                Console.WriteLine($"\n{num} é primo e é capicua");
            } else {
                if(primo(num)){
                    Console.WriteLine($"\n{num} é primo");
                }
                if(capicua(num)){
                    Console.WriteLine($"\n{num} é capicua");
                }
            }

        }
    }

    static int reverse (int n){
        int reverser = 0;
        while(n >= 0){
            int element = n % 10;
            n /= 10;
            reverser = reverser*10 + element;

            if(n==0){
                break;
            }
        }
        return reverser;
    }

    static bool primo(int n){
        int qtd = 0;
        for(int i=1;i<=n;i++){
            if(n % i==0){
                qtd++;
            }
        }
        if(qtd<=2){
            return true;
        } else {
            return false;
        }
    }

    static bool capicua(int n){
        if (n == reverse(n)){
            return true;
        } else {
            return false;
        }
    }
}