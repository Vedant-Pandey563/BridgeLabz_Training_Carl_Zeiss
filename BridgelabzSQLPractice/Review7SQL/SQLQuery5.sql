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

--insert bill


CREATE OR ALTER PROCEDURE Insert_Into_Bill
    @CustId INT
AS
BEGIN
    INSERT INTO Bill(CustomerId,TotalAmount)
    VALUES(@CustId,0)
END
GO


--insert bill items

CREATE OR ALTER PROCEDURE Insert_Into_Bill_Items
    @BillId INT,
    @ProductId INT,
    @Quantity INT
AS
BEGIN
    DECLARE @Price DECIMAL(10,2)
    DECLARE @SubTotal DECIMAL(10,2)
    DECLARE @Stock INT

    SELECT @Stock = Quantity
    FROM Product
    WHERE ProductId = @ProductId


    IF (@Stock < @Quantity)
    BEGIN
        RAISERROR('Insufficient stock',16,1)
        RETURN
    END


    SELECT @Price = Price
    FROM Product
    WHERE ProductId = @ProductId

    SET @SubTotal = @Price * @Quantity

    INSERT INTO BillItems (BillId, ProductId, Quantity, Price, SubTotal)
    VALUES (@BillId, @ProductId, @Quantity, @Price, @SubTotal)

END
GO


--insert stcok reduce

CREATE OR ALTER TRIGGER Stock_Reduce
ON BillItems
AFTER INSERT
AS
BEGIN

    UPDATE p
    SET p.Quantity = p.Quantity - i.Quantity
    FROM Product p
    JOIN inserted i
        ON p.ProductId = i.ProductId

    UPDATE b
    SET b.TotalAmount = dbo.TotalAmount(b.BillId)
    FROM Bill b
    JOIN inserted i
        ON b.BillId = i.BillId

END





