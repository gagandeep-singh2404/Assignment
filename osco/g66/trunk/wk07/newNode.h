#ifndef QUEE 
#define QUEE
#include <stddef.h>

typedef struct nodes{

	struct node* next;
	int pageNr;
	int age;

} node;

typedef struct list
{
	node* head;

}LL;

void constructList(LL * list);

int checkAge(int age1, int age2);
void switchNodePage(int* pageNr, int requestPage);
void doFIFO(LL*,int array []);
void addNewNodes(LL*,int );
void print(LL*);
void printha();
#endif