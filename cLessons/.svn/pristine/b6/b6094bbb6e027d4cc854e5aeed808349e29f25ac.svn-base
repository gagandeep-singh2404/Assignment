#include "header.h"
#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
int size;

void init(int n){
    storage = malloc(n *sizeof(char*));
    size = n;
}

void destroy(){
    free(storage);
}

bool insert(char * str){

    for(size_t i = 0; i < size; i++)
    {
        if (storage[i] == NULL) {
            storage[i] = str;
            return 1;
        }   
    }

    return 0;
}
void print(){
    
    for(size_t i = 0; i < size ; i++)
    {
        if (storage[i] != NULL) {
             printf("%s\n", storage[i]);
        }
        
    }
}