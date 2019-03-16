#define _CRT_SECURE_NO_WARNINGS 1
#include "oscoHeader.h"
#include "oscoSource.c"
int main(void) {

	//student *initStudent1 = init("Hallo");
	//student *newStudent = add();
	//exchangeRecordVariable(initStudent1,newStudent);
	//addStudentToFile();
	int array [] = {0,1,2,3,4,5,6,7,8,9,10,11};
	int size = sizeof(array)/sizeof(array[0]);
	sum(array, size);
	//copyRecordVariable(initStudent1,newStudent);
}