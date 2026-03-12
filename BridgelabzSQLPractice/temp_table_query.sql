--Create Table #TopProducts
--(
--	product_name varchar(255),
--	list_price decimal(10,2)
--);

Insert Into #TopProducts
Select product_name , list_price
From Production.products
Where list_price > 1567;

Select * from #TopProducts 
Order By list_price;