
#include <stdio.h>

// function definition
/* pre : n has a value N, N>0
 * post: return value is the sum of the array
 */
  void sum(int *array, int size, int *sum){

    int temp = 0;
    for (size_t i = 0; i < size; i++) {
       temp += array[i];
    }
    *sum = temp;
    printf("Thats the end sum: %d\n" , *sum);
}


  // declaration
//  void sum(int*array,int size,int *sum);

  int main() {
    int a[] = {1,1,1,1,1,1,1,1,1,1};
    int size = 10;
    int summ;
    sum(a,size,&summ);

    printf("Ausserhalb the end sum: %d\n" , summ);
    return 0;
}
