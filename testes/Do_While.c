#include <stdio.h>


void limpar_entrada()
{
    char c;
    while ((c = getchar())!= '\n' && c != EOF) {}
}

int main()
{

    double c , f;
    char caractere;

    do
    {
    printf("Digite a temperatura eem Celsius: ");
    scanf("%lf", &c);
    f = 9.0 * c / 5.0 + 32.0;
    printf("Equivalente em Fahrenheit: %.2lf\n", f);
    printf("Deseja repetir (S/N): ");
    limpar_entrada();
    scanf("%c", &caractere);
    }while (caractere == 's' || caractere == 'S');

    return 0;


}
