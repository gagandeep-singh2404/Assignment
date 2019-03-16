	#define _CRT_SECURE_NO_WARNINGS 1
	#include <stdio.h>
    #include "oscoHeader.h"
	#include <stdlib.h>
	#include <stdio.h>
	#include <string.h>
	#include <ctype.h>


student* init(char* firstname){
   	student *newStudent = (student *) malloc(sizeof(student));
	course *newCourse = (course *) malloc(sizeof(course));

	strcpy(newStudent->firstname,firstname);
	strcpy(newStudent->lastname,"Pudding");
	newStudent->studentnumber = 343434;
	
	strcpy(newCourse->coursename,"SE");
	newCourse->courseId = 5;
	newCourse->gpa = 9.0;

	newStudent->course1 = *newCourse;
	
	return newStudent;
}

    student *add(){
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
		printf("\nGPA: %f\n",std->course1.gpa);
    }

	void addStudentToFile(){
		student *newStudent = (student *) malloc(sizeof(student));
		FILE *file;
		printf("Binary or Textfile: (B|T)");
		char textOrBinary = tolower(getchar());
		if (textOrBinary == '\n') textOrBinary = tolower(getchar());
		
		if (textOrBinary == 'b') {
		file = fopen("student.txt","wb");
		} else if(textOrBinary == 't') {file = fopen("student.txt","w");}

		if (!file) {
			printf("There is no file");
			return;
		}
		
		while(1){
			
		 newStudent = add();
		if (textOrBinary == 't') {
			fprintf(file,"%s\t%s\t%ld\t%s\t%ld\t%f\n",newStudent->firstname,newStudent->lastname,newStudent->studentnumber
												,newStudent->course1.coursename,newStudent->course1.courseId,newStudent->course1.gpa);

		}else{ 
			fwrite(newStudent, sizeof(student), 1, file);
			}
		
			printf("You want to add another student ? (Y|N)");
			char input = tolower(getchar());
			
			if (input == '\n') input = tolower(getchar());
			if (input == 'n') break;
			
		}
		fclose(file);
	}


	void copyRecordVariable(student* std1, student* std2){
		*std2  = *std1;

	}

	void exchangeRecordVariable(student* std1, student* std2){
		student *temp = (student *) malloc(sizeof(student));

		*temp = *std1; 
		*std1 = *std2;
		*std2 = *temp;
	}
	void sum(int array[], int size){
		int sum = 0;
		for(int i = 0; i < size; i++) sum += array[i];

		printf("The sum: %d\n",sum);	
	}