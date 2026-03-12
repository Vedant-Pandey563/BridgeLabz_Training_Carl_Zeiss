-- correalted subqurery

Select customer_id, first_name 
From sales.customers c
Where 3 <=  
(
	Select Count(*)
	From sales.orders o
	where o.customer_id = c.customer_id
);
