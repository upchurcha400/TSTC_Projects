/*
Name: Anthony Upchurch
ITSE 1302-7P1
Fall 2024
Date: 12/08/2024
Description of Program: This program simulates a restaurant ordering system and inventory management system. 
It allows users to place orders, journal transactions, and calculate reorder cost for inventory.
*/

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

// Function prototypes
void restaurant();
void inventory();
void print_receipt(float totalDrinkPrice, float totalAppetizerPrice, float totalEntreePrice, float totalDessertPrice, float menuTotal, float discount, float totalWdisc, float taxTotal, float billTotal, float tip, float totalDue);
void random_discount(float* discount);
float subtotal_calculation(float drinkPrice, float appetizerPrice, float entreePrice, float dessertPrice);
float bill_calculation(float discount, float subtotal, float taxRate, int tipChoice, float* tip);
float drink_orders();
float appetizer_orders();
float entree_orders();
float dessert_orders();

int main() {
    char buffer[256];
    FILE* welcomeFile;

    // open the welcome.txt file and read the welcome message
    if (fopen_s(&welcomeFile, "welcome.txt", "r") != 0) {
        printf("Error opening welcome.txt file.\n");
        return 1;
    }

    // Read and print the contents of the file
    while (fgets(buffer, sizeof(buffer), welcomeFile) != NULL) {
        printf("%s", buffer);
    }

    // Close the file
    fclose(welcomeFile);

    int choice;
    do {
        printf("\nMain Menu:\n");
        printf("1 - Restaurant\n");
        printf("2 - Inventory\n");
        printf("3 - Exit\n");
        printf("Enter your choice: ");
        scanf_s("%d", &choice);

        switch (choice) {
        case 1:
            restaurant();
            break;
        case 2:
            inventory();
            break;
        case 3:
            printf("Exiting the program.\n");
            break;
        default:
            printf("Invalid choice, please try again.\n");
            break;
        }
    } while (choice != 3);

    return 0;
}

// here is the restaurant function for ordering food
void restaurant() {
    int tipChoice;
    int partySize = 0;
    float totalDrinkPrice = 0, totalAppetizerPrice = 0, totalEntreePrice = 0, totalDessertPrice = 0;
    float discount = 0, totalWdisc, taxRate = 0.0825f, taxTotal, billTotal, tip = 0, totalDue;

    printf("Welcome to The Flying Burrito! How many in your party today?\n");
    scanf_s("%d", &partySize);
    for (int i = 0; i < partySize; i++) {
        printf("Taking order for customer at seat #%d\n", i + 1);
        float subTotal = 0;

        totalDrinkPrice += drink_orders();
        totalAppetizerPrice += appetizer_orders();
        totalEntreePrice += entree_orders();
        totalDessertPrice += dessert_orders();

        subTotal = subtotal_calculation(totalDrinkPrice, totalAppetizerPrice, totalEntreePrice, totalDessertPrice);
        system("cls"); // Clear the screen for the next customer
    }

    // Clear the screen once all customers' orders are done
    system("cls");

    // Display a discount message
    printf("The Flying Burrito is offering a discount to its customers!\n");
    printf("Press any key to Spin the wheel to get your discount percentage...\n");
    (void)getchar();
    int ch = getchar(); // The spin effect!

    random_discount(&discount);

    // calculate total of just the food and drink
    float menuTotal = subtotal_calculation(totalDrinkPrice, totalAppetizerPrice, totalEntreePrice, totalDessertPrice);

    // calculate total after Discount
    totalWdisc = menuTotal - (menuTotal * discount);

    //Discount amount in dollar form (finally fixed it)
    float discountDollarValue;
    discountDollarValue = menuTotal - totalWdisc;


    // calculate tax after discount applied
    taxTotal = totalWdisc * taxRate;

    // calculate total before tip
    billTotal = totalWdisc + taxTotal;

    // Get tip choice from customer
    printf("Choose a tip percentage:\n");
    printf("1 - 15%%\n");
    printf("2 - 18%%\n");
    printf("3 - 25%%\n");
    printf("4 - 30%%\n");
    printf("Enter your choice for tip: ");
    scanf_s("%d", &tipChoice);

    // calculate total due for customer
    totalDue = bill_calculation(discount, menuTotal, taxRate, tipChoice, &tip);

    // Clear the screen for my awesome art
    system("cls");

	// passing arguments to print the receipt to a file
    print_receipt(totalDrinkPrice, totalAppetizerPrice, totalEntreePrice, totalDessertPrice, menuTotal, discountDollarValue, totalWdisc, taxTotal, billTotal, tip, totalDue);
}

