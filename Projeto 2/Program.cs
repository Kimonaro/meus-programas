 bool resposta()
 {
    iniciopergunta:
    string resposta = Console.ReadLine();

    if(resposta == "s")
    {
        return true;
    }
    else if(resposta == "n")
    {
        return false;
    }
    else
    {
        Console.WriteLine("não entendi, responda apenas s/n:");
        goto iniciopergunta;
    }
 }


//Inicialização
Console.WriteLine("quer jogar um jogo? s/n");
if(resposta() == false)
{
    goto FinalJogo;
}

inicioJogo:

int menor = 0;
int maior = 100;
int numTentativas = 10;
bool jogorodando = true;

Random rand = new Random();
int sorteado = rand.Next(menor, maior +1);
Console.WriteLine($"pensei em um número entre {menor} e {maior}. tente adivinhar!");


while(jogorodando) //loop de jogo
{
    Console.WriteLine($"Tentagtiva {numTentativas}: ");
    int numDigitado = int.Parse(Console.ReadLine());
    if(numDigitado < sorteado)
    {
        Console.WriteLine("muito baixo. Tente novamente.");
        numTentativas--;
    }
    else if(numDigitado > sorteado)
    {
        Console.WriteLine("muito alto. Tente novamente.");
        numTentativas--;
    }
    else
    {
         Console.WriteLine("Parabéns! você acertou!");
         jogorodando = false;
    }
    if(numTentativas == 0)
    {
        Console.WriteLine($"acabaram suas tentativas. o número que pensei era {sorteado}.");
        jogorodando = false;
    }
}


//finalização
Console.WriteLine("quer jogar de novo? s/n");
if(resposta() == true)
{
    goto inicioJogo;
}

FinalJogo:
Console.WriteLine("Então até a próxima!");