#include <stdio.h>
#include <stdlib.h>

int main() {

    int colpicked;
    int nameCol;
    int triCol;
    int recCol;


    // Display a menu of the color choices 
    printf("Choose a color by entering the corresponding number:\n");
    printf("1. Red\n2. Green\n3. Yellow\n4. Blue\n5. Magenta\n6. Cyan\n7. White\n8. Default\n");


    // Ask for the color for the name
    printf("Pick a color for your name: ");
    scanf_s("%d", &colpicked);
    nameCol = colpicked;


    // and a color for the triangle
    printf("\nPick a color for the triangle: ");
    scanf_s("%d", &colpicked);
    triCol = colpicked;


    // and a color for the  rectangle
    printf("\nPick a color for the rectangle: ");
    scanf_s("%d", &colpicked);
    recCol = colpicked;


    // Display name in color picked
    switch (nameCol) {
    case 1: printf("\033[0;31m"); break; // Red
    
    case 2: printf("\033[0;32m"); break; // Green text
    
    case 3: printf("\033[0;33m"); break; // Yellow text
    
    case 4: printf("\033[0;34m"); break; // Blue text
    
     case 5: printf("\033[0;35m"); break; // Magenta text
    
    case 6: printf("\033[0;36m"); break; // Cyan text
    
    case 7: printf("\033[0;37m"); break; // White text
    
    default: printf("\033[0m"); break; // The default text color
    }


    printf("\n");
    printf("Anthony Upchurch\n");
    printf("\033[0m"); // The default text color is back


    // Display triangle color picked
    switch (triCol) {
    case 1: printf("\033[0;31m"); break; // Red

    case 2: printf("\033[0;32m"); break; // Green text

    case 3: printf("\033[0;33m"); break; // Yellow text

    case 4: printf("\033[0;34m"); break; // Blue text

    case 5: printf("\033[0;35m"); break; // Magenta text

    case 6: printf("\033[0;36m"); break; // Cyan text

    case 7: printf("\033[0;37m"); break; // White text

    default: printf("\033[0m"); break; // The default text color is back
    }
    
    
    printf("\n");
    printf("  *  \n");
    printf(" *** \n");
    printf("*****\n");
    printf("\033[0m"); // The default text color is back

    
    
    // Display rectangle in chosen color
    switch (recCol) {
    case 1: printf("\033[0;31m"); break; // Red

    case 2: printf("\033[0;32m"); break; // Green text

    case 3: printf("\033[0;33m"); break; // Yellow text

    case 4: printf("\033[0;34m"); break; // Blue text

    case 5: printf("\033[0;35m"); break; // Magenta text

    case 6: printf("\033[0;36m"); break; // Cyan text

    case 7: printf("\033[0;37m"); break; // White text

    default: printf("\033[0m"); break; // The default text color
    }
    
    
    printf("\n");
    printf("*****\n");
    printf("*****\n");
    printf("*****\n");
    printf("\033[0m"); // The default text color is back

    return 0;
}