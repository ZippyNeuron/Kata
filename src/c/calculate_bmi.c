#include <stdio.h>

const char * bmi(int weight, double height);

int main() {
    printf("%s\n", bmi(50, 1.80));
    printf("%s\n", bmi(80, 1.80));
    printf("%s\n", bmi(90, 1.80));
    printf("%s\n", bmi(110, 1.80));
    printf("%s\n", bmi(50, 1.50));
    printf("%s\n", bmi(74, 1.72));
    printf("%s\n", bmi(77, 1.74));
}

const char * bmi(int weight, double height)
{
    double bmi = weight / (height * height);

    if (bmi <= 18.5) {
        return "Underweight";
    } else if (bmi > 18.5 && bmi <= 25.0) {
        return "Normal";
    } else if (bmi > 25.0 && bmi <= 30.0) {
        return "Overweight";
    } else if (bmi > 30) {
        return "Obese";
    }

    return "Underweight";
}