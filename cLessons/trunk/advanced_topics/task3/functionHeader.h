#ifndef _FUNCTIONHEADER_
#define _FUNCTIONHEADER_

#include <stdbool.h>
/*
    initialize the Index structure 
    set the sizes for Overflow and Bucket

*/
void init();


/*
    delete a object from the Bucket or Overflow
    (Also json ?)
*/
bool myDelete(int id);

/*
    read the data of a stored object
*/
bool myRead(char * name);

void addObject(Bucket * bucket);

int calculateKey(char* name);
#endif