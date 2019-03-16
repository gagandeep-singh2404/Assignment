	#define _CRT_SECURE_NO_WARNINGS 1
	#include <stdio.h>
    #include "oscoHeader.h"
	#include <stdlib.h>
	#include <stdio.h>
	#include <string.h>

    student *init(){
    student *newStudent = (student *) malloc(sizeof(student));
	course *newCourse = (course *) malloc(sizeof(course));
	printf("Please enter the firstname: ");
	scanf("%s",newStudent->firstname);

	printf("Please enter the lastname: ");
	scanf("%s",newStudent->lastname);

	printf("Please enter the studentnumber: ");
	scanf("%ld",&newStudent->studentnumber);

	printf("Please enter course Name: ");
	scanf("%s",newCourse->coursename);

	printf("Please enter the course ID: ");
	scanf("%ld",&newCourse->courseId);

	printf("Please enter the course GPA: ");
	scanf("%f",&newCourse->gpa);

    newStudent->course1 = *newCourse;
	return newStudent;
    }


    void print(student * std){

		printf("Firstname: %s",std->firstname);
		printf("\nLastname: %s",std->lastname);
		printf("\nStudentnumber: %ld",std->studentnumber);
		printf("\nCoursename: %s",std->course1.coursename);
		printf("\nCourseID: %ld",std->course1.courseId);
		printf("\nGPA: %f",std->course1.gpa);
		

    }