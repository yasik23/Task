ALTER TABLE Users
ADD Last_Disconnection Datetime 

select *
from Users

select Top 1 Username
from Users
order by Last_Connection DESC

Insert into Orders (Order_Date,Created_by) Values(GETDATE(),'ykolomeisky')

select top 1 Order_ID
from Orders
where Created_by='mcohen'
order by Order_Date DESC


select top 1 Order_ID
from Orders
where Created_by='comax'
order by Order_Date DESC


select *
from Orders
where Created_by='ykolomeisky'
Order by Order_Date

select*
from Order_Details

Select * From Users Where Username='ykolomeisky' and Password='123456'

UPDATE Users SET Last_Connection=GETDATE() WHERE User_ID=3

SELECT GETDATE()

INSERT INTO Users (Username,Password,First_Name,Last_Name,User_Email,Company)

VALUES ('Comax','123456','Israel','Israeli','isisraeli@comax.com','Comax')

select*
from Users

select User_ID from Users where Username='ykolomeisky'

SELECT @@SERVERNAME

CREATE TABLE Order_Details (
      Detail_ID int NOT NULL PRIMARY KEY,
      Order_ID  int,
      Product_Name  varchar (255) not null,
      Barcode  varchar (255) not null,
      Qty  varchar (255) not null,
      Order_Date datetime  NOT NULL,
      Created_by varchar (255) not null)

      Select Product_Name,Barcode,Qty,Orders.Order_ID
      from Orders
      inner join Order_Details on Orders.Order_ID=Order_Details.Order_ID

      where Orders.Order_ID=11

      Delete From Orders where Order_ID>0
      Delete From Order_Details where Detail_ID>0

      select*from Orders
      select * from Order_Details