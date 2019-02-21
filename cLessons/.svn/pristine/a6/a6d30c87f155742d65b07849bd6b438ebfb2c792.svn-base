#include <stdio.h>

int compareString(const char *string1, const char *string2);
int checkIfEveryCharIsCorrect(const char *string1,const char *string2, int number);
int main(){
  char s1[] = "Hallo";
  char s2[] = "kn";

  printf("%d\n",compareString(s1,s2));
  return 0;
}


int compareString(const char *string1, const char *string2){

  int number1 = 0;
  int number2 = 0;

  for (; string1[number1] != 0; number1++);
  for (;string2[number2] != 0; number2++);

  if (number1 == number2) {
    return checkIfEveryCharIsCorrect(string1,string2,number1);
  }else if (number1 < number2){
    return -1;
  }else return 1;

}

int checkIfEveryCharIsCorrect(const char *string1,const char *string2, int number){

  for (int i = 0; i < number; i++) {
    if (string1[i] != string2[i]) {
      return 3;
    }
  }
  return 0;
}
