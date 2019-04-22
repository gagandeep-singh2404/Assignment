
#include "LLHeader.h"
#include "LLSource.c"

int main(void){
LL list1, list2;
constructLL(&list1);
constructLL(&list2);
printLL(&list1);
addFrontLL(&list1,3);
addFrontLL(&list1,5);
addFrontLL(&list1,2);
addFrontLL(&list1,18);
addFrontLL(&list1,12);
printLL(&list1);
printf("number of elements: %d\n", countLL(&list1));
addRearLL(&list1, 4);
addRearLL(&list1, 10);
printLL(&list1);
printf("number of elements: %d\n", countLL(&list1));
copyLL(&list2, &list1);
removeLL(&list1,2);
printLL(&list1);
printLL(&list2);
destructLL(&list1);
destructLL(&list2);

return 0;
} 
