ALTER TABLE Users
ADD Last_Disconnection Datetime 

select *
from Users

select Top 1 Username
from Users
order by Last_Connection DESC

Insert into Orders (Order_Date,Created_by) Values(GETDATE(),'ykolomeisky')

select Top 1 Order_ID
from Orders
where Created_by='ykolomeisky'
order by Order_Date DESC



Select * From Users Where Username='ykolomeisky' and Password='123456'

UPDATE Users SET Last_Connection=GETDATE() WHERE User_ID=3

SELECT GETDATE()

INSERT INTO Users (Last_Connection)

VALUES (convert(datetime,'20-01-01 00:00:00 ',5))


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