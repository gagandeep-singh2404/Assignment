#define _CRT_SECURE_NO_WARNINGS 1

#include<stdio.h>


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




int main(void) {
	struct std student;
	
	printf("Please enter the firstname: ");
	scanf("%s",&student.firstname);
	printf("Please enter the lastname: ");
	scanf("%s",&student.lastname);
	printf("%s", student.firstname);
	printf("Plese enter the studentnumber: ");
	scanf("%ld",&student.studentnumber);
	printf("Please enter course Name: ");
	scanf("%s",&student.course1.coursename);
	printf("Please enter the course ID: ");
	scanf("%ld", &student.course1.courseId);
	printf("Please enter the course GPA: ");
	//scanf("%f", &student.course1.gpa);
	printf("HALLO");

}