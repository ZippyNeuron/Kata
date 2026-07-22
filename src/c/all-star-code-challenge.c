#include <stdio.h>
#include <string.h>
#include <ctype.h>
#include <sys/types.h>

char no_repeat(const char *string)
{
    const char
        start_char = 'a', 
        end_char = 'z',
        term_char = '\0';

    size_t input_length = strlen(string);
 
    if (input_length == 0)
        return term_char;

    int letter_counts[end_char - start_char + 1] = {};

    for(int i = 0; i < input_length; i++) {
        int index = ((char)tolower(string[i])) - start_char;

        if (index >= 0 && index < input_length) {
            letter_counts[index]++;
        }
    }

    for(int i = 0; i < input_length; i++) {
        int index = tolower(string[i]) - start_char;

        if (letter_counts[index] == 1)
            return start_char + index;
    }

    return term_char;
}

int main(int argc, char * argv[]) {
    if (argc != 2)
        return 0;

    printf("%c\n", no_repeat(argv[1]));

    return 0;
}