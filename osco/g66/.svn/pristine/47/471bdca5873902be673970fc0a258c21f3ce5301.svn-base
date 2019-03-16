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
	creates a predefined Student with one value different
*/

student* init(char * firstname);

/* 
    creates a student with Input of the Console
*/
student * add();

/*
	prints the student
*/
void print(student *std);
/*
	 copy a record variable to another record variable. 
*/
	void copyRecordVariable(student *std1,student* std2);

/*
	add a student in a textfile or binary
*/
	void addStudentToFile();

/*
	exchange two variables values
*/
	void exchangeRecordVariable(student *std1, student * std2);

/*
	sum up a integer array	
*/

	void sum(int [],int size);

#endif