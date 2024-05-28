#include <stdio.h>

int main(){

    int x , y;

    printf("Digite quantos numeros deseja guardar: ");
    scanf("%i", &x);

    double vet[x];

    for (y = 0; y < x; y++){
        printf("Digite os numeros que serao salvos no vetor: ");
        scanf("%lf", &vet[y]);
    }
    printf("\n Os numeros digitados foram: \n");
    for(y = 0 ; y < x ; y++){
        printf("%.2lf \n", vet[y]);
    }
    return 0;
}
