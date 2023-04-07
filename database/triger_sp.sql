if OBJECT_ID('sp_InsertService') is not null
drop proc sp_InsertService
go
create proc sp_InsertService @idBook int,@idNV varchar(50),@idCustomer int,@amount int,@date date,@type bit,@price int
as
begin
	Insert into bookService values
	(@idBook,@idNV,@idCustomer,@amount,@date,@type,@price)
end
GO 


go
--thêm trigger để lưu các sách đã mượn
if OBJECT_ID('trigger_AddBorrow') is not null
	drop trigger trigger_AddBorrow
go
create trigger trigger_AddBorrow on Bookservice after insert
as
	declare @type bit;
	select @type=customerNeed
	from inserted	
	if(@type=0)
	begin
		declare @IDService int,@IDBook int, @checkInDate date,@deposit int
		select @IDService=ID,@IDBook=IDBook,@checkInDate=checkInDate,@deposit=priceService
		from inserted
		Insert into borrowBook values
		(@IDBook,@IDBook,@checkInDate,NULL,NULL,@deposit,NULL)
	end
go
--inse