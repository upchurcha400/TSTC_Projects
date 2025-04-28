#include <stdio.h>

int main()
{

    //Prepare containers for the numbers//
    float float1 = 0.0;
    float float2 = 0.0;
    float float3 = 0.0;
    float largest;

    printf("Please enter the first number: ");
    scanf("%f", float1);
    printf("\n Please enter the second number: ");
    scanf("%f", float2);
    printf("\n Please enter the third number: ");
    scanf("%f",float3);

    //Determine the biggest of the numbers//
    largest = (float1 >= float2 && float1 >= float3) ? float1 :
        (float2 >= float1 && float2 >= float3) ? float2 : float3;


        //Print//
        printf((float1 == float2 && float2 == float3) ? "\n All numbers are equal.\n" : "The largest number is %f \n", largest);
        printf("THe biggest number is");





            return 0;
}