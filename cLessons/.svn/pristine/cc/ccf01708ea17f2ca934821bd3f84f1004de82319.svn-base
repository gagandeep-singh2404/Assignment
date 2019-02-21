
#include <stdio.h>
#include <ctype.h>
/* i think number b and d from 3a are the right code snippet,
  because d gives the pointer which shows to the first value and d is right because, an array is a pointer,
  and so giving only the array it automatically  gives the first pointer.
*/


/*
 function definition
 pre : col has a value N, N>0 && N< 9,
      row is a character from A-H
 post: return position of the player
*/
void chessboard(char row, int col, int*a){
  col -=1;
  int calculatedRow = row -'A';

  if (calculatedRow > 7 && calculatedRow < 0) {
    printf(" this character is out of bound: %c\n", row);
  }else {
    printf("The row is: %d\n The col is: %d\n",calculatedRow, col);
    a[0] = col;
    a[1] = calculatedRow;
  }

}



int main(){

  char row = 'F';
  int col = 6;
  int array[2];
  chessboard(row,col,array);
  printf("Ausserhalb row is: %d\n The col is: %d\n",array[0], array[1]);
  return 0;

}
