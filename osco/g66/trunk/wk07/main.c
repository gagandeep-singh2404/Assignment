#include "header.h"
#include <stdio.h>

int main(void)
{

    Page page[SizeOfArray];
    int pageNrArray[] = {2, 3, 2, 1, 5, 2, 4, 5, 3, 2, 5, 2};
    int size = sizeof(pageNrArray) / sizeof(int);

    createArray(page);
    printArray(page);
    doFifo(page, pageNrArray, size);
    //doLRU(page, pageNrArray,size);
}

// 1 is true 0 is false
void doFifo(Page *ram, int pages[], int size)
{
    int counter, isThere;
    c(ram, pages);
    // then do this
    for (int i = counter, pointer = 0; i < size; i++)
    {

        for (int j = 0; j < SizeOfArray; j++)
        {
            if (ram[j].pageNr == pages[i])
            {
                isThere = 1;
                break;
            }
        }

        if (isThere == 0)
        {
            changePageNr(&ram[pointer].pageNr, pages[i]);
            // set pointers new value
            if (pointer < SizeOfArray)
                pointer++;
            else
                pointer = 0;
        }
    }
}

// 1 is true 0 is false
void doLRU(Page *ram, int pages[], int size)
{
    int counter;
    int isThere = 0;

    c(ram, pages);

    // then do this
    for (int i = counter, pointer = 0; i < size; i++)
    {

        for (int j = 0, k = 1; j < SizeOfArray; j++, k++)
        {

            if (ram[j].pageNr == pages[i])
            {
                isThere = 1;
                pointer = j;
                break;
            }
            else
            {
                if (ram[j].age > ram[i].age)

                    changePageNr(&ram[pointer].pageNr, pages[i]);
                incrementAge(ram);
                ram[pointer].age = 0;
            }
        }
    }
}

void c(Page *ram, int pages[])
{
    int counter;
    int isThere = 0;

    // set the first ram pages in there
    for (int i = 0, counter = 0; i < SizeOfArray; i++, counter++)
    {
        if (ram[i].pageNr != pages[counter])
        {
            changePageNr(&ram[i].pageNr, pages[counter]);
        }
        else
            i--;
    }
}