#include <stdio.h>

int main()
{
    int l, c, mt;

    printf("Quantas linhas e colunas vão ter a matriz? ");
    scanf("%d", &mt);


    int mat[mt][mt];

    for(l = 0; l < mt; l++)
    {
        for(c = 0; c < mt; c++)
        {
            printf("Digite o numero da matriz[%d] [%d] ", l, c);
            scanf("%d", &mat[l][c]);
        }
    }


    for(c = 0; c < mt; c++)
    {      
        printf("%d ", mat[c][c]);
    }
    printf("\n");


}



