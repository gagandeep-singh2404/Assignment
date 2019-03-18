#ifndef _FUNCTIONHEADER_
#define _FUNCTIONHEADER_

#include <stdbool.h>




/*
    initialize the Index structure 
    set the sizes for Overflow and Bucket

*/
void init();

/*
    store new Objects into the Bucket or Overflow
    Also add to a json file
*/
bool addInfo(int id);

/*
    delete a object from the Bucket or Overflow
    (Also json ?)
*/
bool myDelete(int id);

/*
    read the data of a stored object
*/
bool myRead(int id);

void addObject(Bucket * bucket);
#endif