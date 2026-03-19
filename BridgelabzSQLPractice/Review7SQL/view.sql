-- view 
--Step 5 — View
--- Daily Sales Report
--- Create a view to show daily sales.
use Cafe_Store;


select * from Product;
select * from billitems;
select * from bill;

Create or alter  view DailySalesReportView
As 
Select 
cast(billdate as date) as today , Sum(Totalamount) as TotalAmount
from bill
where cast(BillDate as date) = Cast(Getdate() as date)
group by cast (billdate as date);

Select * from DailySalesReportView;


