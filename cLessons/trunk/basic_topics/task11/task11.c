#include <stdio.h>
#define NULL ((void *) 0)


char* mygetenv(const char *name);
int mysetenv(const char *name, const char *value, int overwrite);

int main(int argc, char* argv[], char*env[]){
    
    mygetenv(*env);
   
    return 0;


char* mygetenv(const char *name){
    
    if (name[0] == NULL) {
        printf("(null)");
        return NULL;
    }
    printf("every thinh is ok");
    return "ok";
}

int mysetenv(const char *name, const char *value, int overwrite){
return 0;
}