#include <stdio.h>

#define MAXINPUTLENGTH 128
#define RETURN 10
#define NULLTERMINATOR 0
#define NULLTERMINATORLEN 1

const char *get_day(int day_number);

char *day_names[] = {
    "Sunday",
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday"
};

int main() {
    printf("%s\n", get_day(1));
    return 0;
}

const char *get_day(int day_number) {
    if (day_number < 1 || day_number > 7)
        return "Wrong, please enter a number between 1 and 7";
    
    return day_names[day_number - 1];
}