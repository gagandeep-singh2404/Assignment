#ifndef _LINKEDLIST_
#define _LINKEDLIST_
#include <stddef.h>

typedef struct nodes
{
    int value;
    struct nodes *next;
}node;

typedef struct list
{
    node* head;
    
}LL;

void constructLL(LL*list);
void copyLL(LL *list1, LL *list2);

void destructLL(LL* list);
void removeLL(LL*list,int value);

/*
    NULL VALUE IS 0
*/
void addFrontLL(LL *list,int number);
void addRearLL(LL *list,int number);

int countLL(LL* list);
void printLL(LL *list);


#endif