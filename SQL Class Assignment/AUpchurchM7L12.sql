use ITSE2333pbesp25;

-- 1. Write a script that creates and calls a stored procedure named spInsertDepartment. First, code a statement that creates a procedure that adds a new row to the Departments table. To do that, this procedure should have one parameter for the department name.
-- Code at least two EXEC statements that test this procedure. (Note that this table doesn’t allow duplicate department names.)

IF OBJECT_ID('alupchurchsp252333.spInsertDepartment') IS NOT NULL
    DROP PROC alupchurchsp252333.spInsertDepartment;
GO

CREATE PROC alupchurchsp252333.spInsertDepartment
    @DepartmentName NVARCHAR(40)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM alupchurchsp252333.Departments WHERE DepartmentName = @DepartmentName)
        THROW 50001, 'Duplicate Department Name', 1;
    INSERT INTO alupchurchsp252333.Departments (DepartmentName)
    VALUES (@DepartmentName);
END;
GO

-- Testing the Procedure with EXEC statements

EXEC alupchurchsp252333.spInsertDepartment @DepartmentName = 'Science';
EXEC alupchurchsp252333.spInsertDepartment @DepartmentName = 'Mathematics';

-- 2. Write a script that creates and calls a function named fnStudentUnits that calculates the total course units of a student in the StudentCourses table.
-- To do that, this function should accept one parameter for the student ID, and it should return the sum of the course units for the student.The SELECT statement that calls the function should return the StudentID from the StudentCourses table, the CourseNumber and CourseUnits from the Courses table, and the value returned by the fnStudentUnits function for that student.

IF OBJECT_ID('alupchurchsp252333.fnStudentUnits') IS NOT NULL
    DROP FUNCTION alupchurchsp252333.fnStudentUnits;
GO

CREATE FUNCTION alupchurchsp252333.fnStudentUnits(@StudentID INT)
RETURNS INT
AS
BEGIN
    RETURN (SELECT SUM(C.CourseUnits)
            FROM alupchurchsp252333.StudentCourses SC
            JOIN alupchurchsp252333.Courses C ON SC.CourseID = C.CourseID
            WHERE SC.StudentID = @StudentID);
END;
GO

-- Testing the Function

SELECT SC.StudentID, C.CourseNumber, C.CourseUnits, alupchurchsp252333.fnStudentUnits(SC.StudentID) AS TotalUnits
FROM alupchurchsp252333.StudentCourses SC
JOIN alupchurchsp252333.Courses C ON SC.CourseID = C.CourseID;

-- 3. Write a script that creates and calls a function named fnTuition that calculates the total tuition for a student. 
-- To do that, this function should accept one parameter for the student ID, it should use the fnStudentUnits function that you created in exercise 2, 
-- and it should return the value of the tuition for that student depending on whether the student is fulltime (more than nine units) or parttime (nine or fewer units). (Hint: Use a cross join to work with data in the Students and Tuition tables.) The SELECT statement that calls the function should return the StudentID from the Students table, the value returned by the fnStudentUnits function for that student, and the value returned by the fnTuition function for that student. Return only rows for students taking one or more units.

IF OBJECT_ID('alupchurchsp252333.fnTuition') IS NOT NULL
    DROP FUNCTION alupchurchsp252333.fnTuition;
GO

CREATE FUNCTION alupchurchsp252333.fnTuition(@StudentID INT)
RETURNS MONEY
AS
BEGIN
    DECLARE @TotalUnits INT = alupchurchsp252333.fnStudentUnits(@StudentID);
    RETURN CASE 
              WHEN @TotalUnits > 9 THEN (SELECT FullTimeCost FROM alupchurchsp252333.Tuition)
              ELSE (SELECT PartTimeCost FROM alupchurchsp252333.Tuition)
           END;
END;
GO

-- Testing the function

SELECT S.StudentID, alupchurchsp252333.fnStudentUnits(S.StudentID) AS TotalUnits, alupchurchsp252333.fnTuition(S.StudentID) AS Tuition
FROM alupchurchsp252333.Students S
WHERE alupchurchsp252333.fnStudentUnits(S.StudentID) > 0;


-- 4. Write a script that creates and calls a stored procedure named spInsertInstructor that inserts a row into the Instructors table. This stored procedure should accept one parameter for each of these columns: LastName, FirstName, Status, DepartmentChairman, AnnualSalary, and DepartmentID. This stored procedure should set the DateAdded column to the current date. If the value for the AnnualSalary column is a negative number, the stored procedure should raise an error that indicates that this column doesn’t accept negative numbers.Code at least two EXEC statements that test this procedure.

IF OBJECT_ID('alupchurchsp252333.spInsertInstructor') IS NOT NULL
    DROP PROC alupchurchsp252333.spInsertInstructor;
GO

CREATE PROC alupchurchsp252333.spInsertInstructor
    @LastName NVARCHAR(25),
    @FirstName NVARCHAR(25),
    @Status CHAR(1),
    @DepartmentChairman BIT,
    @AnnualSalary MONEY,
    @DepartmentID INT
AS
BEGIN
    IF @AnnualSalary < 0
        THROW 50002, 'Annual Salary cannot be negative!', 1;
    INSERT INTO alupchurchsp252333.Instructors (LastName, FirstName, Status, DepartmentChairman, AnnualSalary, DepartmentID, HireDate)
    VALUES (@LastName, @FirstName, @Status, @DepartmentChairman, @AnnualSalary, @DepartmentID, GETDATE());
END;
GO

-- Testing the procedure

