#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#define NUMBER 7
typedef enum week {SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY} Week;

char *weekInString[] = {"sun","mon","tue","wed","thu","fri","sat"};

/* helps putting the right WeekDay in days Array */
Week enumDays[] = {SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY};

/* The Week Enum, in which we are giving the Value */
Week days[NUMBER];

void readString();
void writeWeekDays();

int main(){
    readString();
    writeWeekDays();
    return 0;
}

void readString(){
 char input[NUMBER];
 int counter = 0;
  
    for(int i = 0; i< NUMBER; i++){
        printf("Please enter a WeekDay: ");

        /* Is not safe, but it works*/
        gets(input);

        /* checking if the input machtes with the beginning of the weekdays, 3 char long*/
        for(int j = 0; j < NUMBER; j++){
            if(strcmp(input, weekInString[j]) == 0){ 
                days[i] = enumDays[j];
                counter++;
                break;
            }
       }

    if (counter == i) i--;

    }
}
    void writeWeekDays(){
     for(int i = 0; i < NUMBER; i++) printf("\nWeekDay{%d}: %s",i,weekInString[days[i]]);
}

