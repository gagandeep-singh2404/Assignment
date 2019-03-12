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
	
	printf("Please enter the first and Lastname of the Student: You have to add Whitespace");
	scanf_s("%s" "%s",&student.firstname, &student.lastname);
	printf("\nPlese enter the studentnumber");
	scanf("%ld",&student.studentnumber);
	printf("\nPlease enter course Name ");
	scanf_s("%s",&student.course1.coursename);
	printf("\nPlease enter the course ID and his GPA");
	scanf("%ld %f",&student.course1.courseId, &student.course1.gpa);

	printf("%s",student.firstname);
}