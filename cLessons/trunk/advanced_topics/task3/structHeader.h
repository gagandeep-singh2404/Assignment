
#ifndef _STRUCTHEADER_
#define _STRUCTHEADER_

#define IndexSize 2
#define OverflowSize 2
#define BucketSize 2
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

 /*
    An index structure. 
    Contains: 
    1. array of structs (bucket)
 
 */   
    typedef struct over_str{
        int id;
        char *name;
        char* address;
    }Overflow;
    

    typedef struct index_str{
        int id;
        Bucket bucket[BucketSize];
        Overflow overflow[OverflowSize];
    }Index;
    

    Index myIndex[IndexSize];
#endif