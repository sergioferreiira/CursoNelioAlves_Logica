#include <stdio.h>
#include <stdlib.h>

int main()
{
    int l, c;

    printf("Qual a quantidade de linhas da matriz: \n");
    scanf("%d", &l);
    printf("Qual a quantidade de colunas da matriz: \n");
    scanf("%d", &c);


    double mat[l][c];
    double vet[l];

    for (int i = 0; i < l; i++)
    {
        printf("Digite os elementos da %da. linha: \n", i + 1);
        for(int j = 0; j < c; j++)
        {
            scanf("%lf", &mat[i][j]);
        }
    }
    for (int i = 0; i < l; i++)
    {
        vet[i] = 0;
        for(int j =0; j < c; j++){
            vet[i] = vet[i] + mat[i][j];
        }
    }

    printf("Declaracao do vetor: \n");

    for (int i = 0; i < l; i++)
    {
        printf("%.1lf \n", vet[i]);
    }


    return 0;
}
