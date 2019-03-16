#ifndef _STRING_LIST_H_
#define _STRING_LIST_H_


typedef struct csr {
	char coursename[10];
	long courseId;
	float gpa;
}course;


typedef struct std {

	char firstname[20];
	char lastname[20];
	long studentnumber;
	course course1;

}student;


/* 
    creates a student with Input of the Console
*/
student * init();

void print(student *std);

#endif