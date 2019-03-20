
#include "structHeader.h"
#include "functionHeader.h"
#include "source.c"

int main(){
    init();
    add();
    Bucket * bucket = myRead("Tom");
    add();
    bucket = myRead("Alan");
    myDelete("Alan");
    bucket = myRead("Alan");
    return 0;
}