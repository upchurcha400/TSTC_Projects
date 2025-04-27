// Anthony Upchurch
// ITSE 1302 7P
// Fall/2024
// 10/10/2024
// 3rd Grand Melee

// necessary header file for input/output
#include <stdio.h>
int main()
{
	//int the main varables
	int choiceDrink;
	int choiceAppetizer;
	int choiceEntree;
	int choiceDessert;
	double drinkPrice;
	double appetizerPrice;
	double entreePrice;
	double dessertsPrice;
	
	//Ask user to select their meal choicse
	printf("==========================================================\n");
	printf("DRINKS\n");
	printf("1- Dr. Pepper...................................... $ 1.99\n"); 
	printf("2- Peach Tea....................................... $ 2.99\n");
	printf("Please choose a Drink (choose 1 or 2): ");
	scanf_s("%d", &choiceDrink);
	drinkPrice = (choiceDrink == 1 ? 1.99 : 2.99);
	printf("\nDrink Price:  %.2f", drinkPrice);
	printf("==========================================================\n");
	printf("\nAPPETIZERS:\n");
	printf("1- Pepperoni Cheese Poppers (10)................... $ 7.00\n");
	printf("2- Homemade Cheese Sticks Platter (12)............. $ 7.99\n");
	printf("Please choose an Appetizer (choose 1 or 2): ");
	scanf_s("%d", &choiceAppetizer);
	appetizerPrice = (choiceAppetizer == 1 ? 7.00 : 7.99);
	printf("\nAppetizer Price:  %.2f", appetizerPrice);
	printf("==========================================================\n");
	printf("\nENTREES:\n");
	printf("1- Southern Breakfast Burrito (1).................. $12.99\n");
	printf("2- The Big Bacon Burritos (2)...................... $14.99\n");
	printf("Please choose an Entree (choose 1 or 2): ");
	scanf_s("%d", &choiceEntree);
	entreePrice = (choiceEntree == 1 ? 12.99 : 14.99);
	printf("\nEntree Price:  %.2f", entreePrice);
printf("==========================================================\n");
	printf("\nDESSERTS:\n");
	printf("1- Black Pearl Cake (thick sliced)................. $ 5.99\n");
	printf("2- Pineapple Cake (w/ Pineapple Ice Cream)......... $ 7.99\n");
	printf("Please choose an Dessert (choose 1 or 2): ");
	scanf_s("%d", &choiceDessert);
	dessertsPrice = (choiceDessert == 1 ? 5.99 : 7.99);
	printf("\nDessert Price:  %.2f", dessertsPrice);
	
	// Calculate subtotal of the order
	double subTotal;
	subTotal = drinkPrice + appetizerPrice + entreePrice + dessertsPrice;
	
	// Determine discount rate based on total order
	double discountRate;
	discountRate = (subTotal < 25.00) ? .05 : .10;
	double discountAmount;
	discountAmount = discountRate * subTotal;
	double totalAfterDiscount;
	totalAfterDiscount = subTotal - discountAmount;
	
	// Calculate sales tax
	double taxAmount = totalAfterDiscount * .0825;
	double billTotal = totalAfterDiscount + taxAmount;
	
	// Ask user about service quality
	int serviceAnswer;
	printf("\nLet us know about your service! Are you happy with your server? (1 for Yes, 2 for No): ");
	scanf_s("%d", &serviceAnswer);
	double tipRate;
	tipRate = (serviceAnswer == 1) ? .30 : .15;
	double tipAmount;
	tipAmount = billTotal * tipRate;
	double totalDue;
	totalDue = billTotal + tipAmount;
	
	//clean the screen
	system("cls");

	// Display receipt
	printf("\n       The Flying Burrito\n");
	printf("==================================\n");
	printf("Drink:  . . . . . . . . . . .$%.2f\n", drinkPrice);
	printf("Appetizer:  . . . . . . . . .$%.2f\n", appetizerPrice);
	printf("Entree:  . . . . . . . . . .$%.2f\n", entreePrice);
	printf("Dessert:  . . . . . . . . . .$%.2f\n", dessertsPrice);
	printf("==================================\n");
	printf("Subtotal:  . . . . . . . . .$%.2f\n", subTotal);
	printf("Discount:  . . . . . . . . .-$%.2f\n", discountAmount);
	printf("Total after Discount:  . . .$%.2f\n", totalAfterDiscount);
	printf("Tax:  . . . . . . . . . . . .$%.2f\n", taxAmount);
	printf("Bill Total:  . . . . . . . .$%.2f\n", billTotal);
	printf("Tip:  . . . . . . . . . . . .$%.2f\n", tipAmount);
	printf("==================================\n");
	printf("Total Due: . . . . . . . . .$%.2f\n", totalDue);
	return 0;
}

