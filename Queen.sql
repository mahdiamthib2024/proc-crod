create proc Insert_oreder(@_customer_id int , @_order_status int, @_order_date date,@_required_date date,@_shipped_date date, @_store_id int, @_staff_id int)
as
begin 
	insert into sales.orders(customer_id,order_status,order_date,required_date,shipped_date,store_id,staff_id)
	values(@_customer_id,@_order_status,@_order_date,@_required_date,@_shipped_date,@_store_id,@_staff_id)
end
--example
exec Insert_oreder 1,4,'2020-02-02','2016-01-03','2016-01-03',1,1

-----------------------------------------------------
--Disply -

create proc List_oreder
as
begin
	 select * from sales.orders
end

exec List_oreder

------------------------------------------------
--Update

create proc Update_order
(
  @_order_id int,
  @_customer_id int ,
  @_order_status int,
  @_order_date date,
  @_required_date date,
  @_shipped_date date, 
  @_store_id int,
  @_staff_id int
  
  )
  as
  begin
	update sales.orders
	set customer_id = @_customer_id ,
	    order_status = @_order_status,
		order_date  = @_order_date,
		required_date = @_required_date,
		shipped_date = @_shipped_date,
		store_id = @_store_id,
		staff_id = @_staff_id
		where order_id  = @_order_id
  end


---------------------------------------
create proc Delete_order(@_order_id int)
as 
begin 
		delete sales.orders 
		where order_id = @_order_id
end
