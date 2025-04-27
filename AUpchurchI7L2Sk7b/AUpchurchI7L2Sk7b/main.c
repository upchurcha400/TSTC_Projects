#include <stdio.h>
#include <stdlib.h>

#define NUM_STUDENTS 5
#define NUM_TESTS 4

// Function prototypes
void getStudentData(char names[NUM_STUDENTS][50], double scores[NUM_STUDENTS][NUM_TESTS]);
void calculateTheGrades(double scores[NUM_STUDENTS][NUM_TESTS], char grades[NUM_STUDENTS], double averages[NUM_STUDENTS]);
void displayPlusSaveResults(char names[NUM_STUDENTS][50], double scores[NUM_STUDENTS][NUM_TESTS], char grades[NUM_STUDENTS], double averages[NUM_STUDENTS]);

int main() {
    char studentNames[NUM_STUDENTS][50];
    double testScores[NUM_STUDENTS][NUM_TESTS];
    char letterGrades[NUM_STUDENTS];
    double averages[NUM_STUDENTS];

    // Get the student names and grades from the user
    getStudentData(studentNames, testScores);

    // Calculate students' grades and averages
    calculateTheGrades(testScores, letterGrades, averages);

    // Display and save the results
    displayPlusSaveResults(studentNames, testScores, letterGrades, averages);

    return 0;
}

// Function to get student data
void getStudentData(char names[NUM_STUDENTS][50], double scores[NUM_STUDENTS][NUM_TESTS]) {
    for (int i = 0; i < NUM_STUDENTS; i++) {
        printf("Enter the name of student %d: ", i + 1);
        scanf_s("%s", names[i], 50);

        for (int j = 0; j < NUM_TESTS; j++) {
            do {
                printf("Enter test score %d for %s: ", j + 1, names[i]);
                scanf_s("%lf", &scores[i][j]);

                if (scores[i][j] < 0 || scores[i][j] > 100) {
                    printf("Invalid score. Please enter a score between 0 and 100.\n");
                }
            } while (scores[i][j] < 0 || scores[i][j] > 100);
        }
    }
}

// Function to calculate grades and averages
void calculateTheGrades(double scores[NUM_STUDENTS][NUM_TESTS], char grades[NUM_STUDENTS], double averages[NUM_STUDENTS]) {
    for (int i = 0; i < NUM_STUDENTS; i++) {
        double sum = 0.0;

        for (int j = 0; j < NUM_TESTS; j++) {
            sum += scores[i][j];
        }

        averages[i] = sum / NUM_TESTS;

        if (averages[i] >= 90) {
            grades[i] = 'A';
        }
        else if (averages[i] >= 80) {
            grades[i] = 'B';
        }
        else if (averages[i] >= 70) {
            grades[i] = 'C';
        }
        else if (averages[i] >= 60) {
            grades[i] = 'D';
        }
        else {
            grades[i] = 'F';
        }
    }
}

// Function to display and save the final results
void displayPlusSaveResults(char names[NUM_STUDENTS][50], double scores[NUM_STUDENTS][NUM_TESTS], char grades[NUM_STUDENTS], double averages[NUM_STUDENTS]) {
    FILE* file;
    errno_t err = fopen_s(&file, "AUpchurchGrades.txt", "w");

    if (err != 0) {
        printf("Error opening file!\n");
        exit(1);
    }

    printf("\nStudent Grades:\n");
    fprintf(file, "Student Grades:\n");

    for (int i = 0; i < NUM_STUDENTS; i++) {
        printf("Name: %s\n", names[i]);
        printf("Test Scores: ");

        fprintf(file, "Name: %s\n", names[i]);
        fprintf(file, "Test Scores: ");

        for (int j = 0; j < NUM_TESTS; j++) {
            printf("%.2f ", scores[i][j]);
            fprintf(file, "%.2f ", scores[i][j]);
        }

        printf("\nAverage: %.2f\n", averages[i]);
        printf("Grade: %c\n\n", grades[i]);

        fprintf(file, "\nAverage: %.2f\n", averages[i]);
        fprintf(file, "Grade: %c\n\n", grades[i]);
    }

    fclose(file);
}