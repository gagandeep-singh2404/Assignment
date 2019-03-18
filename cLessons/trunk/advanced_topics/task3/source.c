#include "functionHeader.h"
#include "structHeader.h"

#include <stdio.h>
#include <stdlib.h>


void init(){
    

    for(int i = 0; i < IndexSize; i++)
    {
        myIndex[i]->id = NULL;
    }

   
    
    printf("ich bin hier\n");
}

bool add(int id){

    if (id < 0 || id > IndexSize) {
        printf("Id (%d) is not valid!\n",id);
        return 0;
    }
    int loops =0;
    for(int i = 0; i < BucketSize; i++,loops++)
    {
        if (myIndex[id]->bucket[i] != NULL) {
            printf("Es hat geklappt Bucket");
            addObject(myIndex[id]->bucket[i]);
         return 1;
        }
        loops++;
    }

    if (loops == BucketSize) {
        loops = 0;
        for(int i = 0; i < OverflowSize; i++)
        {
            if (myIndex[id]->overflow[i] != NULL) {
                printf("Es hat geklappt Overflow");
                return 1;
            }
        }
        
    }
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