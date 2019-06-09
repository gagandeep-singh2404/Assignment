#include <stdio.h>
#include "node.h"
#define TICKS 25
#define N 5
#define Q 1

process processes[N];
int processesIndex = 0;
process* readyQueue[N];
int readyIndex = 0;
int readyTail = 0;
int readyHead = 0;
int currentTick = 0;

void createProcesses();
void checkForLoadingProcesses();
void doProgress();
void printResult();
void handle();

void FCFS();
void RR();

int main(int argc, char* argv[], char* envp[]) {
    createProcesses();
    printResult();
    for (currentTick = 0; currentTick < TICKS; currentTick++) {
        if (readyIndex < N) {
            //printf("ri: %d, checking for loading processes:\n", readyIndex);
            checkForLoadingProcesses();
            //printf("ri: %d, handling:\n", readyIndex);
            handle();
            //printf("ri: %d, progressing:\n", readyIndex);
            doProgress();
        } else {
            printf("   ");
        }
    }
    printf("\n");
    return 0;
}

void createProcesses() {
    processes[0] = getProcess(0, 0, 5);
    processes[1] = getProcess(1, 3, 4);
    processes[2] = getProcess(2, 6, 5);
    processes[3] = getProcess(3, 8, 2);
    processes[4] = getProcess(4, 9, 3);
    for (int i = 0; i < N; i++) {
        printProcess(&processes[i]);
    }
    printf("\n");
}

void checkForLoadingProcesses() {
    if (currentTick == processes[processesIndex].arrivalTime) {
        readyQueue[readyTail] = &processes[processesIndex];
        // ready tail points to next free space.
        readyTail++;
        // processesIndex points to next process to load.
        processesIndex++;
    }
}

void doProgress() {
    if (readyIndex < N) {
        readyQueue[readyIndex]->progress++;
        printf("%2d ", readyQueue[readyIndex]->id);
    } else {
        printf("   ");
    }
}

void handle() {
    //FCFS();
    RR();
}

void FCFS() {
    // checking if frontmost process is done.
    if (readyQueue[readyHead]->progress >= readyQueue[readyHead]->serviceTime) {
        // "shrinking" queue and setting next process active.
        readyHead++;
        readyIndex++;
    }
}

void RR() {
    int done = -1;
    do {
        done++;
        readyIndex++;
        if (readyIndex >= readyTail) {
            readyIndex = 0;
        }
    } while (readyQueue[readyIndex]->progress >= readyQueue[readyIndex]->serviceTime && done < N);
    if (done >= N) {
        readyIndex = N + 1;
    }
}

void printResult() {
    for (int i = 0; i < TICKS; i++) {
        printf("%2d ", i);
    }
    printf("\n");
}