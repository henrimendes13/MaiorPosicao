/*Leia 5 valores inteiros. Apresente então o maior valor lido 
e a posição dentre os 5 valores lidos.*/

int maiorValor = int.MinValue;  // Inicializa com o menor valor possível
int posicaoMaior = 0;

for (int i = 1; i <= 5; i++)
{
    int valorAtual = int.Parse(Console.ReadLine());

    if (valorAtual > maiorValor)
    {
        maiorValor = valorAtual;
        posicaoMaior = i;
    }
}

Console.WriteLine(maiorValor);
Console.WriteLine(posicaoMaior);
    