#include <stdio.h>

int main(void){
	char cadena [100];
  	printf ("¿Como te llamas? ");
  	fgets (cadena, 100, stdin);	
	printf("Hola, ¿como estas "%s cadena);
	return 0;
}
