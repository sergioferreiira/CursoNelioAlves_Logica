#include <stdio.h>

int main()
{
    int N, i , x , soma;

    printf("Digite o primeiro numero: ");
    scanf("%i", &N);

    soma = 0;
    for (i = 0; i < N; i++) {
        printf("Digite um numero: ");
        scanf("%i", &x);
        soma = soma + x;
    }

    printf("A soma dos valores e: %i", soma);

    return 0;
}