// function to print the receipt to a file
void print_receipt(float totalDrinkPrice, float totalAppetizerPrice, float totalEntreePrice, float totalDessertPrice, float menuTotal, float discountDollarValue, float totalWdisc, float taxTotal, float billTotal, float tip, float totalDue) {
    FILE* receiptFile;
    
    // open the receipt.txt file for writing using append to keep a old school receipt journal
    if (fopen_s(&receiptFile, "receipt.txt", "a") != 0) {
        printf("Error opening receipt.txt file.\n");
        return;
    }

    fprintf(receiptFile, "\n                The Flying Burrito\n");
    fprintf(receiptFile, "        ====================================\n");
    fprintf(receiptFile, "        Drink: . . . . . . . . . . . .$ %.2f\n", totalDrinkPrice);
    fprintf(receiptFile, "        Appetizer: . . . . . . . . . .$ %.2f\n", totalAppetizerPrice);
    fprintf(receiptFile, "        Entree:  . . . . . . . . . . .$%.2f\n", totalEntreePrice);
    fprintf(receiptFile, "        Dessert: . . . . . . . . . . .$ %.2f\n", totalDessertPrice);
    fprintf(receiptFile, "        Sub Total: . . . . . . . . . .$%.2f\n", menuTotal);
    fprintf(receiptFile, "        Discount: . . . . . . . . . - $ %.2f\n", discountDollarValue);
    fprintf(receiptFile, "        Total: . . . . . . . . . . . .$%.2f\n", totalWdisc);
    fprintf(receiptFile, "        Tax: . . . . . . . . . . . . .$ %.2f\n", taxTotal);
    fprintf(receiptFile, "        Bill Total:  . . . . . . . . .$%.2f\n", billTotal);
    fprintf(receiptFile, "        Tip: . . . . . . . . . . . . .$ %.2f\n", tip);
    fprintf(receiptFile, "        Total Due: . . . . . . . . . .$%.2f\n", totalDue);

    fclose(receiptFile);
}

// here is the random discount function
void random_discount(float* discount) {
    srand((unsigned int)time(NULL));
    int discountPercentage = (rand() % 20) + 1;
    printf("Congratulations! You got a %d%% discount!\n", discountPercentage);
    *discount = discountPercentage / 100.0f;
}

// here is the subtotal calculation function
float subtotal_calculation(float drinkPrice, float appetizerPrice, float entreePrice, float dessertPrice) {
    return drinkPrice + appetizerPrice + entreePrice + dessertPrice;
}

// here is the bill calculation function
float bill_calculation(float discount, float subtotal, float taxRate, int tipChoice, float* tip) {
    float totalWdisc = subtotal - (subtotal * discount);
    float taxTotal = totalWdisc * taxRate;
    float billTotal = totalWdisc + taxTotal;

    switch (tipChoice) {
    case 1: *tip = billTotal * 0.15f; break;
    case 2: *tip = billTotal * 0.18f; break;
    case 3: *tip = billTotal * 0.25f; break;
    case 4: *tip = billTotal * 0.30f; break;
    default: *tip = 0; break;
    }

    return billTotal + *tip;
}

