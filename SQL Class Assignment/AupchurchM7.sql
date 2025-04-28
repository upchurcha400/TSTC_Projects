use ITSE2333pbesp25;

-- 1. Write a script that creates and calls a stored procedure named spAddCategory. First, code a statement that creates a procedure that adds a new row to the Categories table. To do that, this procedure should have one parameter for the category name.

CREATE PROCEDURE alupchurchsp252333.sp_AddCategory
    @CategoryName NVARCHAR(255)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM alupchurchsp252333.Categories WHERE CategoryName = @CategoryName)
    BEGIN
        INSERT INTO alupchurchsp252333.Categories (CategoryName)
        VALUES (@CategoryName);
    END
    ELSE
    BEGIN
        PRINT 'Category name already exists.';
    END
END;


-- Code at least two EXEC statements that test this procedure. (Note that this table doesn’t allow duplicate category names.)

EXEC alupchurchsp252333.sp_AddCategory 'Guitars';
EXEC alupchurchsp252333.sp_AddCategory 'Drums';

-- 2. Write a script that creates and calls a function named fnCategoryCount return the number of Products as ProductCount in the product table that match a category name. To do that, this function should accept one parameter for the category name. You can use the category name to match the CategoryID in the Products table to count the items.

CREATE FUNCTION alupchurchsp252333.fn_CategoryCount
    (@CategoryName NVARCHAR(255))
RETURNS INT
AS
BEGIN
    DECLARE @ProductCount INT;
    SELECT @ProductCount = COUNT(*)
    FROM alupchurchsp252333.Products
    WHERE CategoryID = (SELECT CategoryID FROM alupchurchsp252333.Categories WHERE CategoryName = @CategoryName);
    RETURN @ProductCount;
END;

-- The SELECT statement that calls the function passing it ‘Guitars’.

SELECT alupchurchsp252333.fn_CategoryCount('Guitars') AS ProductCount;

-- 3. Write a script that creates and calls a function named fnCustomerTotal that calculates the total order purchases of a customer in the Orders and OrderItems table. To do that, this function should accept one parameter for the Customer ID, and it should return the sum of the item prices ordered by the Customer. The function should return the CustomerID and calculated sum.

CREATE FUNCTION alupchurchsp252333.fn_CustomerTotal
    (@CustomerID INT)
RETURNS TABLE
AS
RETURN
(
    SELECT
        @CustomerID AS CustomerID,
        SUM(oi.ItemPrice) AS TotalPurchases
    FROM alupchurchsp252333.Orders o
    INNER JOIN alupchurchsp252333.OrderItems oi ON o.OrderID = oi.OrderID
    WHERE o.CustomerID = @CustomerID
);

-- Write two SELECT statements that call the function with customer numbers 1 and 3.

SELECT * FROM alupchurchsp252333.sp_CustomerTotal(1);
SELECT * FROM alupchurchsp252333.sp_CustomerTotal(3);

-- 4. Write a script that creates and calls a stored procedure named spInsertCustomer that inserts a row into the Customers table. This stored procedure should accept one parameter for each of these columns: EmailAddress, Password, LastName, FirstName.

CREATE PROCEDURE alupchurchsp252333.sp_InsertCustomer
    @EmailAddress NVARCHAR(255),
    @Password NVARCHAR(50),
    @FirstName NVARCHAR(255),
    @LastName NVARCHAR(255),
    @ShippingAddressID INT,
    @BillingAddressID INT
AS
BEGIN
    INSERT INTO alupchurchsp252333.Customers (EmailAddress, Password, FirstName, LastName, ShippingAddressID, BillingAddressID)
    VALUES (@EmailAddress, @Password, @FirstName, @LastName, @ShippingAddressID, @BillingAddressID);
END;

-- Code at least two EXEC statements that test this procedure.

EXEC alupchurchsp252333.sp_InsertCustomer 'john.doe@example.com', 'password123', 'John', 'Doe', NULL, NULL;
EXEC alupchurchsp252333.sp_InsertCustomer 'jane.smith@example.com', 'securepass', 'Jane', 'Smith', 1, 2;

-- 5. Write a script that creates and calls a stored procedure named spSetPrice that updates the ListPrice column in the Products table. This procedure should have one parameter for the product ID and another for the new price.

CREATE PROCEDURE alupchurchsp252333.sp_SetPrice
    @ProductID INT,
    @NewPrice DECIMAL(10, 2)
AS
BEGIN
    IF @NewPrice < 0
    BEGIN
        RAISERROR ('The ListPrice must be a positive number.', 16, 1);
    END
    ELSE
    BEGIN
        UPDATE alupchurchsp252333.Products
        SET ListPrice = @NewPrice
        WHERE ProductID = @ProductID;
    END
END;

-- Code at least two EXEC statements that test this procedure.

EXEC alupchurchsp252333.sp_SetPrice 1, 199.99;
EXEC alupchurchsp252333.sp_SetPrice 2, -50.00; 

-- 6. Create a trigger named Products_UPDATE that checks the new value for the ListPrice column of the Products table. This trigger should raise an appropriate error if the value is negative, and Rollback the operation.

CREATE TRIGGER alupchurchsp252333.sp_Products_UPDATE
ON alupchurchsp252333.Products
AFTER UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted WHERE ListPrice < 0)
    BEGIN
        RAISERROR ('The ListPrice cannot be negative.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

-- Test this trigger by running the EXEC for problem 5 and passing a negative number

EXEC alupchurchsp252333.sp_SetPrice 2, -50.00;

-- 7. Create a trigger named Products_INSERT that inserts the current date for the DataAdded column of the Products table if the value for that column is null.

CREATE TRIGGER alupchurchsp252333.sp_Products_INSERT
ON alupchurchsp252333.Products
AFTER INSERT
AS
BEGIN
    UPDATE alupchurchsp252333.Products
    SET DateAdded = GETDATE()
    WHERE ProductID IN (SELECT ProductID FROM inserted WHERE DateAdded IS NULL);
END;

-- Test this trigger with an appropriate INSERT statement.

INSERT INTO alupchurchsp252333.Products (ProductCode, ProductName, CategoryID, ListPrice, Description, DateAdded)
VALUES ('P12345', 'New Product', 3, 49.99, 'This is a sample product description.', NULL);

-- 8. Write a script that includes SQL statements coded as a transaction to delete the row with a CustomerID of 100 from the Customers table. To do this, you must first delete all Addresses for that Customer from the Addresses table.

BEGIN TRANSACTION;
BEGIN TRY
    DELETE FROM alupchurchsp252333.Addresses WHERE CustomerID = 100;
    DELETE FROM alupchurchsp252333.Customers WHERE CustomerID = 100;
    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
    PRINT ERROR_MESSAGE();
END CATCH;

-- 9. Write the statement to delete the Stored procedure from Problem 1

DROP PROCEDURE alupchurchsp252333.sp_AddCategory;

-- 10. Write the statement to delete the trigger from problem 6.

DROP TRIGGER alupchurchsp252333.fn_Products_UPDATE;

