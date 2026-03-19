--Step 4 — Stored Procedure with Transaction
--This is the most important part.
--Create Bill
--The procedure will:

--1 Insert Bill
--2 Insert BillItems
--3 Reduce stock
--4 Calculate total


use Cafe_Store;
select * from bill;
select * from billitems;
select * from Product;

CREATE OR ALTER PROCEDURE Create_Bill_With_Items
    @CustomerId INT,
    @ProductId INT,
    @Quantity INT
AS
BEGIN
    BEGIN TRY

        BEGIN TRANSACTION

        DECLARE @BillId INT
        DECLARE @Price DECIMAL(10,2)
        DECLARE @SubTotal DECIMAL(10,2)
        DECLARE @Stock INT

        
        SELECT @Stock = Quantity
        FROM Product
        WHERE ProductId = @ProductId

        IF (@Stock < @Quantity)
        BEGIN
            THROW 50000, 'Insufficient Stock', 1;
        END

        INSERT INTO Bill(CustomerId,TotalAmount)
        VALUES(@CustomerId,0)

        SET @BillId = SCOPE_IDENTITY()

        SELECT @Price = Price
        FROM Product
        WHERE ProductId = @ProductId

        SET @SubTotal = @Price * @Quantity

        INSERT INTO BillItems(BillId,ProductId,Quantity,Price,SubTotal)
        VALUES(@BillId,@ProductId,@Quantity,@Price,@SubTotal)

        COMMIT TRANSACTION

    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT 'Transaction Failed'
    END CATCH

END
GO

EXEC Create_Bill_With_Items 102,1,3;



