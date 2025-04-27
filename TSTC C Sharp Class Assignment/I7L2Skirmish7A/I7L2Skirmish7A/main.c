#include <stdio.h>

// Declare the functions used in the program
void getRainFall(double rainFall[], int months);
double totalRainFall(double rainFall[], int months);
double averageRainFall(double rainFall[], int months);
int highestRainFall(double rainFall[], int months);
int lowestRainFall(double rainFall[], int months);

int main() {
	const int months = 12;
	double rainfall[12];
	double totalRain, averageRain;
	int highestMonth, lowestMonth;

	// Pull rainfall data from user for function
	getRainFall(rainfall, months);

	// Calculate the total rainfall inside the function
	totalRain = totalRainFall(rainfall, months);
	printf("Total rainfall for the year is: %.2lf\n", totalRain);

	// Calculate the average rainfall inside the function
	averageRain = averageRainFall(rainfall, months);
	printf("Average rainfall for the year is: %.2lf\n", averageRain);

	// Calculate the highest rainfall inside the function
	highestMonth = highestRainFall(rainfall, months);
	printf("The highest rainfall for the year is in month: %d\n", highestMonth + 1);

	// Calculate the lowest rainfall inside the function
	lowestMonth = lowestRainFall(rainfall, months);
	printf("The lowest rainfall for the year is in month: %d\n", lowestMonth + 1);

	return 0;
}

// Function to get the rainfall data from the user
void getRainFall(double rainFall[], int months) {
	int i;
	for (i = 0; i < months; i++) {
		do {
			printf("Enter the rainfall for month %d: ", i + 1);
			scanf_s("%lf", &rainFall[i]);
			if (rainFall[i] < 0) {
				printf("Rainfall cannot be negative. Enter a positive number.\n");
			}
		} while (rainFall[i] < 0);
	}
}

// Function to calculate the total rainfall
double totalRainFall(double rainFall[], int months) {
	double total = 0;
	int i;
	for (i = 0; i < months; i++) {
		total += rainFall[i];
	}
	return total;
}

// Function to calculate the average rainfall
double averageRainFall(double rainFall[], int months) {
	double total = 0;
	int i;
	for (i = 0; i < months; i++) {
		total += rainFall[i];
	}
	return total / months;
}

// Function to decide Highest Rainfall Month
int highestRainFall(double rainFall[], int months) {
	int i;
	int highestMonth = 0;
	for (i = 1; i < months; i++) {
		if (rainFall[i] > rainFall[highestMonth]) {
			highestMonth = i;
		}
	}
	return highestMonth;
}

// Function to decide Lowest Rainfall Month
int lowestRainFall(double rainFall[], int months) {
	int i;
	int lowestMonth = 0;
	for (i = 1; i < months; i++) {
		if (rainFall[i] < rainFall[lowestMonth]) {
			lowestMonth = i;
		}
	}
	return lowestMonth;
}