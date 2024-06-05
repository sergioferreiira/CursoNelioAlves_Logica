#include <stdio.h>
#include <math.h>

int main()
{
    double base,altura, perimetro, diagonal, area;

    printf("Qual a base do retangulo: ");
    scanf("%lf", &base);
    printf("Qual a altura do retangulo: ");
    scanf("%lf", &altura);

    area = base * altura;
    perimetro = 2 * base + 2 * altura;
    diagonal = sqrt(pow (base, 2.0) + pow(altura, 2.0 ));
    /* sqrt vem da biblioteca de math e o pow e a potencialização que deve vir seguida das chaves e valor com decimal para indicar a potencialização */
    printf("area : %.4lf\n", area);
    printf("perimetro : %.4lf\n", perimetro);
    printf("diagonal : %.4lf\n", diagonal);
    
}
