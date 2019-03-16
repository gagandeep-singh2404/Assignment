#define _CRT_SECURE_NO_WARNINGS 1
#include "oscoHeader.h"
#include "oscoSource.c"
int main(void) {

	student *initStudent1 = init("Hallo");
	//student *newStudent = add();
	//exchangeRecordVariable(initStudent1,newStudent);
	addStudentToFile();
	//copyRecordVariable(initStudent1,newStudent);
}