#include <stdlib.h>
#include <stdio.h>
#include <immintrin.h>	

#define M (1024*1024)


int main(void){
    float* array1 = (float*)aligned_alloc(32,M*sizeof(float));
    float* array2 = (float*)aligned_alloc(32,M*sizeof(float));

    printf("Pointer %p\n", array1);
    printf("Pointer %p\n", array2);
   
   /*
    for(int i = 0; i < M; i++)
    {
        array1[i] = i;
        printf("Array 1: %f\n",array1[i]);
    }

    for(int j = M; j < M*2;  j++)
    { 
        array2[j - M] = j;
        printf("Array 2: %f\n", array2[j-M]);
    }
*/

    return 0;
}