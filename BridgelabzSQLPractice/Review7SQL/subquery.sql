--Step 6 - Subquery Example
--- Find the top-selling product.
--eg:
--- Subquery finds product with maximum sales.

use Cafe_Store;
select * from BillItems;
select * from bill;

select ProductId, SUM(Quantity) AS TopSellingQuantity
from BillItems
Group by ProductId
Having Sum (Quantity) =
(
	Select max(ProductSales)
	From
	(
		Select sum(quantity) as ProductSales
		from BillItems
		group by ProductId
	) as salestable
	);	




