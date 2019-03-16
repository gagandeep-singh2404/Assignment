#define _CRT_SECURE_NO_WARNINGS 1
#include "oscoHeader.h"
#include "oscoSource.c"
int main(void) {

	student *newStudent = init();
    print(newStudent);
}