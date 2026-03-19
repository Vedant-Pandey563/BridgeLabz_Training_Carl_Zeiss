-- creation qry

create database Cafe_Store;
use Cafe_Store;


create table Product
(
	ProductId int identity(1,1) primary key,
	ProductName varchar(100) unique not null,
	Category varchar(100) not null,
	Price decimal(10,2) not null
);
select * from Product;



Create table Customer 
(
	CustomerId int identity(101,1) primary key,
	CustomeryName varchar(20) not null,
	PhoneNo varchar(10) unique not null
);
Select * from customer;


Create table Bill
(
	BillId int identity(1001,1) primary key,
	CustomerId int not null,
	BillDate Date Default Getdate(),
	TotalAmount Decimal(10,2) not null,

	Foreign Key (CustomerId) References Customer(CustomerId)
);

Select * from Bill;


Create table BillItems
(
	BillItemID int identity(1,1) primary key,
	BillId int not null,
	ProductId int not null,
	Quantity int ,
	Price decimal(10,2) not null,
	SubTotal decimal(10,2) not null,

	Foreign Key (BillId) References Bill(BillId),
	Foreign Key (ProductId) References Product(ProductId),
);


Select * from BillItems;




