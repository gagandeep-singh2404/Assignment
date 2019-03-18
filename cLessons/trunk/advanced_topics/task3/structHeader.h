
#ifndef _STRUCTHEADER_
#define _STRUCTHEADER_

#define IndexSize 10
#define OverflowSize 10
#define BucketSize 18
/*
    An Bucket structure. 
    Contains: 
    1. int id
    2. string name
    3. string address
*/

    typedef struct bucket_str{
        int id;
        char *name;
        char* address;
    }Bucket;
    
/*
    An index structure. 
    Contains: 
    1. int id
    2. array of structs (bucket)
*/

    typedef struct index_str{
        Bucket *bucket[BucketSize];
        Bucket *overflow[OverflowSize];
    }Index;
    

    Index *myIndex;
#endif