#include <math.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

// e^x = somatorio(xˆn/n!)

int main(void) {
  int N = 5, x = 1, nFatorial = 1;
  double e = 1;

  for (int n = 1; n <= N; n++) {
    nFatorial *= n;
    e += pow(x, n) / nFatorial;
    printf("Somatoria de n = %d: %d\n", n, nFatorial);
  }

  printf("\n\nValor obtido de eˆ%d: %lf", x, e);
  printf("\nValor esperado de eˆ%d: %lf", x, pow(M_E, x));
  printf("\n\nErro absoluto: %lf", e - pow(M_E, x));
  printf("\nErro relativo: %lf", (e - pow(M_E, x)) / pow(M_E, x));

  return 0;
}