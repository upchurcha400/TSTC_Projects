#include <stdio.h>

int main()
{
	int num1 = 0;
	int num2 = 0;
	char opand;
	int result = 0;

	printf("Please enter your first number: ");
	scanf_s("%d", &num1);

	printf("\nPlease enter the Operand (+ - * /): ");
	scanf_s(" %c", &opand);

	printf("\nPlease enter your second number: ");
	scanf_s("%d", &num2);

	switch (opand)
	{
		case '+':
			result = num1 + num2;
			
		break;
		
		case '-':
			result = num1 - num2;
		break;
		
		case '*':
			result = num1 * num2;
		break;

		case '/':
			result = num1 / num2;
		break;

		default:
			printf("\nPlease enter one of these operands: (+ - * /)");
		break;

		

	}
	printf("The results:  %d %c %d = %d", num1, opand, num2, result);

	return 0;
}