using System;
using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;
/*
 *  acima_diagonal
    

int n, x , y;

Console.Write("Digite a ordem da matriz: ");
n = int.Parse(Console.ReadLine());


int[,] vet = new int[n,n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"Elemento [{i},{j}]: ");
        vet[i,j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        Console.Write(vet[i,j]+ " ");
    }
    Console.WriteLine(" ");
}
*/

/*
 * 
 *  diagonal_negativos
 * 
int n, x, y;

Console.Write("Digite a ordem da matriz: ");
n = int.Parse(Console.ReadLine());


int[,] vet = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"Elemento [{i},{j}]: ");
        vet[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = i; j == i; j++)
    {
        Console.Write(vet[i, j] + " ");
    }
    Console.WriteLine(" ");
}

*/
/*
Problema "soma_linhas" 

int m, n;

Console.Write("quantas linhas: ");
m = int.Parse(Console.ReadLine());
Console.Write("quantas colunas: ");
n = int.Parse(Console.ReadLine());

int[,] vet = new int[m,n];

for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Digite os elementos da{m}a. linha:");
    for (int j = 0; j < n; j++)
    {
        vet[i,j] = int.Parse(Console.ReadLine());
    }
}


Console.WriteLine("Vetor gerado");
for (int i = 0; i < m; i++)
{
    int soma = 0;
    for (int j = 0; j < n; j++)
    {
        soma = soma + vet[i,j];
    }
    Console.WriteLine(soma);
}

*/

/*
 * 
 * Problema "negativos_matriz"
 * 
int m, n;

Console.Write("Linhas: ");
m = int.Parse(Console.ReadLine());
Console.Write("Colunas: ");
n = int.Parse(Console.ReadLine());

int[,] vet = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.WriteLine($"Elemento[{i},{j}]");
        vet[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Valores negativos");
for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        if (vet[i,j] < 0)
        {
            Console.WriteLine(vet[i, j]);
        }
    }
}

*/

/*
 * 
 * Problema "cada_linha" 
 * 

int m, l= 0;

Console.WriteLine("Qual a ordem da matriz");
m = int.Parse(Console.ReadLine());

int[,] vet = new int[m,m];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"Elemento[{i},{j}]: ");
        vet[i,j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0;i < m; i++)
{
    for(int j = 0;  j < m; j++)
    {
        l = l + vet[i,j];
    }
    Console.WriteLine(l);
    l = 0;
}

*/

/*
 * 
 * Problema "soma_matrizes" 

 * 

int m, n;

Console.WriteLine("Quantas linhas vai ter cada matriz? ");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Quantas colunas vai ter cada matriz? ");
n = int.Parse(Console.ReadLine());

int[,] vet = new int[m, n];
int[,] vet2 = new int[m, n];
int[,] vet3 = new int[m, n];


Console.WriteLine("Digite os valores da matriz A");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.WriteLine($"Elemento[{i},{j}]");
        vet[i,j] = int.Parse(Console.ReadLine());
    }
}


Console.WriteLine("Digite os valores da matriz B");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.WriteLine($"Elemento[{i},{j}]");
        vet2[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Matriz soma");
for (int i = 0;i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        vet3[i,j] = vet[i,j];
    }
}

for (int i =0; i < m; i++)
{
    for(int j = 0;j < n; j++)
    {
        vet3[i,j] = vet3[i,j] + vet2[i,j];
    }
}

for (int i = 0;i < m; i++)
{
    for(int j = 0;j < n; j++)
    {
        Console.Write(vet3[i,j] + " ");
    }
    Console.WriteLine(" ");
}

*/

Action jump = () => Console.WriteLine(" ");

int m, l, c;

Console.Write("Qual a ordem da matriz? ");
m = int.Parse(Console.ReadLine());


float[,] vet = new float[m,m];

float positives = 0;

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < m; j++)
    {
        Console.Write($"Elemento [{i},{j}] ");
        vet[i, j] = float.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (vet[i, j] > 0)
        {
            positives = positives + vet[i, j];
        }
    }
}

Console.WriteLine("SOMA DOS POSITIVOS: " + positives.ToString("F1" , CI));

jump();

Console.WriteLine("Escolha uma linha: ");
l = int.Parse(Console.ReadLine());

for (int i = l ;i == l; i++)
{
    Console.Write("Linha escolhida: ");
    for (int j = 0; j < m; j++)
    {
        Console.Write(vet[i,j].ToString("F1", CI) + " ");
    }
}

jump();
jump();
Console.WriteLine("Escolha uma coluna: ");
c = int.Parse(Console.ReadLine());


Console.Write("Coluna escolhida: ");
for (int i = 0; i < m; i++)
{
    for (int j = c; j == c; j++)
    {
        Console.Write(vet[i, j].ToString("F1", CI) + " ");
    }
}

jump();
jump();

Console.Write("Diagonal principal: ");
for (int i = 0; i < m; i++)
{
    for (int j = i; j == i; j++)
    {
        Console.Write(vet[i, j].ToString("F1" , CI) + " ");
    }
}

jump();
jump();

Console.WriteLine("Matriz alterada: ");

float squad = 0;

for (int i = 0;i < m; i++)
{
    for(int j = 0; j < m; j++)
    {
        if (vet[i, j] < 0)
        {
            squad = vet[i,j] * vet[i,j];
            vet[i,j] = squad;
        }
        Console.Write(vet[i, j].ToString("F1", CI) + " ");
    }
    Console.WriteLine(" ");
}