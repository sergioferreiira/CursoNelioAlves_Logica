#include <stdio.h>
#include <stdlib.h>

int main()
{

    char nome1[50],nome2[50];
    double idade1 , idade2 , media;

    printf("Digite os dados da primeira pessoa\n");
    scanf("%s", nome1);
    scanf("%lf", &idade1);
    printf("Digite os dados da segunda pessoa\n");
    scanf("%s", nome2);
    scanf("%lf", &idade2);

    media = (idade1 + idade2) / 2;

    printf("A idade media de %s e %s eh de %.1lf",nome1,nome2,media);

    return 0;
}
