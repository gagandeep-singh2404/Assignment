#include "functionHeader.h"
#include "structHeader.h"

#include <stdio.h>
#include <stdlib.h>


void init(){
    printf("wo1\n");
    *myIndex->bucket = (Bucket*)malloc(IndexSize*sizeof(Bucket*));
    printf("wo2\n");
    *myIndex->overflow = malloc(OverflowSize*sizeof(OverflowSize));
    
    for(int i = 0; i < IndexSize; i++)
    {
        myIndex->bucket[i] = malloc(BucketSize*sizeof(Bucket));
    }
    
}

bool add(){
    printf("Wird geaddet");
return 0;
}


void addObject(Bucket * bucket){
    printf("Please enter an ID: \n");
    scanf("%d",&bucket->id);
    printf("Please enter a name: \n");
    scanf("%s",bucket->name);
    printf("Please enter a address: \n");
    scanf("%s",bucket->address);
}