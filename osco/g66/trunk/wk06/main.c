#include "ntk.h"

unsigned __stdcall tascCode(void* args);
void part0();

int main(void) {
	int par = 5;
	startNTK();
	task* t1 = (task*)malloc(sizeof(task));
	create_task(t1, tascCode, &par, sizeof(int), 0);
	Sleep(1000);
	part0();
	
	return 0;

}

unsigned __stdcall tascCode(void* args) {
	task* t1 = (task*)args;
	int* a = (int*)getArgument_task(t1);
	Sleep(a[0]*1000);
	
	return 0;

}

void part0() {
	int par;
	for (int i = 5; i > 0; i--)
	{
		par = i;
		task* t1 = (task*)malloc(sizeof(task));
		create_task(t1, tascCode, &par, sizeof(int), 0);
	}
	
}