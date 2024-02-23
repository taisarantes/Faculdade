#include <stdio.h>
#include <math.h>
#include <time.h>
#include <stdlib.h>
#define SEED time(NULL)

int main(void) {
  srand( SEED );
  double pontosX, pontosY, pi, pitagoras, pontosCirculo;

  double raio = 1, areaQuadrado = pow((raio * 2), 2);
  double numInteracoes = 1000000;

  for(int i = 0; i < numInteracoes; i++){
    pontosX = (double)rand() / RAND_MAX;
    pontosY = (double)rand() / RAND_MAX;

   // printf("Primeiro número aleatório: %.6f", pontosX);
   // printf("\nSegundo número aleatório: %.6f", pontosY);
    
    pitagoras = pow(pontosX, 2) + pow(pontosY, 2);
    
    if(pitagoras <= 1){
      pontosCirculo++;
    }
  }

  pi = (pontosCirculo / numInteracoes) * 4;

  printf("PI aproximado: %.6f", pi);
  printf("\nValor esperado de pi: %.6f", M_PI);
  printf("\nErro absoluto: %.6f", pi - M_PI);
  printf("\nErro relativo: %.6f", (pi - M_PI) / M_PI);
  
  return 0;
}