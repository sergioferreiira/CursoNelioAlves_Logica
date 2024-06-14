using System;
using System.Globalization;


Console.WriteLine("Hello, World!");
/**
Console.WriteLine("Escreva um numero, uma string, e um double");

int x;
string texto;
double y;


x = int.Parse(Console.ReadLine());
texto = (Console.ReadLine());
y = double.Parse(Console.ReadLine());


Console.WriteLine(x);
Console.WriteLine(texto);
Console.WriteLine(y.ToString("F2", CultureInfo.InvariantCulture));


int hora;


Console.WriteLine("Escreva que horas são");
hora = int.Parse(Console.ReadLine());


if (hora < 12)
{
    Console.WriteLine("Bom dia");
}
else
{
    Console.WriteLine("Boa noite");
}
int contador = 0;


while (contador < 12)
{
    contador++;
    Console.WriteLine(contador);
}
if (contador == 12)
{
    Console.WriteLine("O contador chegou a doze");
}
**/

/**
int n;

Console.Write("Quantos espaços ira ter o vetor: ");
n = int.Parse(Console.ReadLine());

double[] vet = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"digite um numero sendo que voce está digitando o numero considera : {i} ");
    vet[i] = double.Parse(Console.ReadLine());
}

for (int i = 0;i < n; i++)
{
    Console.WriteLine(vet[i].ToString("F2", CultureInfo.InvariantCulture));
}
**/

int m, n, x, y;

Console.Write("Quantas linhas vai ter a matriz:");
m = int.Parse(Console.ReadLine());
Console.Write("quantas colunas: ");
n = int.Parse(Console.ReadLine());

int[,] mat = new int[m, n];

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++)
    {
        Console.WriteLine($"Elemento [{i},{j})]");
        mat[i, j] = int.Parse(Console.ReadLine());

    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(mat[i,j] + " ");
    }
    Console.WriteLine();
}
