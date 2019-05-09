#include "ntk.h"

unsigned __stdcall tascCode(void* args);
unsigned __stdcall tascCode2(void* args);
void task2();
void task3();


void increasAndDecrease();



int main(void) {
	int par = 5;
	startNTK();
	task* t1 = (task*)malloc(sizeof(task));
	create_task(t1, tascCode, &par, sizeof(int), 0);
	Sleep(1000);
	task2();
	task3();
	void increaserAndDecrease();

	return 0;

}

unsigned __stdcall tascCode(void* args) {
	task* t1 = (task*)args;
	int* a = (int*)getArgument_task(t1);
	Sleep(a[0]*1000);
	
	return 0;

}

void task2() {
	int par;
	for (int i = 5; i > 0; i--)
	{
		par = i;
		task* t1 = (task*)malloc(sizeof(task));
		create_task(t1, tascCode, &par, sizeof(int), 0);
	}


	void task3() {
		int par;
		for (int i = 0; i < 1000; i++)
		{
			par = i;
			task* t1 = (task*)malloc(sizeof(task));
			create_task(t1, tascCode2, &par, sizeof(int), 0);
		}
	}


	unsigned __stdcall tascCode2(void* args) {
		task* t1 = (task*)args;
		int* a = (int*)getArgument_task(t1);
		Sleep(500);
		printf("The task ID i: %d" + getTaskId_task(t1));

		return 0;

	}

	void increasAndDecrease() {
		int par = 0;
		task* increase = (task*)malloc(sizeof(task));
		create_task(increase, increaseGlobal, &par, sizeof(int), 0);

		task* decrease = (task*)malloc(sizeof(task));
		setPriority_task(decrease,high);
		create_task(decrease, decreaseGlobal, &par, sizeof(int), 0);

	}
	int decreaseGlobal() {

		while (global != 0) {--global;}
		return 0;
	}
	int increaseGlobal() {

		while (global != 300) {++global;}
		return 0;
	}


}