#include <stdio.h>


unsigned long int datumcode(int day, int month, int year);

unsigned long int datumcode(int tag, int monat, int jahr){

  int nothing;
  unsigned long int date = tag << 0;
  date = monat << 5;
  date = jahr << 9;

  printf("%lu\n",date );
  return date;
}


 int main() {

   datumcode(12,12,1980);
   return 0;
}
