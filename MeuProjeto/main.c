#include <stdio.h>
#include <string.h>

int main()
{

    int x;
    int y;
    int resultado ;

    printf("Digite o primeiro numero: ");
    scanf("%i", &x);
    printf("Digite o segundo numero: ");
    scanf("%i", &y);


    resultado = x + y;
    printf("O resultado da soma dos dois numeros e: %i \n", resultado);

    printf("O primeiro valor digitado e maior que o segundo? \n");

    if (x > y){
        printf("O valor do primeiro numero e %i que e maior que o segundo", x);
    }
    else{
        printf("O valor do resultado nao e maior");
    }

    return 0;
}
