Pedra, papel e tesoura é um clássico, portanto imagino que você já deva ter jogado em algum momento. Mas não custa nada relembrar, a regra é simples: pedra ganha da tesoura, tesoura ganha do papel e papel ganha da pedra. Nesta atividade você deve criar um programa que jogue Pedra, Papel e Tesoura com o usuário. O jogador só pode digitar 0 (pedra), 1 (papel) ou 2 (tesoura). Imprima a mensagem “Opção inválida” se não for nenhuma dessas opções. Após receber um valor válido do usuário você deve gerar aleatoriamente uma opção para o computador e em seguida imprimir quem foi o vencedor da partida, ou se houve empate.

Para gerar um número aleatório entre 0 e 2 em C#, você pode utilizar a classe Random da seguinte forma:

Random random = new Random();
// gera um número aleatório entre 0 e 2
int numeroAleatorio = random.Next(3); 
O método Next(3) da classe Random retorna um número aleatório inteiro entre 0 (inclusivo) e 3 (exclusivo), ou seja, 0, 1 ou 2. É importante notar que o parâmetro passado para o método Next representa o limite superior do intervalo (exclusivo).

Após apresentar o resultado do jogo você deve apresentar uma opção para usuário perguntando se ele deseja continuar jogando ou finalizar o jogo.