#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
  double kmh = atof(argv[1]);
  // double y = atof(argv[2]);

  double cms = kmh * 1e5 / 3600; 
  // double z = x + y;
  // double w = x * y;
  
  printf("O Km/h: %.1f \n", kmh);
  printf("O Cm/s: %.1f \n", cms);
  // printf("Segundo Numero: %.1e \n\n", y);

  // printf("Soma: %.1e + %.1e = %.1e\n", x, y, z);
  // printf("Produto: %.1e * %.1e = %.1e\n", x, y, w);
  return 0;
}