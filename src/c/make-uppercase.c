#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <ctype.h>

const char * to_uppercase(char *value);

int main() {   
    char value[] = "abcABC1234@@@@###";
    printf("%s\n", to_uppercase(value));
    return 0;
}

const char * to_uppercase(char *string) {
    for (int i = 0; i < strlen(string); i++)
        string[i] = toupper(string[i]);

    return string;
}