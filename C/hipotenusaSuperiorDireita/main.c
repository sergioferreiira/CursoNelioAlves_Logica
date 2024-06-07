#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Hello world!\n");

    int l, c, mt;
    printf("Qual sera o valor das linhas e colunas dessa matriz? ");
    scanf("%d", &mt);

    int mat[mt][mt];
    for(l = 0; l < mt; l++)
    {
        for(c = 0; c < mt; c++)
        {
            printf("Qual o valor da matriz linha %d coluna %d : ", l, c);
            scanf("%d", &mat[l][c]);
        }
    }

    printf("\n");
    for(l = 0; l < mt; l++)
    {
        for(c = 0; c < mt; c++)
        {
            printf("%d ", mat[l][c]);
        }
        printf("\n");
    }

    printf("\n");
    printf("A coleta da hipotenusa superior direita eh\n");
    printf("\n");

    for(l = 0; l < mt; l++)
    {
        for(c = l; c < mt; c++)
        {
            printf("%d ", mat[l][c]);
        }
        printf("\n");
    }
    return 0;
}
