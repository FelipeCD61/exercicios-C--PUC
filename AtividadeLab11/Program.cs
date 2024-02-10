/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descricao: Análise de Vetores.
Entrada: Um némero entre 0 e 10.
Saida: O vetor, seu maior e menor valor, primeira ocorrência do valor digitado,
todas as posições em que aparece e quantas vezes.
-----------------------------------------------*/
using System;
using System.Text;
class Program {
   public static void Main (String[] args){

   string sentenceOne = "", sentenceTwo = "", subSentence = "", newSentenceTwo = "";
   char caracterOne = ' ', caracterTwo = ' ', op = ' ';

    while(true){

        Console.WriteLine("\n\nO que deseja fazer? Digite a letra de uma das opções");
        Console.WriteLine("(a) Digite uma frase ou palavra de no máximo 20 caracteres");
        Console.WriteLine("(b) Imprimir o tamanho da da sentença");
        Console.WriteLine("(c) Digite uma nova sentença e compare com a primeira");
        Console.WriteLine("(d) Imprimir as duas sentenças juntas");
        Console.WriteLine("(e) Imprimir a primeira sentença de forma reversa");
        Console.WriteLine("(f) Digite um caracter para contar quantas vezes aparece na primeira sentença");
        Console.WriteLine("(g) Substituir um caracter por um outro caracter na primeira sentença");
        Console.WriteLine("(h) Verificar se uma nova sentença está contida na primeira sentença");
        Console.WriteLine("(i) Retornar uma sentença contida na primeira sentença"); 
        Console.WriteLine("(q) Para sair do programa");
        Console.WriteLine("___________________________________________________________________________________________________");
        op = (Console.ReadLine()[0]);

        if(op == 'q'){
            break;
        }

        switch (op){
            case 'a':
            Console.WriteLine("Digite:");
            while (true){
                sentenceOne = (Console.ReadLine());
                if(sentenceOne.Length > 20){
                    Console.WriteLine("\nPor favor digite uma sentença com menos de 20 caracteres."); 
                    continue;
                } else {
                    break;
                }
            }
            break;

            case 'b':
            if(sentenceOne == ""){
                Console.WriteLine("Por favor selecione a opção 'a' para está opção funcionar.");
                continue;
            }
            Console.WriteLine($"O tamanho da sentença digitada é {sentenceOne.Length}");
            break;

            case 'c':
            if(sentenceOne == ""){
                Console.WriteLine("Por favor selecione a opção 'a' para está opção funcionar.");
                continue;
            }
            Console.WriteLine("Digite:");
            while (true){
                sentenceTwo = (Console.ReadLine());
                if(sentenceTwo.Length > 20){
                    Console.WriteLine("Por favor digite uma sentença com menos de 20 caracteres."); 
                    continue;
                } else {
                    break;
                }
            }
            int contA = sentenceOne.Length;
            int contB = sentenceTwo.Length;
                    
            Console.WriteLine($"A primeira sentença tem {contA} caracteres e a escrita tem {contB}");
            break;

            case 'd':
            if(sentenceOne == ""){
                Console.WriteLine("Por favor selecione a opção 'a' para está opção funcionar.");
                continue;
            }
            if(sentenceTwo == ""){
                Console.WriteLine("Por favor selecione a opção 'c' para está opção funcionar.");
                continue;
            }
            Console.WriteLine($"{sentenceOne} " + $"{sentenceTwo}");
            break;

            case 'e':
            if(sentenceOne == ""){
                Console.WriteLine("Por favor selecione a opção 'a' para está opção funcionar.");
                continue;
            }
            for (int i = 0; i < sentenceOne.Length; i++){
                System.Console.Write(sentenceOne[sentenceOne.Length - i - 1]);
            }
            break;

            case 'f':
            if(sentenceOne == ""){
                Console.WriteLine("Por favor selecione a opção 'a' para está opção funcionar.");
                continue;
            }
            int cont=0;
            Console.WriteLine("Digite um caracter:");
            caracterOne = (Console.ReadLine()[0]);
            for(int i=0; i<sentenceOne.Length; i++){
                if(caracterOne == sentenceOne[i]){
                    cont++;
                }
            }
            Console.WriteLine($"O caracter '{caracterOne}' aparece {cont} vez(es).");
            break;

            case 'g':
            if(sentenceOne == ""){
                Console.WriteLine("Por favor selecione a opção 'a' para está opção funcionar.");
                continue;
            }
            string modified;
            char caracter;
            StringBuilder sb = new StringBuilder(sentenceOne);
            Console.WriteLine("Digite o caracter que deseja substituir:");
            caracter = (Console.ReadLine()[0]);            
            Console.WriteLine("Digite o caracter:");
            caracterTwo = (Console.ReadLine()[0]);
            for(int i=0; i<sentenceOne.Length; i++){
                if(caracter == sentenceOne[i]){
                    sb[i] = caracterTwo;
                }
            }
            modified = sb.ToString();
            Console.WriteLine(modified);
            break;

            case 'h':
            if(sentenceOne == ""){
                Console.WriteLine("Por favor selecione a opção 'a' para está opção funcionar.");
                continue;
            }
            Console.WriteLine("Digite:");
            newSentenceTwo = (Console.ReadLine());
            bool check = sentenceOne.Contains(newSentenceTwo);
            if(check == true) {
            Console.WriteLine("'{0}' está contida na sentença '{1}'", newSentenceTwo, sentenceOne);
            }
            break;

            case 'i':
            if(sentenceOne == ""){
                Console.WriteLine("Por favor selecione a opção 'a' para está opção funcionar.");
                continue;
            }
            int a,b;
            Console.WriteLine("Digite a posição que começa a substring(Contando os espaços):");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho da substring:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(sentenceOne.Substring( a - 1 , b)); //Coloquei menos 1 pois um usuário leigo não sabe que a contagem começa do zero
            break;

            default:
            Console.WriteLine("Por favor digite uma das opções.");
            break;
        }
    }
 }   
}