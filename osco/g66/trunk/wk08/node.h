#ifndef NODES
#define NODES

#define ArraySize 5
typedef struct node
{
    int serviceTime;
    int arrivalTime;
    struct node *next;
}Node;

void addNewNodeToQueue(int,int,Node*);
void FCFS(int** array);
void removeNodeFromQueue(Node*);

#endif