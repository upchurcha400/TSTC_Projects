#include <stdio.h>

int main()
{
    //Costant float values of menu items, less 2.5 mark-up
    const float southernBurritoCost = 5.19;
    const float chickenBroccoliRiceCost = 5.19;
    const float tonysAmazingPizzaCost = 6.39;
    const float steakEggCheeseCost = 6.39;
    const float beefFajitaPlatterCost = 6.39;
    const float bigBaconCost = 5.99;
    const float sleeperBurritoCost = 7.99;
    const float taxRate = 0.0825;

    //These are the quantity multipliers for my cost calculations
    int southernBurritoQty;
    int chickenBroccoliRiceQty;
    int tonysAmazingPizzaQty;
    int steakEggCheeseQty;
    int beefFajitaPlatterQty;
    int bigBaconQty;
    int sleeperBurritoQty;

    // User input sections to get order info.
    printf("How many Southern Breakfast Burrito would you like? ");
    scanf_s("%d", &southernBurritoQty);

    printf("How many Chicken Broccoli and Cheesy Rice Burritos would you like? ");
    scanf_s("%d", &chickenBroccoliRiceQty);

    printf("How many Tony's Amazing Pizza Burritos would you like? ");
    scanf_s("%d", &tonysAmazingPizzaQty);

    printf("How many Steak, Egg, and Cheese Burritos would you like? ");
    scanf_s("%d", &steakEggCheeseQty);

    printf("How many Beef Fajita Platter Burritos would you like? ");
    scanf_s("%d", &beefFajitaPlatterQty);

    printf("How many The Big Bacon Burritos would you like? ");
    scanf_s("%d", &bigBaconQty);

    printf("How many The Sleeper Burrito would you like? ");
    scanf_s("%d", &sleeperBurritoQty);

    // Clear the screen trick I learned in Lecture Video. Nice and tidy.
    system("cls");

    // Now there is the extremely long math problems with the extremely long variable names I picked.
    // I didn't think out all the typing this would bring!
    float southernBurritoTotal = southernBurritoCost * southernBurritoQty;
    float chickenBroccoliRiceTotal = chickenBroccoliRiceCost * chickenBroccoliRiceQty;
    float tonysAmazingPizzaTotal = tonysAmazingPizzaCost * tonysAmazingPizzaQty;
    float steakEggCheeseTotal = steakEggCheeseCost * steakEggCheeseQty;
    float beefFajitaPlatterTotal = beefFajitaPlatterCost * beefFajitaPlatterQty;
    float bigBaconTotal = bigBaconCost * bigBaconQty;
    float sleeperBurritoTotal = sleeperBurritoCost * sleeperBurritoQty;

    // My subtotal formula
    float subtotal = southernBurritoTotal + chickenBroccoliRiceTotal + tonysAmazingPizzaTotal +
        steakEggCheeseTotal + beefFajitaPlatterTotal + bigBaconTotal + sleeperBurritoTotal;

    // Gotta pay Uncle Sam his cut
    float tax = subtotal * taxRate;

    // Calculated total cost for order + tax
    float grandTotal = subtotal + tax;

    // This should display on a clear screen
    // Output of order summary with calculations 
    printf("Southern Breakfast Burrito - %d at a cost of $%.2f each for a total order of $%.2f\n",
        southernBurritoQty, southernBurritoCost, southernBurritoTotal);
    printf("Chicken Broccoli and Cheesy Rice Burritos - %d at a cost of $%.2f each for a total order of $%.2f\n",
        chickenBroccoliRiceQty, chickenBroccoliRiceCost, chickenBroccoliRiceTotal);
    printf("Tony's Amazing Pizza Burritos - %d at a cost of $%.2f each for a total order of $%.2f\n",
        tonysAmazingPizzaQty, tonysAmazingPizzaCost, tonysAmazingPizzaTotal);
    printf("Steak, Egg, and Cheese Burritos - %d at a cost of $%.2f each for a total order of $%.2f\n",
        steakEggCheeseQty, steakEggCheeseCost, steakEggCheeseTotal);
    printf("Beef Fajita Platter Burritos - %d at a cost of $%.2f each for a total order of $%.2f\n",
        beefFajitaPlatterQty, beefFajitaPlatterCost, beefFajitaPlatterTotal);
    printf("The Big Bacon Burritos - %d at a cost of $%.2f each for a total order of $%.2f\n",
        bigBaconQty, bigBaconCost, bigBaconTotal);
    printf("The Sleeper Burrito - %d at a cost of $%.2f each for a total order of $%.2f\n",
        sleeperBurritoQty, sleeperBurritoCost, sleeperBurritoTotal);

    printf("\nTotal Price for Entree Reorder is $%.2f\n", subtotal);
    printf("===============================================================================\n");

    printf("\nSubtotal Price for order is $%.2f\n", subtotal);
    printf("Tax is $%.2f\n", tax);
    printf("Grand Total is $%.2f\n", grandTotal);

    return 0;
}
