#include "LLHeader.h"
#include <stdio.h>
#include <stdlib.h>

void constructLL(LL*list){
    list = (LL*)malloc(sizeof(LL));

    list->head = malloc(sizeof(node*));
    list->tail = malloc(sizeof(node*));
    

    list->tail->value = 0;
    list->tail->next = NULL;

    list->head->next = list->tail;
}

void addFrontLL(LL *list,int number){

    node *newNode = malloc(sizeof(node));
    newNode->value = number;
    newNode->next = list->head;
    list->head= newNode;
  
}
void addRearLL(LL *list,int number){
    node * temp = malloc(sizeof(node));
    for(temp = list->head;  temp->next != NULL; temp = temp->next);

    node *newNode = malloc(sizeof(node));
    newNode->value = number;
    newNode->next = temp->next;
    temp->next = newNode;
    
}

void copyLL(LL *copy, LL *original){
    
    copy->head = original->head;
    
}

void destructLL(LL* list){
    free(list);

}
void removeLL(LL*list,int value){}



int countLL(LL* list){
    int count = 0;

    for(node * temp = list->head; temp != NULL;temp = temp->next)
    {
        count++;
    }
    return count;
}
void printLL(LL *list){
    
    for(node* temp = list->head; temp != NULL; temp = temp->next)
    {
        printf("The Value is: %d\n",temp->value);
    }
    
}
