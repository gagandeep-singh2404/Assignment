
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#define NUMBER 7
typedef enum week {SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY } Week;


char *weekInString[] = {"Sun","Mon","Tue","Wed","Thu","Fri","Sat"};
Week days[NUMBER];

void readString();
void writeWeekDays();

int main(){
    
    readString();
    writeWeekDays();
    return 0;
}


void readString(){
 char decision[32];
 char input[10];

  
    for(int i = 0; i< NUMBER; i++){
        printf("Please enter a WeekDay: ");

        fgets(decision,sizeof(decision),stdin);
        sscanf(decision, "%s", &input);
        
        if (strcmp(input,weekInString[0]) == 0) {
            days[i] = SUNDAY;
        }
        else if(strcmp(input,weekInString[1])== 0){
        days[i] = MONDAY;
        }
        else if(strcmp(input,weekInString[2])== 0){
        days[i] = TUESDAY;
        }
        else if(strcmp(input,weekInString[3])== 0){
        days[i] = WEDNESDAY;
        }
        else if(strcmp(input,weekInString[4])== 0){
        days[i] = THURSDAY;
        }
        else if(strcmp(input,weekInString[5])== 0){
        days[i] = FRIDAY;
        }
        else if(strcmp(input,weekInString[6])== 0){
        days[i] = SATURDAY;
        }else {
        printf("Try again please: ");
         i--;
        }
    }
}

    void writeWeekDays(){

        for(int i = 0; i < NUMBER; i++) printf("\nWeekDay{%d}:%d",i,days[i]);

}

