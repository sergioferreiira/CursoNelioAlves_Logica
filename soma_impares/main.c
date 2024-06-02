#include <stdio.h>
#include <stdlib.h>

int main()
{
    int x,y, impares, troca;

    printf("Digite dois numeros e vamos mostrar a soma dos numeros impares entre eles:\n");
    scanf("%d %d", &x, &y);

    if(x > y){
        troca = x;
        x = y;
        x = troca;
    }

    impares = 0;
    for(x = x; x < y; x++){
        if (x % 2 == 0){
        }
        else{
            impares = impares + x;
        }

    }
    printf("A soma dos impares e: %d", impares);




    return 0;
}
