#include <stdio.h>


int main()
{

    int L, C, NL, NC;


    printf("Quantas linhas vai ter sua matriz? ");
    scanf("%d", &L);
    printf("Quantas colunas vai ter sua matriz? ");
    scanf("%d", &C);

    int mat[L][C];

    for(NL = 0; NL < L; NL++)
    {
        for(NC = 0; NC < C; NC++)
        {
            printf("Digite o numero a ser salvo na matriz[%d , %d] :", NL, NC);
            scanf("%d", &mat[NL][NC]);
        }
    }


    for(NC = 0; NC < C; NC++)
    {
        printf("%d ", mat[NC][NC]);
    }

    return 0;
}
