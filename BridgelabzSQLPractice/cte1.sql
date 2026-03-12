-- cte 

With Expensive_Products As
(
	Select product_id,product_name,list_price
	From production.products
	Where list_price > 1000
)

Select * from Expensive_Products;