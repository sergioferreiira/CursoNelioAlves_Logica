#include <stdio.h>
#include <stdlib.h>

int main()
{
    double lt, ct, vmt, at, areaDoTerreno, precoDoTerreno;


    printf("Digite a largura do terreno: \n");
    scanf("%lf", &lt);
    printf("Digite o comprimento do terreno: \n");
    scanf("%lf", &ct);
    printf("Digite o valor do metro quadrado do terreno: \n");
    scanf("%lf", &vmt);


    areaDoTerreno = lt * ct;
    printf("A area do do terreno e de %.2lf \n", areaDoTerreno);

    precoDoTerreno = areaDoTerreno * vmt;
    printf("O preco do terreno e de : %.2lf", precoDoTerreno);

    return 0;
}
