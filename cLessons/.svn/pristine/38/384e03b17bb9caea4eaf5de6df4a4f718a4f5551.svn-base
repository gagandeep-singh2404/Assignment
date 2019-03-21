#include "functionHeader.h"
#include "structHeader.h"

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void init(){
    myIndex = malloc(sizeof(Index));
    
    for(int i = 0; i < BucketSize; i++)
    {
        myIndex->bucket[i] = calloc(NumberOfBuckets,sizeof(Bucket));
    }

    myIndex->overflow[OvIndex] = calloc(NumberOfOverflow,sizeof(Bucket));    
}

bool add(){
    Bucket *bucket = malloc(sizeof(Bucket));
    addObject(bucket);
    int index = calculateKey(bucket->name);


    for(int i = 0; i < BucketSize; i++)
    {
        for(int j = 0; j < NumberOfBuckets; j++)
        {
            if (myIndex->bucket[i][j].name == NULL) {
                myIndex->bucket[i][j] = *bucket;
                printf("gerade hier:BU \n");
                return 1;
            }
        }
    }
   
        for(int j = 0; j < NumberOfOverflow; j++)
        {
            if (myIndex->overflow[OvIndex][j].name == NULL) {
                myIndex->overflow[OvIndex][j] = *bucket;  
                printf("gerade hier:Ov \n");
                return 1;
        }
    }

    printf("hat nicht geaddet\n");
return 0;
}

void addObject(Bucket * bucket){
    bucket->address = (char*)malloc(sizeof(char)*20);
    bucket->name = (char*)malloc(sizeof(char)*20);

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
    return key%BucketSize;
}


Bucket* myRead(char* name){

    for(int i = 0; i < BucketSize; i++)
    {
        for(int j = 0; j < NumberOfBuckets; j++)
        {
            if (myIndex->bucket[i][j].name == NULL)continue;
            
            if (strcmp(myIndex->bucket[i][j].name, name) == 0) {
                printf("\n----------------\n");
                printf("ID: %d\nNAME: %s\nADDRESS: %s\n",myIndex->bucket[i][j].id,myIndex->bucket[i][j].name,myIndex->bucket[i][j].address);
                return &myIndex->bucket[i][j];
            }
        }
    }

    for(int j = 0; j < NumberOfOverflow; j++)
    {
        if (myIndex->overflow[OvIndex][j].name == NULL) continue;

        if (strcmp(myIndex->overflow[OvIndex][j].name, name)== 0) {
            printf("\n----------------\n");
            printf("ID: %d\nNAME: %s\nADDRESS: %s\n",myIndex->overflow[OvIndex][j].id,myIndex->overflow[OvIndex][j].name,myIndex->overflow[OvIndex][j].address);
            return &myIndex->overflow[OvIndex][j];
        }
              
    }
    printf("\n----------------\n");
    printf("%s Not found\n", name);
    return NULL;
}


bool myDelete(char * name){

    Bucket * bucket = myRead(name);

    if (bucket == NULL) {
        printf("\n----------------\n");
        printf("%s Not found\n",name);
        return 0;
    }
    bucket->address = NULL;
    bucket->id = (int)NULL;
    bucket->name = NULL;
    free(bucket);
    return 1;
}

