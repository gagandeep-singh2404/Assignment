#include "header.h"

typedef struct process
{
    char name;
    int arrival;
    int service;
    int completion;
} process;

process *processes;

void FIFO()
{
    int time = 0;
    int toRun = 0;
    while (1)
    {
        printf("%d:%c\n", time, processes[toRun].name);
        processes[toRun].service--;
        time++;
        if (processes[toRun].service == 0)
        {
            processes[toRun].completion = time;
            toRun++;
        }
        if (toRun == NR_PROCESSES)
        {
            break;
        }
    }
}

void RR()
{
    int time = 0;
    int toRun = 0;
    int nr_finished = 0;
    for (int i = 0; i < 30; i++)
    {
        printf("%d:%c\n", time, processes[toRun].name);
        processes[toRun].service--;
        time++;
        //check if process is finished
        if (processes[toRun].service == 0)
        {
            processes[toRun].completion = time;
            nr_finished++;
        }
        //done if all processes are finished
        if (nr_finished == NR_PROCESSES)
        {
            break;
        }
        //find next process
        int j = toRun + 1;
        while (1)
        {
            if (j == NR_PROCESSES)
            {
                j = 0;
            }
            else
            {
                j++;
            }
            if (processes[j].arrival <= time && processes[j].completion == 0)
            {
                toRun = j;
                break;
            }
        }
    }
}

void SRT()
{
    int time = 0;
    int toRun = 0;
    int nr_finished = 0;
    for (int i = 0; i < 30; i++)
    {
        printf("%d:%c\n", time, processes[toRun].name);
        processes[toRun].service--;
        time++;
        //check if process is finished
        if (processes[toRun].service == 0)
        {
            processes[toRun].completion = time;
            nr_finished++;
        }
        //done if all processes are finished
        if (nr_finished == NR_PROCESSES)
        {
            break;
        }
        //find next process
        int shortestTime = processes[toRun].service;
        if (shortestTime == 0)
        {
            //in case current process is done
            shortestTime = 100;
        }
        int j = toRun;
        while (1)
        {
            if (j == NR_PROCESSES)
            {
                j = 0;
            }
            else
            {
                j++;
            }
            if (processes[j].arrival <= time && processes[j].completion == 0 && processes[j].service <= shortestTime)
            {
                shortestTime = processes[j].service;
                toRun = j;
            }
            if (j == toRun)
            {
                break;
            }
        }
    }
}

void printResult()
{
    int avgTurnTime = 0;
    for (int i = 0; i < NR_PROCESSES; i++)
    {
        int turnTime = processes[i].completion - processes[i].arrival;
        printf("Turnaround time for process %c:%d\n", processes[i].name, turnTime);
        avgTurnTime = avgTurnTime + turnTime;
    }
    avgTurnTime = avgTurnTime / NR_PROCESSES;
    printf("Avarage turn around time:%d\n", avgTurnTime);
    free(processes);
}