#include "header.h"
#include <stdio.h>
void incrementAge(Page *array)
{

    for (int i = 0; i < SizeOfArray; i++)
    {
        array[i].age++;
    }
}

void changePageNr(int *oldpage, int newPage)
{

    *oldpage = newPage;
}

void printArray(Page *array)
{

    for (int i = 0; i < SizeOfArray; i++)
    {
        printf("Array: %d, Page: %d, Age: %d\n", i, array[i].pageNr, array[i].age);
    }
}

void createArray(Page *array)
{

    printf("Es klappt irgendwie nicht\n");
    for (int i = 0; i < SizeOfArray; i++)
    {
        array[i].age = 4;
        array[i].pageNr = -1;
    }
}

