#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#define NUMBER 7
typedef enum week {SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY} Week;

char *weekInString[] = {"Sun","Mon","Tue","Wed","Thu","Fri","Sat"};
Week enumDays[] = {SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY};
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
        
        for(int j = 0; j < NUMBER; j++;){
        if(input[i] == weekInString[j]) day[i] = enumDays[i];

        }
    }
}

    void writeWeekDays(){

        for(int i = 0; i < NUMBER; i++) printf("\nWeekDay{%d}:%d",i,days[i]);
}

