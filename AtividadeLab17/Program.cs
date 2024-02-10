/*-----------------------------------------------
PUCMINAS-Contagem-Disciplina:ATP
Programador: Felipe Claver Diniz
Descrição: Estoque de produtos.
Entrada: Alterações do estoque.
Saída: Cadastrar, listar, editar, pesquisar e apagar produtos.
-----------------------------------------------*/
using System;
using System.IO;
class Program{
    static Produto[] Estoque = new Produto [100];
    static int N = 0;

    static void CadastraProduto(){
        if (N >= 100){
            Console.WriteLine("Estoque cheio!");
            return;
        }

        Produto novoProduto = new Produto(N);

        Console.WriteLine("Digite o nome do produto: ");
        string name = Console.ReadLine();

        if (!ValidaProduto(name)) return;

        novoProduto.SetName(name);
        novoProduto.SetID(N);

        Console.WriteLine("Digite a quantidade do produto: ");
        novoProduto.SetAmount(int.Parse(Console.ReadLine()));

        Console.WriteLine("Digite o preço do produto: ");
        novoProduto.SetPrice(double.Parse(Console.ReadLine()));

        Estoque[N] = novoProduto;
        N++;
    }
   
    static bool ValidaProduto(string name){
   
        for (int i=0;i<N;i++){
            if(Estoque[i] != null && Estoque[i].GetName() == name){
                Console.WriteLine("Produto já cadastrado.");
                return false;
            }
        }
        return true;
    }

    static void EditaProduto(){
        Console.WriteLine("Digite o código do produto:");
        int i = searchID(Estoque);
        if(i== -1){
            Console.WriteLine("Produto não encontrado!");
        } else {
            PrintProduto(Estoque[i]);

            Console.WriteLine($"\nDigite o novo nome do produto:");
            string nome = Console.ReadLine();
            if (!ValidaProduto(nome)) return;
            Estoque[i].SetName(nome);

            Console.WriteLine("Digite a nova quantidade do produto: ");
            Estoque[i].SetAmount(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o novo preço do produto: ");
            Estoque[i].SetPrice(double.Parse(Console.ReadLine()));
        }
    }

    static void ListaProdutos(){
        Console.WriteLine($"\nQuantidade de Produtos: {N}");
        for(int i=0;i<N;i++){
            PrintProduto(Estoque[i]);
        }
    }        
       
    static void PrintProduto (Produto product){
        Console.WriteLine($"\nCódigo: {product.GetID()}");
        Console.WriteLine($"Nome: {product.GetName()}");
        Console.WriteLine($"Quantidade: {product.GetAmount()}");
        Console.WriteLine($"Preço: {product.GetPrice()}");
    }

    static void PesquisaProdutoNome(){
        Console.WriteLine("Digite o nome do produto:");
        int i = searchName(Estoque);
       
        if(i == -1){
            Console.WriteLine("Produto não cadastrado!");
        } else {
            Console.WriteLine($"Produto {Estoque[i].GetName()} cadastrado.");
            PrintProduto(Estoque[i]);
        }
    }

    static void PesquisaProdutoID(){
        Console.WriteLine("Digite o código do produto:");
        int i = searchID(Estoque);
       
        if(i == -1){
            Console.WriteLine("Produto não cadastrado!");
        } else {
            Console.WriteLine($"Produto {Estoque[i].GetID()} cadastrado.");
            PrintProduto(Estoque[i]);
        }
    }

    static void ApagaProduto(){
        Console.WriteLine("Digite o código do produto:");
        int i = searchID(Estoque);
        if(i == -1){
            Console.WriteLine("Produto não cadastrado!");
        } else {
            Console.WriteLine($"{Estoque[i].GetID()} - {Estoque[i].GetName()} apagado.");
            N--;
            for(int x=i;x<N; x++){
                Estoque[x+1].SetID(x); //Após apagar e criar um novo produto, ele vinha com o id igual ao anterior
                Estoque[x] = Estoque[x+1];
                //Ou seria melhor não alterar os ids e criar o id do novo produto com o último de referência?
            }
        }
    }

    static int searchID(Produto[] v){
        int id = int.Parse(Console.ReadLine());
        for(int i=0;i<v.Length;i++){
            if(v[i].GetID()==id){
                return i;
                break;
            }
        }
        return -1;
    }

    static int searchName(Produto[] v){
        string nome = Console.ReadLine();
        for(int i=0;i<v.Length;i++){
            if(v[i].GetName()==nome){
                return i;
                break;
            }
        }
        return -1;
    }

    static void Lista_10(){
        for(int i=0;i<=N;i++){
            if(Estoque[i] != null && Estoque[i].GetAmount() < 10){
                PrintProduto(Estoque[i]);
            }
        }
    }

    static int Menu(){
        Console.WriteLine("=====> ESTOQUE DE PRODUTOS <=====");
        Console.WriteLine("1 - Cadastrar novo Produto");
        Console.WriteLine("2 - Listar");
        Console.WriteLine("3 - Editar");
        Console.WriteLine("4 - Pesquisar por nome");
        Console.WriteLine("5 - Pesquisar por código");
        Console.WriteLine("6 - Listar todos os produtos com estoque inferior a 10");
        Console.WriteLine("7 - Apagar");
        Console.WriteLine("8 - Sair");
        Console.WriteLine("");
        int opcao = int.Parse(Console.ReadLine());
        return opcao;
    }

    public static void Main (string[] args) {
        LoadFile();
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
            case 4: PesquisaProdutoNome();
            break;
            case 5: PesquisaProdutoID();
            break;
            case 6: Lista_10();
            break;
            case 7: ApagaProduto();
            break;
            case 8:
            Console.WriteLine("Progama fechado.");
            break;
            }  
            if(op != 8){
                Console.WriteLine("\nAperte 'enter' pra continuar...");
                Console.ReadKey();
            }
        }while(op!= 8);
        Save();
    }

    static void Save(){
        StreamWriter sw = new StreamWriter("Estoque.txt");
        for(int i=0;i<N;i++){
            sw.WriteLine($"{Estoque[i].GetID()};{Estoque[i].GetName()};{Estoque[i].GetAmount()};{Estoque[i].GetPrice()};");
        }
        sw.Close();
    }

    static void LoadFile(){
        StreamReader sr = new StreamReader("Estoque.txt");
        string line;
        int j=0;
        
        while ((line = sr.ReadLine()) != null){
            string[] subs = line.Split(';');
            
            Estoque[j] = new Produto((int.Parse(subs[0])));
            Estoque[j].SetName(subs[1]);
            Estoque[j].SetAmount(int.Parse(subs[2]));
            Estoque[j].SetPrice(double.Parse(subs[3]));

            j++;
        }

        N=j;
        sr.Close();
    }
}

class Produto{
    private int id;
    private string name;
    private double price;
    private int amount;

    public Produto(int id){
        this.id = id;
    }

    public int GetID(){
        return id;
    }
    public void SetID(int id){
        this.id = id;
    }

    public string GetName(){
        return name;
    }
    public void SetName(string name){
        this.name = name;
    }

    public double GetPrice(){
        return price;
    }
    public void SetPrice(double price){
        this.price = price;
    }

    public int GetAmount(){
        return amount;
    }
    public void SetAmount(int amount){
        this.amount = amount;
    }
}