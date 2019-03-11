#include <stdio.h>
#define null 0
#include <string.h> 
#include <stdlib.h>
char* mygetenv(const char *name);
int mysetenv(const char *name, const char *value, int overwrite);
extern char **environ; 
int main(int argc, char* argv[], char*env[]){
    
    if (argc < 2) {
        printf("Please enter a valid input\n");
        return 0;
    }

     char* nu =  mygetenv(argv[1]);

    
    return 0;
}

char* mygetenv(const char *name){
    
    int sizeOfInput = strlen(name);
    char* copy = (char*)malloc(strlen(name) + 1); 
    for(char** i = environ; *i != NULL; ++i)
    {
      
      if (strncmp(*i,name,sizeOfInput)== 0) {
              printf("Es hat geklappt");
              strcpy(copy, *i);
              printf("\n %s", *i);
              return copy;
      }
    }
return NULL;
}

int mysetenv(const char *name, const char *value, int overwrite){
return 0;
}
