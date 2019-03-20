#include "functionHeader.h"
#include "structHeader.h"

#include <stdio.h>
#include <stdlib.h>
#include <string.h>


void init(){
    myIndex = (Index*)malloc(IndexSize+1*sizeof(Bucket));
    myIndex->overflow = (Bucket*)malloc(OverflowSize*sizeof(Bucket*));

    for(int i = 0; i < IndexSize; i++)
    {
        myIndex[i].bucket = malloc(BucketSize*sizeof(Bucket*));
    }

}

bool add(){
    Bucket *bucket = malloc(sizeof(Bucket));
    addObject(bucket);
    int index = calculateKey(bucket->name);
    printf("Index: %d\n", index);
    
    Bucket* tempbucket = myIndex[index].bucket;
    for(int i = 0; i< BucketSize;i++)
    {
        if (tempbucket == NULL) {
            
            tempbucket = bucket;
            printf("hat geaddet in dies\n");
            return 1;
        }
        tempbucket++ ;
    }
/*
     for(int i = 0 ; i< OverflowSize;i++)
    {
        if (&myIndex[0].overflow[i] == NULL) {
            
            myIndex[0].overflow[i] = *bucket;
            printf("in overflow amk\n");
            return 1;
        }
    }
  */  
    printf("hat nicht geaddet\n");
return 0;
}

void addObject(Bucket * bucket){
    bucket->address = (char*)malloc(sizeof(char*));
    bucket->name = (char*)malloc(sizeof(char*));
    bucket->id = (int)malloc(sizeof(int));

    printf("Please enter an ID: \n");
    scanf("%d",&bucket->id);
    printf("Please enter a name: \n");
    scanf("%s",bucket->name);
    printf("Please enter a address: \n");
    scanf("%s",bucket->address);
}

int calculateKey(char * name){
    int key = 0;
    for(; *name != '\0'; name++){ key += *name; }
    return key%IndexSize;
}

/*
bool myRead(char* name){
    int index = calculateKey(name);

    for(int i = 0; i < BucketSize; i++)
    {
        if (strcmp(name, myIndex[index].bucket[i]->name) == 0) {
            printf("ID: %d\nName\nAddress\n",myIndex[index].bucket[i]->id,myIndex[index].bucket[i]->name,myIndex[index].bucket[i]->address);
            return 1;
        }
    }

      for(int i = 0; i < OverflowSize; i++)
    {
        if (strcmp(name,myIndex->overflow[i].name)== 0) {
            printf("ID: %d\nName\nAddress\n",myIndex->overflow[i].id,myIndex->overflow[i].name,myIndex->overflow[i].address);
            return 1;
        }
        
    }
    
    printf("Sorry Person not found!");
    return 0;
}

*/