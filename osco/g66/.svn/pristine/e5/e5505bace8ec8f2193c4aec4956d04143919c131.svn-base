#include "node.h"
#include <stdlib.h>
#include <stdio.h>

void addNewNodesToQueue(int arrivalTime, int serviceTime, Node *head)
{
    printf("Adding newNode: %d\n", arrivalTime);
    Node *newNode = malloc(sizeof(Node *));
    newNode->arrivalTime = arrivalTime;
    newNode->serviceTime = serviceTime;

    Node *temp = NULL;
    for (Node *temp = head; temp->next; temp = temp->next)
        ;

    newNode->next = temp->next;
    temp->next = newNode;
}

void FCFS(int *array[])
{

    Node *queue = (Node *)malloc(sizeof(Node));
    queue->next = NULL;
    queue->arrivalTime = 0;
    queue->serviceTime = 0;
    int processor = 0;
    int totalServiceTime = 0;

    printf("hbadshjasbj: %d\n", array[0][0]);
    while(processor < ArraySize){
        printf("processor: %d\n", processor);
        if (processor == array[processor][0]) addNewNodesToQueue(array[processor][0],array[processor][1],queue);

        if (totalServiceTime == queue->next->arrivalTime)
        {
            totalServiceTime += queue->next->serviceTime;
            removeNodeFromQueue(queue);
            processor++;
        }
        printf("TotalSeriveTime: %d\n", totalServiceTime);
    }


}

 void removeNodeFromQueue(Node* head){
     printf("CurrentNode removed: %d",head->next->arrivalTime);
    Node* temp = head->next->next;
    head->next = temp;
}