#include <stdio.h>
#define null 0
#include <string.h> 
char* mygetenv(const char *name);
int mysetenv(const char *name, const char *value, int overwrite);
extern char **environ; 
int main(int argc, char* argv[], char*env[]){
    
    if (argc < 2) {
        printf("Please enter a valid input\n");
        return 0;
    }

     char* nu =  mygetenv(*env);

        if (nu == NULL) {
          printf("nul");
          for(char* e = nu; e != 0; ++e) {
          printf("%s",e);
        }
      }
    
    return 0;
}

char* mygetenv(const char *name){
    for(char** i = environ; *i != 0; ++i)
    {
      char* found = strstr(*i, name);
      if (found != *i) continue;
      char copy [strlen(*i)];
      strcpy(copy, name);
      if (strcmp(name,strtok(copy,"=")) == 0) {
        printf("not here");
        return *i;
      }  
    }
    printf("jo vergess es");
return NULL;
}

int mysetenv(const char *name, const char *value, int overwrite){
return 0;
}
