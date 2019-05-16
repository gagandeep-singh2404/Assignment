#include "newNode.h"
#include <stdio.h>

#define NUMBER 3

int main(void) {
	
	LL list;

	printha();
	constructList(&list);
	addNewNodes(&list,NUMBER);
	print(&list);

	//int newRequest[] = { 1, 2, 1, 3, 4, 5, 6, 8, 4, 3};

	return 0;
}

