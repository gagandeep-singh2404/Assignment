#include "LLHeader.h"
#include <stdio.h>
#include <stdlib.h>

void constructLL(LL*list){
    *list = (node*)malloc(sizeof(LL));
    list->head = NULL;
}

void addFrontLL(LL *list,int number){


    node *newNode = malloc(sizeof(node));
    newNode->value = number;
    newNode->next = list->head;
    list->head= newNode;

}
void addRearLL(LL *list,int number){

      if (!list->head) {
        addFrontLL(list,number);
        return;
    }

    node * temp = NULL;
    for(temp = list->head;  temp->next; temp = temp->next);

    node *newNode = malloc(sizeof(node));
    newNode->value = number;
    newNode->next = temp->next;
    temp->next = newNode;

}

void copyLL(LL *copy, LL *original){
     for(node* newNode = original->head; newNode; newNode = newNode->next)
   {
       addRearLL(copy,newNode->value);

   }


}

void destructLL(LL* list){

   node* temp =NULL;
   for(node* newNode = list->head; newNode; newNode = newNode->next)
   {
       if (temp) {
          free(temp);
       }
        temp = newNode;
   }


}
void removeLL(LL*list,int value){

  
    for(node * head = list->head; head->next != NULL; head= head->next)
    {
        if (head->next->value == value) {
            node* temp = head->next;
            head->next = temp->next;
            free(temp);
            return; 
        }
        
    }

}

int countLL(LL* list){
    int count = 0;

    for(node * temp = list->head; temp;temp = temp->next)
    {
        count++;
    }
    return count;
}
void printLL(LL *list){

    for(node* temp = list->head; temp; temp = temp->next)
    {
        printf("The Value is: %d\n",temp->value);
    }

}
