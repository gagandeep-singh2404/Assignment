#include <stdio.h>
#include <stdlib.h>


int main()
{
    int min = __INT_MAX__;
    int secondMin;
    int given;
    char c[10];
    char compare[] = {"end"}; 
    printf("Please enter numbers: ");
    while (1)
    {   
        gets(c);
        if (strcmp(c,"") == 0) break;
        given = atoi(c);

        if (given < min) {
            secondMin = min;
            min = given;
        }else if (given < secondMin && given != min){
            secondMin = given;
        }
    }
    printf("second smallest Number is: %d ", secondMin);
}
