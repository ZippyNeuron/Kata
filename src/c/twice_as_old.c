#include <stdio.h>
#include <stdlib.h>

int twice_as_old (int father_age, int son_age);

int main() {
    printf("%d\n", twice_as_old(36, 7));
    return 0;
}

int twice_as_old (int father_age, int son_age) {
    return abs(father_age - son_age * 2);
}