
#include "structHeader.h"
#include "functionHeader.h"
#include "source.c"

int main(){
    init();
    add(4);
    for(int i = 0; i < IndexSize; i++)
    {
        if (myIndex[i] == NULL) {
            printf("an der stelle nicht null %d\n",i);
        }
        
    }
    
    return 0;
}