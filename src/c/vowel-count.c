#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <sys/types.h>

char * vowels = "aeiou";

int isvowel(char c) {
    extern char * vowels;
    
    return strchr(vowels, c) != NULL ? 1 : 0;
}

int main() {
    char * line_buffer = NULL;
    size_t line_length = 0;
    ssize_t read_count = 0;
 
    int vowel_count = 0;

    while((read_count = getline(&line_buffer, &line_length, stdin)) != EOF) {
        for(size_t i = 0; i < read_count; i++)
            vowel_count += isvowel(tolower(line_buffer[i]));
    }

    printf("%d\n", vowel_count);

    return 0;
}