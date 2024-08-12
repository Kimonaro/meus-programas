// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Calculadora");


//teste da soma
void soma(float a, float b){
   
    float x = a + b;
    Console.WriteLine($"{a} + {b} = {x}");

}



//subtração
void subtracao(float a, float b){
   
    float x = a - b;
    Console.WriteLine($"{a} - {b} = {x}");

}


//multiplicação
void multiplicacao(float a, float b){
   
    float x = a * b;
    Console.WriteLine($"{a} * {b} = {x}");

}


//divisão
void divisao(float a, float b){
    if(b == 0){
        Console.WriteLine("erro da divisão");
        return;
    }
    float x = a / b;
    Console.WriteLine($"{a} / {b} = {x}");

}

//variaveis globais
float a;
float b;

void variavel(){
    Console.WriteLine("digite a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("digite b:");
    b = float.Parse(Console.ReadLine());
}

//menu
Console.WriteLine("---- CALCULARA -----");
Console.WriteLine("|1 - Adição        |");
Console.WriteLine("|2 - Subtração     |");
Console.WriteLine("|3 - Multiplacação |");
Console.WriteLine("|4 - Divisão       |");
Console.WriteLine("|5 - Sair          |");
Console.WriteLine("--------------------");
Console.WriteLine("escreva aqui------>:");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){

Console.WriteLine("soma");
    variavel();
    soma(a,b);
}

else if(opcao == 2){

 Console.WriteLine("subtracao");
    variavel();
    subtracao(a,b);

}

else if(opcao == 3){

 Console.WriteLine("multiplicacao");
    variavel();
    multiplicacao(a,b);

}

else if(opcao == 4){

 Console.WriteLine("divisao");
    variavel();
    divisao(a,b);

}

else if(opcao == 5){
Console.WriteLine("saindo...");

}
else{
    Console.WriteLine("opção invalida!");
}


































































































































































































































































































































































































































































































































































































