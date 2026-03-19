--Step 6 - Subquery Example
--- Find the top-selling product.
--eg:
--- Subquery finds product with maximum sales.

select * from BillItems;
select * from bill;

select * from billitems 
where count(quantity)

select sum(quantity)
from billitems
group by productid;