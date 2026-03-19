--Trigger
--- Automatically Reduce Stock
--- Whenever a product is added to BillItems, stock must decrease.
select * from product;
select * from BillItems;
use Cafe_Store;

Create trigger Stock_Reduce
on BillItemS
after Insert 
as Begin
	Update Product
	Set Product.Quantity = Product.Quantity - inserted.Quantity
	From Product
	Join inserted on Product.ProductId = inserted.ProductId
end;

select * from sys.triggers;
	
