CREATE DATABASE DemoDb;
GO


USE DemoDb;
GO


CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(255) NOT NULL,
    SupplierID INT,
    CategoryID INT,
    UnitPrice DECIMAL(18,2),
    UnitsInStock INT,
    UnitsOnOrder INT,
    Discontinued BIT NOT NULL,
    DiscontinuedDate DATETIME2
);


INSERT INTO Products 
(ProductName, SupplierID, CategoryID, UnitPrice, UnitsInStock, UnitsOnOrder, Discontinued, DiscontinuedDate)
VALUES
('Organic Apples', 1, 1, 1.50, 150, 20, 0, NULL),
('Whole Wheat Bread', 2, 2, 2.75, 80, 15, 0, NULL),
('Cheddar Cheese', 3, 3, 5.00, 60, 10, 0, NULL),
('Chicken Breast (1kg)', 4, 4, 8.50, 40, 5, 0, NULL),
('Salmon Fillet (500g)', 5, 4, 12.00, 25, 0, 0, NULL),
('Broccoli (500g)', 1, 1, 1.25, 100, 15, 0, NULL),
('Greek Yogurt', 2, 2, 3.25, 75, 10, 0, NULL),
('Swiss Cheese', 3, 3, 6.00, 50, 5, 0, NULL),
('Ground Beef (1kg)', 4, 4, 9.00, 35, 0, 0, NULL),
('Tuna (5 cans)', 5, 4, 7.50, 60, 10, 0, NULL);


INSERT INTO Products 
(ProductName, SupplierID, CategoryID, UnitPrice, UnitsInStock, UnitsOnOrder, Discontinued, DiscontinuedDate)
VALUES 
('Discontinued Product', 1, 1, 10.00, 0, 0, 1, '2023-10-26');


Select * from Products;


UPDATE Products
SET CategoryID = '1'
WHERE ProductID = 9;


SELECT @@SERVERNAME;


SELECT name FROM sys.databases;