/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descrição: Utilização de funções para realização de operações matemáticas
Entrada: números necessários para o cálculo
Saída: média de 2 números, fatorial de um número, cálculo exponencial, 
seno, cosseno, raiz quadrada de um número e cálculo de logaritmo.
-----------------------------------------------*/
using System;
class Program {
    public static void Main (String[] args){
        string opcao;
        bool exit;
        do{
        Menu();
        opcao = readMenu();
        exit = choseOption(ref opcao);
        if(exit==false){
            break;
        } else{
            backMenu();
        }
        }while(true);

    }
    static void Menu(){
        string espace= ""; //Criei essa string para facilitar a modelagem do Menu
        Console.WriteLine("\n################################################");
        Console.WriteLine("##{0,-13}Programa Matemático{1,-12}##", espace, espace);
        Console.WriteLine("##{0,-44}##", espace);
        Console.WriteLine("##{0,-5}Selecione a opção desejada:{1,-12}##", espace,espace);
        Console.WriteLine("##{0,-44}##", espace);
        Console.WriteLine("##{0,-6}1 - Calcula Média entre dois números  ##",espace);
        Console.WriteLine("##{0,-6}2 - Calcula Fatorial de um número{1,-5}##",espace,espace);
        Console.WriteLine("##{0,-6}3 - Calcula o Exponencial{1,-13}##",espace,espace);
        Console.WriteLine("##{0,-6}4 - Calcula o Seno{1,-20}##",espace,espace);
        Console.WriteLine("##{0,-6}5 - Calcula o Cosseno{1,-17}##",espace,espace);
        Console.WriteLine("##{0,-6}6 - Calcula a Raiz quadrada{1,-11}##",espace,espace);
        Console.WriteLine("##{0,-6}7 - Calcula logaritmo{1,-17}##",espace,espace);
        Console.WriteLine("##{0,-44}##",espace);
        Console.WriteLine("##{0,-6}x - Sair{1,-30}##",espace,espace);
        Console.WriteLine("##{0,-44}##",espace);
        Console.WriteLine("################################################");
    }

    static string readMenu(){
        string op;

        while (true){
            op = (Console.ReadLine());
            if(op!="1"&&op!="2"&&op!="3"&&op!="4"&&op!="5"&&op!="6"&&op!="7"&& !string.Equals(op, "x", StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine("Por favor, digite uma das opções mostradas:");
                continue;
            } else{
                break;
            }
        }
        return op;
    }

    static bool choseOption(ref string option){
        switch (option){
            
            case "1":
            double n1, n2;
            Console.WriteLine("Digite dois números:");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: {0}", media(n1, n2));
            return true;
            break;
            
            case "2":
            double num0;
            Console.WriteLine("Digite um número:");
            num0 = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: {0}",  fatorial(num0));
            return true;
            break;
            
            case "3":
            double num1, expoente;
            Console.WriteLine("Digite um número:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            expoente = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: {0:f2}", exponencial(num1, expoente));
            return true;
            break;
            
            case "4":
            double num2;
            Console.WriteLine("Digite um número:");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: {0:f2}", seno(num2));
            return true;
            break;
            
            case "5":
            double num3;
            Console.WriteLine("Digite um número:");
            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: {0:f2}", cosseno(num3));
            return true;
            break;
            
            case "6":
            double num4;
            Console.WriteLine("Digite um número:");
            num4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: {0:f2}", raiz(num4));
            return true;
            break;
            
            case "7":
            double num5, logBase;
            Console.WriteLine("Digite um número:");
            num5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base do logaritmando:");
            logBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: {0:f2}", logaritmo(num5, logBase));
            return true;
            break;

            case "x" when option.Equals("x", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("Você saiu do programa.");
            return false;
            break;

            default:
            return true;
            break;
        }
    }

    static void backMenu(){
        char answer;
        Console.WriteLine("\nDigite 'm' para retornar à tela inicial:");
        do{
            answer = (Console.ReadLine()[0]);
            if(char.ToLower(answer) != 'm'){
                Console.WriteLine("Por favor, digite 'm':");
            }
        }while(answer!='m');

    }

    static double media(double n1, double n2){
        double result;
        result = (n1+n2)/2;
        return result;
    }

    static double fatorial(double n){
        double result=1;
        for (int i = 1; i <= n; i++){
            result *= i;
        }
        return result;
    }
    
    static double exponencial(double n, double exp){
        double result;
        result = Math.Pow(n,exp);
        return result;
    }
    
    static double seno(double n){
        double result;
        result = Math.Sin(n);
        return result;
    }

    static double cosseno(double n){
        double result;
        result = Math.Cos(n);
        return result;
    }

    static double raiz(double n){
        double result;
        result = Math.Sqrt(n);
        return result;
    }

    static double logaritmo(double n, double lB){
        double result;
        result = Math.Log(n,lB);
        return result;
    }
}
