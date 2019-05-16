#include "newNode.h"

void constructList(LL* list) {
	list = (node*)malloc(sizeof(LL));
	list->head = (node*)malloc(sizeof(node));
	list->head->pageNr = - 1;
}

int checkAge(int age1, int age2) {

	if (age1 < age2) return -1;
	else if (age1 > age2) return 1;
	
	return 0;
}

void switchNodePage(int* pname,int requestPage) {

	*pname = requestPage;
}

void doFIFO(LL *list,int requests []) {
}

void addNewNodes(LL *list ,int number) {

	
	for (int counter = 1; counter <number; counter++)
	{
		node* temp = NULL;
		node* newNode = (node*)malloc(sizeof(node*));
		newNode->pageNr = counter;
		
		// goes to the last Node
		for (temp = list->head; temp->next; temp = temp->next);
		
		newNode->next = temp->next;
		temp->next = newNode;
	}
}

void print(LL *list) {

	for (node* temp = list->head; temp; temp = temp->next)
	{
		printf("The Value is: %d\n", temp->pageNr);
	}
}

void printha() {
	printf("hello %d", 10);
}