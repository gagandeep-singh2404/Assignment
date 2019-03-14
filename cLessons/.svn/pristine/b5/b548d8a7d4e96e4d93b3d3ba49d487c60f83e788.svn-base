#include <stdio.h>
#include "stringlist.h"
#include "stringlist.c"

int main(int argc, char* argv[]) {
    s_node *list = init();
    printf("size of snode: %lu\n", sizeof(s_node));
    add(list, "Gagan");
    add(list, "Tom ");
    add(list, "Anja");
    print(list);

    myDelete(list,3);
    myRead(list,1);
    print(list);
    add(list,"Anja");
    print(list);
    clear(list);
    return 0;
}
