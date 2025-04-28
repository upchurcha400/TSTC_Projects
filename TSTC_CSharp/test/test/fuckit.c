#include <stdio.h>

int main()
{
    int employeeNum;
    float hourlyPay;
    float hoursWorked;
    float employeePay;
    float totalPayroll = 0;

    //ask the user for employee number info
    printf("Please enter the number of employees: ");
    scanf_s("%d", &employeeNum);

    // Begin the input and calculating of each of the employees
    for (int i = 1; i <= employeeNum; i++) {

        do {
            printf("Enter Hourly Rate: ");
            scanf_s("%f", &hourlyPay);
            if (hourlyPay <= 0) {
                printf("Hourly pay CANNOT be $0 or less! Please enter hourly pay: \n");
                scanf_s("%f", &hourlyPay);
            }
        } while (hourlyPay <= 0);

        // Ask for the hours worked by the active employee
        do {
            printf("Enter Hours Worked: \n");
            scanf_s("%f", &hoursWorked);
            if (hoursWorked <= 0) {
                printf("Hours worked CANNOT be 0 or less! Please enter hours!\n");
                scanf_s("%f", &hoursWorked);
            }
        } while (hoursWorked <= 0);

        // Find the total for the pay check and payroll
        employeePay = hourlyPay * hoursWorked;
        totalPayroll += employeePay;
    }
    // Printing the totals
    printf("Total payroll for the week is $%.2f.\n", totalPayroll);

    return 0;
}