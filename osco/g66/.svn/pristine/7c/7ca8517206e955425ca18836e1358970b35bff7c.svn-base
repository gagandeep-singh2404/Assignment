#include "ntk.h"
#include "ntk.c"


main() {
int par;
startNTK();
task* t1=(task*)malloc(sizeof(task));
create_task(t1,printf("hello world"),&par,sizeof(int),0);
printTaskCB(t1);
printTIB();
delete_task(t1);
free(t1);