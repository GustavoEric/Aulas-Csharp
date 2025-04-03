#include <stdio.h>
#include <math.h> 

void calculoTintas(double tam){
    double litros = tam / 6;
    int latas = 0, galoes = 0,apenas_galoes = 0,apenas_latas = 0;

    printf("Litros necessários: %.2f\n", litros);
    litros = litros * 1.10;
    apenas_latas = ceil(litros/18);
    apenas_galoes = ceil(litros/3.6);
	latas = (int)(litros / 18);
	double sobra = fmod(litros, 18);
	galoes = ceil(sobra / 3.6); 
    printf("\nsituação 1\n");
    printf("Total de Latas (18L): %d\n", apenas_latas);
    
    printf("\nsituação 2\n");
    printf("Total de Latas (18L): %d\n", apenas_galoes);
    
	printf("\nsituação 3\n");
    printf("Total de Latas (18L): %d\n", latas);
    printf("Total de Galões (3.6L): %d\n", galoes);
}

int main(void){
    double tamanho;
    printf("Digite o tamanho em metros quadrados: ");
    scanf("%lf", &tamanho);
    calculoTintas(tamanho);
    return 0;
}

