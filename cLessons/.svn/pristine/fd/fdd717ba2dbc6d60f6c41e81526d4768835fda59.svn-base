#include <stdio.h>

  unsigned char pbcd(int n);



int main(){

  printf("Datei: %s",pbcd(11) == 0x11 ? "gagan" : "tom");
  return 0;
}


  unsigned char pbcd(int n){

    n %= 100;
    printf("%d\n",n);
    unsigned char ch= (n/10) << 4 | n%10;
    return ch;
}
