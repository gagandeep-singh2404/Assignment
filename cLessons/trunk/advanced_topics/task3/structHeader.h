
#ifndef _STRUCTHEADER_
#define _STRUCTHEADER_

// How many Buckets should be there
#define NumberOfOverflow 1
#define NumberOfBuckets 1

// The length of the array 
#define OvIndex 0
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
        Bucket *bucket[BucketSize];
        Bucket *overflow[OvIndex+1];
    }Index;


    Index *myIndex;
#endif