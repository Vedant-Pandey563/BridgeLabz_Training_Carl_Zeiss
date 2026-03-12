Select product_name,list_price
From production.products
Where category_id IN
(
	Select category_id 
	From production.categories
	Where category_name = 'Mountain Bikes'

);
