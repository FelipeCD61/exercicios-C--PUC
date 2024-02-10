Estoque de Produtos - Fase 1

Nesta atividade prática iremos iniciar o desenvolvimento de uma aplicação para gerenciar o estoque de produtos de uma empresa. 
Na primeira fase deste projeto você deve criar as operações básicas para gerenciar os dados de um produto, ou seja, as opções 
CRUD (Create, Read, Update, Delete). Você deve seguir os seguintes passos:

1. Crie um procedimento que imprima o menu do usuário e receba sua opção de seleção, o menu deve conter as seguintes operações:
  1. Cadastrar um novo produto
  2. Listar todos os produtos cadastrados
  3. Editar dados de um produto
  4. Pesquisar um produto
  5. Apagar um produto
  6. Sair do Programa
2. Crie um procedimento para cada funcionalidade do menu de opções.
3. Crie um programa principal MAIN para executar as chamadas dos procedimentos.
Cada produto possui a informação de Nome do Produto. Você deve usar vetores para armazenar as informações de produto, 
sendo que a capacidade máxima do vetor deve ser de 100 itens, contudo o usuário pode ir inserindo de um em um, de acordo 
com o desejo do usuário. Para isso iremos usar um vetor como uma coleção de dados e ir adicionando itens nesse repositório.

Veja o exemplo de código abaixo aonde a variável Estoque é declarado como escopo global da classe e não precisa ser 
passada como parâmetro nas funções:

using System;

class Program {

  static string[] Estoque = new string[100];
  static int N = 0;

  static void AdicionarProduto(){
      Console.WriteLine("Digite o nome do produto: ");
      Estoque[N] = Console.ReadLine();
      N++;
  }

  static void ListarProdutos(){
      Console.WriteLine($"Quantidade de Produtos: {N}");
      for(int i=0; i<N;i++){
         Console.WriteLine($"{i+1} - {Estoque[i]}");
      }
  }

  static int Menu(){
    Console.WriteLine(" =====> ESTOQUE DE PRODUTOS <=====");
    Console.WriteLine("1 - Cadastrar um novo Produto");
    Console.WriteLine("2 - Lista de produtos");
    Console.WriteLine("0 - Sair");
    int opcao = int.Parse(Console.ReadLine());
    return opcao;    
  }
  
  public static void Main (string[] args) {
    int op;
    do{
      Console.Clear();
      op = Menu();
      switch(op){
      case 1: AdicionarProduto();
        break;
      case 2: ListarProdutos();
        break; 
      }
      Console.ReadKey();
    }while(op != 0);
  }
}