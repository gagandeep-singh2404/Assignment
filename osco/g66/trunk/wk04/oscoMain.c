#define _CRT_SECURE_NO_WARNINGS 1
#include "oscoHeader.h"
#include "oscoSource.c"
int main(void) {

	student *initStudent = init("Hallo");
	//print(initStudent);
	//student *newStudent = add();
    //print(newStudent);
	addStudentToTextFile();
}