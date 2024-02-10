Pedra, papel e tesoura � um cl�ssico, portanto imagino que voc� j� deva ter jogado em algum momento. Mas n�o custa nada relembrar, a regra � simples: pedra ganha da tesoura, tesoura ganha do papel e papel ganha da pedra. Nesta atividade voc� deve criar um programa que jogue Pedra, Papel e Tesoura com o usu�rio. O jogador s� pode digitar 0 (pedra), 1 (papel) ou 2 (tesoura). Imprima a mensagem �Op��o inv�lida� se n�o for nenhuma dessas op��es. Ap�s receber um valor v�lido do usu�rio voc� deve gerar aleatoriamente uma op��o para o computador e em seguida imprimir quem foi o vencedor da partida, ou se houve empate.

Para gerar um n�mero aleat�rio entre 0 e 2 em C#, voc� pode utilizar a classe Random da seguinte forma:

Random random = new Random();
// gera um n�mero aleat�rio entre 0 e 2
int numeroAleatorio = random.Next(3); 
O m�todo Next(3) da classe Random retorna um n�mero aleat�rio inteiro entre 0 (inclusivo) e 3 (exclusivo), ou seja, 0, 1 ou 2. � importante notar que o par�metro passado para o m�todo Next representa o limite superior do intervalo (exclusivo).

Ap�s apresentar o resultado do jogo voc� deve apresentar uma op��o para usu�rio perguntando se ele deseja continuar jogando ou finalizar o jogo.