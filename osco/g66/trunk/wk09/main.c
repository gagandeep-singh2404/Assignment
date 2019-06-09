#include <stdio.h>

int main(int argc, const char *argv[])
{

    int headPos = 100;
    int tasks[] = {55, 58, 39, 18, 90, 160, 150, 38, 184};
    int time = 0;

    // for (int i = 0; i < 9; i++)
    // {
    //     if (headPos > tasks[i])
    //     {
    //         time += headPos - tasks[i];
    //         headPos = tasks[i];
    //     }
    //     else
    //     {
    //         time += tasks[i] - headPos;
    //         headPos = tasks[i];
    //     }
    // }

    // printf("%s%d\n", "Ammount of movement for FIFO: ", time);

    int pos = 0;
    int direction = 1;
    time = 0;
    headPos = 100;

    while (pos != 9)
    {
        if (headPos == 200)
            direction = -1;
        if (headPos == 0)
            direction = 1;
        if (headPos == tasks[pos])
        {
            printf("bin hier drin %d\n", tasks[pos]);
            pos++;
        }
        // printf("Vorher: %d\n", headPos);
        headPos += direction;
        // printf("%d\n", headPos);
        time++;
    }
    printf("%s%d\n", "Ammount of Movement needed for Scan: ", time);

    return 0;
}
