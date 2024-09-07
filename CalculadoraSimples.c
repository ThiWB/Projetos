// Algoritmo de uma calculadora simples com 4 operações básicas
// Autor: ThiWB
// Data: 06/09/2024

#include <stdio.h>
#include <math.h>

int main() {
    float num1, num2, operacao, resultado;

    printf("Calculadora Simples com 4 operações básicas:\n\n");

    printf("Qual operação deseja realizar?\n\n");
    printf("1 - SOMA\n");
    printf("2 - SUBTRAÇÃO\n");
    printf("3 - MULTIPLICAÇÃO\n");
    printf("4 - DIVISÃO\n\n");
    scanf("%f", &operacao);

    printf("Digite o primeiro número: \n");
    scanf("%f", &num1);

    printf("Digite o segundo número: \n");
    scanf("%f", &num2);

    if (operacao == 1) {
        resultado = num1 + num2;
        printf("O resultado da soma é: %.2f\n", resultado);
    }

    else if (operacao == 2) {
        resultado = num1 - num2;
        printf("O resultado da subtração é: %.2f\n", resultado);
    }

    else if (operacao == 3) {
        resultado = num1 * num2;
        printf("O resultado da multiplicação é: %.2f\n", resultado);
    }

    else if (operacao == 4) {
        resultado = num1 / num2;
        printf("O resultado da divisão é: %.2f\n", resultado);
    }

    else {
        printf("ERRO! Tente Novamente\n");
    }

    return 0;
    

}