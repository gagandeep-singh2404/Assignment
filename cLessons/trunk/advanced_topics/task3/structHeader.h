
#ifndef _STRUCTHEADER_
#define _STRUCTHEADER_

#define IndexSize 1
#define OverflowSize 1
#define BucketSize 1
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
        char *address;
    }Bucket;
    
/*
    An index structure. 
    Contains: 
    1. int id
    2. array of structs (bucket)
*/

    typedef struct index_str{
        Bucket *bucket;
        Bucket *overflow;
    }Index;
    
    Index *myIndex;
#endif