#include "node.h"
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

process getProcess(int id, int arrival, int service) {
    process* p = (process*)malloc(sizeof(process));
    p->id = id;
    p->arrivalTime = arrival;
    p->serviceTime = service;
    p->progress = 0;
    return *p;
}

void printProcess(process* p) {
    printf("P%-2d A-Time: %-2d S-Time: %-2d\n", p->id, p->arrivalTime, p->serviceTime);
}