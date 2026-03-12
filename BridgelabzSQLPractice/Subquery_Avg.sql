Select product_name , list_price 
From production.products
Where list_price >
					(Select AVG(list_price) From production.products);
