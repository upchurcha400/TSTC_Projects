//Anthony Upchurch
// 11/09/2024
// ITSE 1302
// The multi-guest menu program for The Flying Burrito restaurant


#include <stdio.h>
#include <stdlib.h>

int main() {
    // All the variables here this time
    int drinkChoice;
    int appetizerChoice;
    int entreeChoice;
    int dessertChoice;
    int tipChoice;

    // Initialize variables
    int partySize = 0;
    float drinkPrice = 0;
    float appetizerPrice = 0;
    float entreePrice = 0;
    float dessertPrice = 0;

    float menuTotal = 0; 
    float discount = 0;
    float totalWdisc;
    float taxRate = 0.0825f;
    float taxTotal = 0;
    float billTotal = 0;
    float tip = 0;
    float totalDue;

    // Running totals for each category
    float totalDrinkPrice = 0;
    float totalAppetizerPrice = 0;
    float totalEntreePrice = 0;
    float totalDessertPrice = 0;

    printf("Welcome to The Flying Burrito! How many in your party today?\n");
    scanf_s("%d", &partySize);
    for (int i = 0; i < partySize; i++) {
        printf("Taking order for customer at seat #%d\n", i + 1);
        float subTotal = 0;

        // Drinks Menu
        do {
            printf("\033[38;5;214m");
            printf("Drink Menu\n");
            printf("1 - Dr. Pepper...................................... $ 1.99\n");
            printf("2 - That Other Soda (Coke).......................... $ 1.99\n");
            printf("3 - Peach Tea....................................... $ 2.99\n");
            printf("4 - Fresh Orange Juice (Made Daily!)................ $ 2.99\n");
            printf("5 - Fruit Smoothies................................. $ 3.99\n");
            printf("\n6   ** Go To Appitizer Menu **\n");
            printf("Enter your choice for drink: ");
            printf("\033[37m"); // Set text color to white
            scanf_s("%d", &drinkChoice);

            switch (drinkChoice) {
            case 1: drinkPrice = 1.99f; break;
            case 2: drinkPrice = 1.99f; break;
            case 3: drinkPrice = 2.99f; break;
            case 4: drinkPrice = 2.99f; break;
            case 5: drinkPrice = 3.99f; break;
            case 6: break;
            default: printf("Invalid choice, please try again.\n"); break;
            }
        } while (drinkChoice != 6);
        totalDrinkPrice += drinkPrice;
        subTotal += drinkPrice;

        // Appetizer Menu in bright red
        do {
            printf("\033[91m");
            printf("Appetizer Menu\n");
            printf("1 - Pepperoni Cheese Poppers (10)................... $ 7.00\n");
            printf("2 - Homemade Cheese Sticks Platter (12)............. $ 7.99\n");
            printf("3 - Spinach and Artichoke Dip (with Chips).......... $ 9.99\n");
            printf("4 - Spicy Queso Crock (endless Chips!).............. $12.99\n");
            printf("5 - Fried Broccoli Cheese Bites (20)................ $10.99\n");
            printf("\n6 - ** Go To Entree Menu **\n");
            printf("Enter your choice for appetizer: ");
            printf("\033[37m"); // Set text color to white
            scanf_s("%d", &appetizerChoice);

            switch (appetizerChoice) {
            case 1: appetizerPrice = 7.00f; break;
            case 2: appetizerPrice = 7.99f; break;
            case 3: appetizerPrice = 9.99f; break;
            case 4: appetizerPrice = 12.99f; break;
            case 5: appetizerPrice = 10.99f; break;
            case 6: break;
            default: printf("Invalid choice, please try again.\n"); break;
            }
        } while (appetizerChoice != 6);
        totalAppetizerPrice += appetizerPrice;
        subTotal += appetizerPrice;

        // Entree Menu in bright yellow
        do {
            printf("\033[93m");
            printf("Entree Menu\n");
            printf("1 - Southern Breakfast Burrito (1).................. $12.99\n");
            printf("2 - Chicken Broccoli and Cheesy Rice Burritos (2)... $12.99\n");
            printf("3 - Tony's Amazing Pizza Burritos(2)................ $15.99\n");
            printf("4 - Steak, Egg, and Cheese Burritos (2)............. $15.99\n");
            printf("5 - Beef Fajita Platter Burritos (2)................ $15.99\n");
            printf("6 - The Big Bacon Burritos (2)...................... $14.99\n");
            printf("7 - The Sleeper Burrito (2)......................... $19.99\n");
            printf("\n8 - ** Go To Desserts Menu **\n");
            printf("Enter your choice for entree: ");
            printf("\033[37m"); // Set text color to white
            scanf_s("%d", &entreeChoice);

            switch (entreeChoice) {
            case 1: entreePrice = 12.99f; break;
            case 2: entreePrice = 12.99f; break;
            case 3: entreePrice = 15.99f; break;
            case 4: entreePrice = 15.99f; break;
            case 5: entreePrice = 15.99f; break;
            case 6: entreePrice = 14.99f; break;
            case 7: entreePrice = 19.99f; break;
            case 8: break;
            default: printf("Invalid choice, please try again.\n"); break;
            }
        } while (entreeChoice != 8);
        totalEntreePrice += entreePrice;
        subTotal += entreePrice;

        // Desserts
        do {
            printf("\033[94m");
            printf("Dessert Menu\n");
            printf("1 - Black Pearl Cake (thick sliced)................. $ 5.99\n");
            printf("2 - Orange Zing Cake (thick sliced)................. $ 5.99\n");
            printf("3 - Homemade Buttermilk Pie......................... $ 5.99\n");
            printf("4 - Pineapple Cake (w/ Pineapple Ice Cream)......... $ 7.99\n");
            printf("\n5 - ** Complete This Order **\n");
            printf("Enter your choice for dessert: ");
            printf("\033[37m"); // Set text color to white
            scanf_s("%d", &dessertChoice);

            switch (dessertChoice) {
            case 1: dessertPrice = 5.99f; break;
            case 2: dessertPrice = 5.99f; break;
            case 3: dessertPrice = 5.99f; break;
            case 4: dessertPrice = 7.99f; break;
            case 5: break;
            default: printf("Invalid choice, please try again.\n"); break;
            }
        } while (dessertChoice != 5);
        totalDessertPrice += dessertPrice;
        subTotal += dessertPrice;

        // Accumulate the subTotal
        menuTotal += subTotal;
		system("cls"); // Clear the screen for the next customer
    }

    // Clear the screen once all customers' orders are done
    system("cls");

    // Calculate total of just the food and drink
    menuTotal = totalDrinkPrice + totalAppetizerPrice + totalEntreePrice + totalDessertPrice;

    // Display a discount message
    printf("The Flying Burrito is offering a discount to its customers!\n");
    printf("Press any key to Spin the wheel to get your discount percentage...\n");
    getchar();
    getchar(); //The spin effect!  
    srand(time(NULL));

    // Generate a random discount 
    int discountPercentage = (rand() % 20) + 1;
    printf("Congratulations! You got a %d%% discount!\n", discountPercentage);

    // Calculate discount amount
    discount = menuTotal * (discountPercentage / 100.0f);

    // Calculate total after Discount
    totalWdisc = menuTotal - discount;

    // Calculate tax after discount applied
    taxTotal = totalWdisc * taxRate;

    // Calculate total before tip
    billTotal = totalWdisc + taxTotal;

    // Get tip choice from customer in money color
    printf("\033[92m");
    printf("Choose a tip percentage:\n");
    printf("1 - 15%%\n");
    printf("2 - 18%%\n");
    printf("3 - 25%%\n");
    printf("4 - 30%%\n");
    printf("Enter your choice for tip: ");
    printf("\033[37m"); // Set text color to white
    scanf_s("%d", &tipChoice);

    // Switch to apply the tip rate
    switch (tipChoice) {
    case 1: tip = billTotal * 0.15f; break;
    case 2: tip = billTotal * 0.18f; break;
    case 3: tip = billTotal * 0.25f; break;
    case 4: tip = billTotal * 0.30f; break;
    }

    // Calculate total due for customer
    totalDue = billTotal + tip;

    // Clear the screen for my awesome art
    system("cls");

    // Display the Receipt in US Flag colors
    printf("\033[33m"); // Yellow
    printf("\n                The Flying Burrito\n");
    printf("\033[31m"); // Red
    printf("        ====================================\n");
    printf("        Drink: . . . . . . . . . . . .$ %.2f\n", totalDrinkPrice);
    printf("        Appetizer: . . . . . . . . . .$ %.2f\n", totalAppetizerPrice);
    printf("        Entree:  . . . . . . . . . . .$%.2f\n", totalEntreePrice);
    printf("\033[37m"); // White
    printf("        Dessert: . . . . . . . . . . .$ %.2f\n", totalDessertPrice);
    printf("        Sub Total: . . . . . . . . . .$%.2f\n", menuTotal);
    printf("        Discount: . . . . . . . . . - $ %.2f\n", discount);
    printf("        Total: . . . . . . . . . . . .$%.2f\n", totalWdisc);
    printf("\033[34m"); // Blue
    printf("        Tax: . . . . . . . . . . . . .$ %.2f\n", taxTotal);
    printf("        Bill Total:  . . . . . . . . .$%.2f\n", billTotal);
    printf("        Tip: . . . . . . . . . . . . .$ %.2f\n", tip);
    printf("        Total Due: . . . . . . . . . .$%.2f\n", totalDue);

    // Adding some dramatic effect
    printf("\n\n\n\n\n\n\n\n");
    // ASCII Art i found a text art generator www.patorjk.com/software/taag/#p=display&f=Big&t=7HE----%3E%20%0AFLYiNG--%3E%20%0ABuRRit0-%3E
    printf("\033[31m"); // Red
    printf("  ______ _    _ ______                        __     \n");
    printf(" |____  | |  | |  ____|                       \\ \\    \n");
    printf("     / /| |__| | |__ ______ ______ ______ _____\\ \\   \n");
    printf("    / / |  __  |  __|______|______|______|______> >  \n");
    printf("   / /  | |  | | |____                         / /   \n");

    printf("\033[38;5;214m"); // Orange
    printf("  /_/___|_| _|_|______|_   _  _____           /_/    \n");
    printf(" |  ____| | \\ \\   / (_) \\ | |/ ____|           \\ \\   \n");
    printf(" | |__  | |  \\ \\_/ / _|  \\| | |  __ ______ _____\\ \\  \n");
    printf(" |  __| | |   \\   / | | . ` | | |_ |______|______> > \n");
    printf(" | |    | |____| |  | | |\\  | |__| |            / /  \n");

    printf("\033[35m"); // Magenta
    printf(" |_|__  |______|_|_ |_|_|_\\_\\_____|__      __ /_/   \n");
    printf(" |  _ \\      |  __ \\|  __ \\(_) |  / _ \\     \\ \\     \n");
    printf(" | |_) |_   _| |__) | |__) |_| |_| | | |_____\\ \\    \n");
    printf(" |  _ <| | | |  _  /|  _  /| | __| | | |______> >   \n");
    printf(" | |_) | |_| | | \\ \\| | \\ \\| | |_| |_| |     / /    \n");
    printf(" |____/ \\__,_|_|  \\_\\_|  \\_\\_|\\__|\\___/     /_/    \n");

    printf("\033[0m"); // Reset to default color

    return 0;
}