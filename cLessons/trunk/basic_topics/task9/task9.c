#include <stdio.h>
#include <stdlib.h>


int main()
{
    int min = __INT_MAX__;
    int secondMin;
    int given;
    char choice[20];
    printf("Please enter numbers: ");
    while (1)
    {
        if ( sscanf(sizeof(choice),"%c",choice) != 1) break;
        given = atoi(choice);

        if (given < min) {
            secondMin = min;
            min = given;
        }else if (given < secondMin && given != min){
            secondMin = given;
        }
    }
    printf("second smallest Number is: %d ", secondMin);
}
