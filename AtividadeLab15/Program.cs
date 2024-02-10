/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descrição: Estoque de produtos.
Entrada: Alterações do estoque.
Saída: Cadastrar, listar, editar, pesquisar e apagar produtos.
-----------------------------------------------*/
using System;
class Program{
    static string[] Estoque = new string[100];
    static int N = 0;

    static void CadastraProduto(){
        Console.WriteLine("Digite o nome do produto: ");
        Estoque[N] = Console.ReadLine();
        N++;
    }

    static void ListaProdutos(){
        Console.WriteLine($"Quantidade de Produtos: {N}");
        for(int i=0; i<N;i++){
            Console.WriteLine($"{i+1} - {Estoque[i]}");
        }
    }

    static void EditaProduto(){
        Console.WriteLine("Digite o nome do produto:");
        int i = searchName(Estoque);

        if(i == -1){
        Console.WriteLine("Produto não encontrado!");
        } else {
        Console.WriteLine($"Digite o novo nome do produto:");
        string nome = Console.ReadLine();
        Estoque[i] = nome;
        }
    }

    static void PesquisaProduto(){
        Console.WriteLine("Digite o nome do produto:");
        int i = searchName(Estoque);

        if(i == -1){
            Console.WriteLine("Produto não cadastrado!");
        } else {
            Console.WriteLine($"Produto {Estoque[i]} cadastrado.");
            }
    }

    static void ApagaProduto(){
        Console.WriteLine("Digite o nome do produto:");
        int i = searchName(Estoque);

        if(i == -1){
            Console.WriteLine("Produto não cadastrado!");
        } else {
            N--;
            Console.WriteLine($"{Estoque[i]} apagado.");
            for(int x=i;x<N;x++){
                Estoque[i] = Estoque[i+1];
            }
        }
    }

    static int searchName(string[] v){
        string nome = Console.ReadLine();
        for(int i=0;i<v.Length;i++){
            if(v[i]==nome){
                return i;
                break;
            }
        }
        return -1;
    }

    static int Menu(){
        Console.WriteLine(" =====> ESTOQUE DE PRODUTOS <=====");
        Console.WriteLine("1 - Cadastrar novo Produto");
        Console.WriteLine("2 - Listar");
        Console.WriteLine("3 - Editar");
        Console.WriteLine("4 - Pesquisar");
        Console.WriteLine("5 - Apagar");
        Console.WriteLine("6 - Sair");
        Console.WriteLine("");
        int opcao = int.Parse(Console.ReadLine());
        return opcao;
    }
            
    public static void Main (String[] args) {
        int op;
        do{
            Console.Clear();
            op = Menu();
            switch(op){
            case 1: CadastraProduto();
            break;
            case 2: ListaProdutos();
            break;
            case 3: EditaProduto();
            break;
            case 4: PesquisaProduto();
            break;
            case 5: ApagaProduto();
            break;
            case 6:
            Console.WriteLine("Progama fechado.");
            break;
            }
            if(op != 6){
                Console.WriteLine("\nAperte 'enter' pra continuar...");
                Console.ReadKey();
            }
        }while(op != 6);
    }
}