// here is the drink orders function
float drink_orders() {
    int drinkChoice;
    float drinkPrice = 0;
    do {
        printf("Drink Menu\n");
        printf("1 - Dr. Pepper...................................... $ 1.99\n");
        printf("2 - That Other Soda (Coke).......................... $ 1.99\n");
        printf("3 - Peach Tea....................................... $ 2.99\n");
        printf("4 - Fresh Orange Juice (Made Daily!)................ $ 2.99\n");
        printf("5 - Fruit Smoothies................................. $ 3.99\n");
        printf("\n6   ** Go To Appetizer Menu **\n");
        printf("Enter your choice for drink: ");
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
    return drinkPrice;
}

// here is the appetizer orders function
float appetizer_orders() {
    int appetizerChoice;
    float appetizerPrice = 0;
    do {
        printf("Appetizer Menu\n");
        printf("1 - Pepperoni Cheese Poppers (10)................... $ 7.00\n");
        printf("2 - Homemade Cheese Sticks Platter (12)............. $ 7.99\n");
        printf("3 - Spinach and Artichoke Dip (with Chips).......... $ 9.99\n");
        printf("4 - Spicy Queso Crock (endless Chips!).............. $12.99\n");
        printf("5 - Fried Broccoli Cheese Bites (20)................ $10.99\n");
        printf("\n6 - ** Go To Entree Menu **\n");
        printf("Enter your choice for appetizer: ");
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
    return appetizerPrice;
}

//I know my comments are super thrilling... here is the entree orders function
float entree_orders() {
    int entreeChoice;
    float entreePrice = 0;
    do {
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
    return entreePrice;
}

// here is the heavenly dessert orders function
float dessert_orders() {
    int dessertChoice;
    float dessertPrice = 0;
    do {
        printf("Dessert Menu\n");
        printf("1 - Black Pearl Cake (thick sliced)................. $ 5.99\n");
        printf("2 - Orange Zing Cake (thick sliced)................. $ 5.99\n");
        printf("3 - Homemade Buttermilk Pie......................... $ 5.99\n");
        printf("4 - Pineapple Cake (w/ Pineapple Ice Cream)......... $ 7.99\n");
        printf("\n5 - ** Complete This Order **\n");
        printf("Enter your choice for dessert: ");
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
    return dessertPrice;
}

// here is the function I hated making the most... the inventory function
void inventory() {
    // reorder cost of menu items
    const float drinkCosts[] = { 1.42f, 1.42f, 2.14f, 2.14f, 2.85f }; 
    const float appetizerCosts[] = { 5.00f, 5.71f, 7.14f, 9.28f, 7.85f }; 
    const float entreeCosts[] = { 9.28f, 9.28f, 11.42f, 11.42f, 11.42f, 10.71f, 14.28f }; 
    const float dessertCosts[] = { 4.28f, 4.28f, 4.28f, 5.71f }; 

    // The Arrays to store the number of items for reordered
    int drinkOrders[5];
    int appetizerOrders[5];
    int entreeOrders[7];
    int dessertOrders[4];

    // setting the variables to store the total cost for each category
    float drinkTotal = 0, appetizerTotal = 0, entreeTotal = 0, dessertTotal = 0;
	
    printf("Welcome to The Flying Burrito Inventory Management System!\n");


    // get user input for drink quantities
    printf("\nEnter the number of each drink item ordered:\n");
    printf("1 - Dr. Pepper: ");
    scanf_s("%d", &drinkOrders[0]);
    printf("2 - That Other Soda (Coke): ");
    scanf_s("%d", &drinkOrders[1]);
    printf("3 - Peach Tea: ");
    scanf_s("%d", &drinkOrders[2]);
    printf("4 - Fresh Orange Juice (Made Daily!): ");
    scanf_s("%d", &drinkOrders[3]);
    printf("5 - Fruit Smoothies: ");
    scanf_s("%d", &drinkOrders[4]);

    // get user input for appetizer quantities
    printf("\nEnter the number of each appetizer item ordered:\n");
    printf("1 - Pepperoni Cheese Poppers (10): ");
    scanf_s("%d", &appetizerOrders[0]);
    printf("2 - Homemade Cheese Sticks Platter (12): ");
    scanf_s("%d", &appetizerOrders[1]);
    printf("3 - Spinach and Artichoke Dip (with Chips): ");
    scanf_s("%d", &appetizerOrders[2]);
    printf("4 - Spicy Queso Crock (endless Chips!): ");
    scanf_s("%d", &appetizerOrders[3]);
    printf("5 - Fried Broccoli Cheese Bites (20): ");
    scanf_s("%d", &appetizerOrders[4]);

    // get user input for entree quantities
    printf("\nEnter the number of each entree item ordered:\n");
    printf("1 - Southern Breakfast Burrito (1): ");
    scanf_s("%d", &entreeOrders[0]);
    printf("2 - Chicken Broccoli and Cheesy Rice Burritos (2): ");
    scanf_s("%d", &entreeOrders[1]);
    printf("3 - Tony's Amazing Pizza Burritos(2): ");
    scanf_s("%d", &entreeOrders[2]);
    printf("4 - Steak, Egg, and Cheese Burritos (2): ");
    scanf_s("%d", &entreeOrders[3]);
    printf("5 - Beef Fajita Platter Burritos (2): ");
    scanf_s("%d", &entreeOrders[4]);
    printf("6 - The Big Bacon Burritos (2): ");
    scanf_s("%d", &entreeOrders[5]);
    printf("7 - The Sleeper Burrito (2): ");
    scanf_s("%d", &entreeOrders[6]);

    // get user input for dessert quantities
    printf("\nEnter the number of each dessert item ordered:\n");
    printf("1 - Black Pearl Cake (thick sliced): ");
    scanf_s("%d", &dessertOrders[0]);
    printf("2 - Orange Zing Cake (thick sliced): ");
    scanf_s("%d", &dessertOrders[1]);
    printf("3 - Homemade Buttermilk Pie: ");
    scanf_s("%d", &dessertOrders[2]);
    printf("4 - Pineapple Cake (w/ Pineapple Ice Cream): ");
    scanf_s("%d", &dessertOrders[3]);

    // calculate drink total
    for (int i = 0; i < 5; i++) {
        drinkTotal += drinkOrders[i] * drinkCosts[i];
    }

    // calculate appetizer total
    for (int i = 0; i < 5; i++) {
        appetizerTotal += appetizerOrders[i] * appetizerCosts[i];
    }

    // calculate entree total
    for (int i = 0; i < 7; i++) {
        entreeTotal += entreeOrders[i] * entreeCosts[i];
    }

    // calculate dessert total
    for (int i = 0; i < 4; i++) {
        dessertTotal += dessertOrders[i] * dessertCosts[i];
    }

    float subtotal = drinkTotal + appetizerTotal + entreeTotal + dessertTotal;
    float tax = subtotal * 0.0825f;
    float grandTotal = subtotal + tax;

    // output results of inventory totals
    printf("\nInventory Reorder Costs:\n");
    printf("Drinks Reorder Price: $%.2f\n", drinkTotal);
    printf("Appetizers Reorder Price: $%.2f\n", appetizerTotal);
    printf("Entrees Reorder Price: $%.2f\n", entreeTotal);
    printf("Desserts Reorder Price: $%.2f\n", dessertTotal);
    printf("Subtotal: $%.2f\n", subtotal);
    printf("Grand Total: $%.2f\n", grandTotal);
}