#include <stdio.h>
#include <stdlib.h>

int main()
{

    int n, x , resultado;

    printf("Deseja a tabuada pra qual valor? ");
    scanf("%d", &x);

    for(n = 1; n < 11; n++){
        resultado = x * n;
        printf("%d x %d = %d \n", x , n , resultado);
    }


    return 0;
}
