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
    int length = strlen(name);
    for(char** i = environ; *i != NULL; ++i){
      if (strncmp(*i,name,length)== 0) return *i;
      }
    return NULL;
}

int mysetenv(const char *envName, const char *value, int overwrite){
    int length = strlen(envName);
    
    if (overwrite) {
       for(char** i = environ; *i != NULL; ++i){
          if (strncmp(*i,name,length)== 0) return *i;
      }
    }
}
