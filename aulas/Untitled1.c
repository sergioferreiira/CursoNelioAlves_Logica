#include <stdio.h>
#include <string.h>
#include <stdbool.h>

/*
Tipo Placeholder de formatação
int (inteiro 16 bits) %d ou %i
long int (inteiro 32 bits) %li
long long int (inteiro 64 bits) %lli
float (real precisão simples) %f
double (real precisão dupla) %lf
char (um único caractere) %c
char[ ] (texto) %s
*/


void limpar_entrada()
{
    char c;
    while ((c = getchar())!= '\n' && c != EOF) {}
}
void ler_texto(char *buffer, int length)
{
    fgets(buffer, length, stdin);
    strtok(buffer, "\n");
}

int main ()
{

    double salario1, salario2;
    char nome1[50], nome2[50];
    int idade1, idade2;
    char sexo;

    printf("Nome da primeira pessoa: ");
    ler_texto(nome1, 50);
    printf("Salario da primeira pessoa: ");
    scanf("%lf", &salario1);
    printf("idade da primeira pessoa: ");
    scanf("%i", &idade1);
    printf("o sexo da primeira pessoa (F/M): ");
    limpar_entrada();
    scanf("%c", &sexo);

    printf("O nome da primeira pessoa e %s, o salario dela e de %.2lf, a idade dela e %i e seu sexo e %c \n", nome1, salario1, idade1, sexo);

    printf("Nome da segunda pessoa: ");
    limpar_entrada();
    ler_texto(nome2, 50);
    printf("Salario da segunda pessoa: ");
    scanf("%lf", &salario2);
    printf("idade da segunda pessoa: ");
    scanf("%i", &idade2);
    printf("o sexo da segunda pessoa (F/M): ");
    limpar_entrada();
    scanf("%c", &sexo);


    printf("O nome da segunda pessoa e %s, o salario dela e de %.2lf, a idade dela e %i e seu sexo e %c \n", nome2, salario2, idade2, sexo);

    return 0;

}
