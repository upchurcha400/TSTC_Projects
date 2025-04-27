#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int theAnswer, yourGuess, triesSofar = 0;

    // Start random number generator
    srand(time(0));
    //set the answer to guess
    theAnswer = rand() % 100 + 1;

    printf("Please pick a number between 1 and 100.\n");

    do {
        printf("Enter your guess: ");
        scanf_s("%d", &yourGuess);
        //count the guess it take
        triesSofar++;
        //set up the if wrong code
        if (yourGuess < 1 || yourGuess > 100) {
            printf("Your number is not between 1 and 100, please try again.\n");
            triesSofar--;
        }
        else if (yourGuess < theAnswer) {
            printf("Please pick a higher number.\n");
        }
        else if (yourGuess > theAnswer) {
            printf("Please pick a lower number.\n");
        }
        else {
            printf("You Won! The number was %d! It took you %d attempts.\n", theAnswer, triesSofar);
        }
    } while (yourGuess != theAnswer);

    return 0;
}