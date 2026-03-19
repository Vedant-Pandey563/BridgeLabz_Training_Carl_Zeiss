--Step 3 - Function
--- Calculate Total Bill Amount
--- Create a scalar function.



select * from bill;
select * from Product;
Select * from BillItems;

select p.Price,b.Quantity from 
product p 
join BillItems b on p.ProductId=b.ProductId;


CREATE  or Alter FUNCTION dbo.TotalAmount
(
    @BillId INT
)
RETURNS Decimal(10,2)
AS
BEGIN
    DECLARE @TotalAmount Decimal(10,2);

    SELECT @TotalAmount = SUM(SubTotal)
    FROM BillItems
    WHERE BillId = @BillId;

    RETURN @TotalAmount;
END;


Select dbo.TotalAmount(1004) as TotalAmount;

 

