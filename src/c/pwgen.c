#include "pwgen.h"
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <time.h>

#define MIN_ARG_COUNT 2
#define ARG_PWDLENGTH 1

static int bankrand(char *bank);
static int banklen(char * bank);
static char bankchar(char *bank);

const char * program = "PwGen";
const char * program_version = "1.0";
const char * program_contact = "ZippyNeuron";

char *bank_uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
char *bank_lowercase = "abcdefghijklmnopqrstuvwxyz";
char *bank_numbers = "1234567890";
char *bank_symbols = "!@#$%^&*";

int main(int argc, char *argv[]) {
    if (argc < MIN_ARG_COUNT)
        return EXIT_SUCCESS;

    char * arg = argv[ARG_PWDLENGTH];
    
    if (!isdigit(arg[0])) {
        return EXIT_SUCCESS;
    }

    srand(time(NULL));

    int x = strlen(arg);

    int length = atoi(arg);

    printf("%s - %s by %s\n", 
        program, 
        program_version, 
        program_contact);

    char result[length];

    for(int i = 0; i < length - 1; i++) {
        result[i] = bankschar(i);
    }

    return EXIT_SUCCESS;
}

static char bankchar(char *bank) {
    return bank[bankrand(bank)];
}

static int bankrand(char *bank) {
    return rand() % banklen(bank);
}

static int banklen(char *bank) {
    return strlen(bank);
}

static char banksrand(int pos) {
    int r = rand() % 3;

    switch(r) {
        case 0:
            return bankrand(bank_lowercase);
            break;
        case 1:
            return bankrand(bank_uppercase);
            break;
        case 2:
            return bankrand(bank_numbers);
            break;
        case 3:
            return bankrand(bank_symbols);
            break;
    }
}