EXEC alupchurchsp252333.spInsertInstructor @LastName = 'Smith', @FirstName = 'John', @Status = 'F', @DepartmentChairman = 1, @AnnualSalary = 60000, @DepartmentID = 1;
EXEC alupchurchsp252333.spInsertInstructor @LastName = 'Doe', @FirstName = 'Jane', @Status = 'P', @DepartmentChairman = 0, @AnnualSalary = 30000, @DepartmentID = 2;

-- 5. Write a script that creates and calls a stored procedure named spUpdateInstructor that updates the AnnualSalary column in the Instructors table. 
-- This procedure should have one parameter for the instructor ID and another for the annual salary. If the value for the AnnualSalary column is a negative number, the stored procedure should raise an error that indicates that the value for this column must be a positive number. Code at least two EXEC statements that test this procedure.

IF OBJECT_ID('alupchurchsp252333.spUpdateInstructor') IS NOT NULL
    DROP PROC alupchurchsp252333.spUpdateInstructor;
GO

CREATE PROC alupchurchsp252333.spUpdateInstructor
    @InstructorID INT,
    @AnnualSalary MONEY
AS
BEGIN
    IF @AnnualSalary < 0
        THROW 50003, 'Annual Salary must be positive', 1;
    UPDATE alupchurchsp252333.Instructors
    SET AnnualSalary = @AnnualSalary
    WHERE InstructorID = @InstructorID;
END;
GO

-- Testing the Procedure

EXEC alupchurchsp252333.spUpdateInstructor @InstructorID = 1, @AnnualSalary = 70000;
EXEC alupchurchsp252333.spUpdateInstructor @InstructorID = 2, @AnnualSalary = 45000;

-- 6. Create a trigger named Instructors_UPDATE that checks the new value for the AnnualSalary column of the Instructors table. This trigger should raise an appropriate error if the annual salary is greater than 120,000 or less than 0. If the new annual salary is between 0 and 12,000, this trigger should modify the new annual salary by multiplying it by 12. That way, a monthly salary of 5,000 becomes an annual salary of 60,000. Test this trigger with an appropriate UPDATE statement.

IF OBJECT_ID('Instructors_UPDATE', 'TR') IS NOT NULL
    DROP TRIGGER Instructors_UPDATE;
GO

CREATE TRIGGER Instructors_UPDATE
ON alupchurchsp252333.Instructors
AFTER UPDATE
AS
BEGIN
    IF EXISTS (SELECT * FROM Inserted WHERE AnnualSalary > 120000 OR AnnualSalary < 0)
    BEGIN
        ROLLBACK TRAN;
        THROW 50004, 'Annual Salary must be between 0 and 120,000', 1;
    END;

    UPDATE alupchurchsp252333.Instructors
    SET AnnualSalary = AnnualSalary * 12
    WHERE AnnualSalary > 0 AND AnnualSalary < 12000;
END;
GO

-- Testing the Trigger

UPDATE alupchurchsp252333.Instructors SET AnnualSalary = 5000 WHERE InstructorID = 1;

-- 7. Create a trigger named Instructors_INSERT that inserts the current date for the HireDate column of the Instructors table if the value for that column is null.
-- Test this trigger with an appropriate INSERT statement.

IF OBJECT_ID('Instructors_INSERT', 'TR') IS NOT NULL
    DROP TRIGGER Instructors_INSERT;
GO

CREATE TRIGGER Instructors_INSERT
ON alupchurchsp252333.Instructors
AFTER INSERT
AS
BEGIN
    UPDATE alupchurchsp252333.Instructors
    SET HireDate = GETDATE()
    WHERE HireDate IS NULL;
END;
GO

-- Testing the Trigger

INSERT INTO alupchurchsp252333.Instructors (LastName, FirstName, Status, DepartmentChairman, AnnualSalary, DepartmentID)
VALUES ('Taylor', 'Alex', 'P', 0, 20000, 3);

-- 8. Create a table named InstructorsAudit. This table should have all columns of the Instructors table. Also, it should have an AuditID column for its primary key and a DATETIME2 column named DateUpdated. Create a trigger named Instructors_UPDATE. This trigger should insert the old data about the instructor into the
-- InstructorsAudit table after the row is updated and set the DateUpdated column to the current date and time. Then, test this trigger with an appropriate UPDATE statement.

IF OBJECT_ID('alupchurchsp252333.InstructorsAudit', 'U') IS NOT NULL
    DROP TABLE alupchurchsp252333.InstructorsAudit;
GO

CREATE TABLE alupchurchsp252333.InstructorsAudit
(
    AuditID UNIQUEIDENTIFIER PRIMARY KEY,
    LastName NVARCHAR(25),
    FirstName NVARCHAR(25),
    Status CHAR(1),
    DepartmentChairman BIT,
    AnnualSalary MONEY,
    DepartmentID INT,
    HireDate DATE,
    DateUpdated DATETIME2
);
GO

IF OBJECT_ID('Instructors_UPDATE_Audit', 'TR') IS NOT NULL
    DROP TRIGGER Instructors_UPDATE_Audit;
GO

CREATE TRIGGER Instructors_UPDATE_Audit
ON alupchurchsp252333.Instructors
AFTER UPDATE
AS
BEGIN
    INSERT INTO alupchurchsp252333.InstructorsAudit (AuditID, LastName, FirstName, Status, DepartmentChairman, AnnualSalary, DepartmentID, HireDate, DateUpdated)
    SELECT NEWID(), d.LastName, d.FirstName, d.Status, d.DepartmentChairman, d.AnnualSalary, d.DepartmentID, d.HireDate, GETDATE()
    FROM Deleted d;
END;
GO


-- Testin the Trigger

UPDATE alupchurchsp252333.Instructors SET AnnualSalary = 80000 WHERE InstructorID = 2;

