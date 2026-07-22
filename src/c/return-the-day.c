#include <stdio.h>

#define STARTDAYOFWEEK 1
#define ENDDAYOFWEEK 7

char *day_names[] = {
    "Sunday",
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday"
};

const char *get_day(int day_number) {
    extern char * day_names[];

    if (day_number < STARTDAYOFWEEK || day_number > ENDDAYOFWEEK)
        return "Wrong, please enter a number between 1 and 7";
    
    return day_names[day_number - 1];
}

int main() {
    printf("%s\n", get_day(1));
    return 0;
}