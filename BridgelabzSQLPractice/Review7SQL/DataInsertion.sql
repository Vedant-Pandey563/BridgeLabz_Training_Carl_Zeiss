-- adding data 

INSERT INTO Product (ProductName, Category, Price)
VALUES 
	('Ice Coffee', 'Coffee', 150.00),
	('Hot Coffee', 'Coffee', 180.00),
	('Espresso', 'Coffee', 120.00),
	('Sandwich', 'Snack', 200.00),
	('Brownie', 'Dessert', 140.00)
;

select * from Product;

Insert into Customer (CustomeryName,PhoneNo)
Values
	('Messi', '9876543210'),
	('Pedri', '9123456780'),
	('Yamal', '9988776655'),
	('Neymar', '9090909090'),
	('Xavi', '8765432109');

select * from Customer;

select * from Bill;


select * from BillItems;



Truncate table Bill;

select * from sys.tables;


select * from Product;

Alter Table Product 
Add Quantiy int ;


Exec sp_rename 'Product.Quantiy' ,'Quantity','Column';

Update Product
Set Quantity = 10 
Where ProductName = 'Ice Coffee';


Update Product
Set Quantity = 9 
Where ProductName = 'Hot Coffee';

Update Product
Set Quantity = 4 
Where ProductName = 'Espresso';

Update Product
Set Quantity = 6 
Where ProductName = 'Brownie';

Update Product
Set Quantity = 7 
Where ProductName = 'Sandwich';

select * from Bill;

