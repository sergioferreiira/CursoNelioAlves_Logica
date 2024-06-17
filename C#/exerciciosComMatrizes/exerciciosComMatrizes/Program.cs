using System;

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