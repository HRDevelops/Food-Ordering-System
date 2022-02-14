--create database FOS1
--use FOS1
--create table Admin(
--AdID  int primary key NOT NULL,
--AdAddress varchar(255),
--AdName varchar(255),
--AdPswrd  varchar(255),
--AdCell float,
--);

--create table Employee(
--EmpID  int primary key NOT NULL,
--EmpAddress varchar(255),
--EmpName varchar(255),
--EmpPswrd  varchar(255),
--EmpCell float,
--);

--create table Customer(
--CustID  int primary key NOT NULL,
--CustAddress varchar(255),
--CustName varchar(255),
--CustPswrd  varchar(255),
--CustCell float,
--);



--create table Product(
--ProdID  varchar(255) primary key NOT NULL,
--ProdDesc varchar(255),
--ProdName varchar(255),
--ProdPrice  money,
--);
--select*from Product
--use FOS1

--delete from Product
--select * from Product
--insert into Product(ProdID,ProdName,ProdDesc,ProdPrice)
--Values('1','BPC', 'Fried',75)
--insert into Product(ProdID,ProdName,ProdDesc,ProdPrice)
--Values('2','LPC', 'Chiecken',75)
--insert into Product(ProdID,ProdName,ProdDesc,ProdPrice)
--Values('4003','Black Pepper Chiecken', 'Fried Chiecken with slizing black pepper',75)
--insert into Product(ProdID,ProdName,ProdDesc,ProdPrice)
--Values('4004','Black Pepper Chiecken', 'Fried Chiecken with slizing black pepper',75)
--insert into Product(ProdID,ProdName,ProdDesc,ProdPrice)
--Values('4005','Black Pepper Chiecken', 'Fried Chiecken with slizing black pepper',75)

--create table Menu(
--MenuID  varchar(255) primary key NOT NULL,
--ProdID  varchar(255) ,
--ProdDesc varchar(255),
--ProdName varchar(255),
--ProdPrice  money,
--ProdImg image,
--);

--create table Cart(
--CartID  int primary key NOT NULL,
--ProdID varchar(255),
--ProdQuantity varchar(255),
--TotalPrice  money,
--UnitPrice money,
--);

--Drop table Cart1

--create table Cart1(
--ID varchar(255),
--Names varchar(255),
--Descrip varchar(255),
--Price varchar(255),
--Quantity varchar(255)

--);

--create table Cart2(
--ID varchar(255),
--Names varchar(255),
--Descrip varchar(255),
--Price varchar(255),
--Quantity varchar(255),
--TransferType varchar(255),
--Addres varchar(255)

--);

--select * from cart2
--select*from Admin
--insert into Admin(AdID,AdName,AdAddress,AdCell,AdPswrd)
--Values(2001,'HR', 'ABC',75,'qwe')

--insert into Employee(EmpID,EmpName,EmpAddress,EmpCell,EmpPswrd)
--Values(3001,'HR', 'DFG',95,'qwe')

--insert into Customer(CustID,CustName,CustAddress,CustCell,CustPswrd)
--Values(4001,'HR', 'DFG',15,'qwe')


-----------------------------------------------------------------------

--select * from cart1
--select * from cart2
--select * from customer;
--use FOS1
--select * from Cart1;
--select Top(2) * from Cart1 Order by ID DESC;
--select * from Cart2
--select *from Product
--drop table Employee
--create table Customer(
--CustID  int primary key NOT NULL,
--CustName varchar(255),
--CustAddress varchar(255),
--CustCell float,
--CustPswrd  varchar(255)
--);

--create table Employee(
--EmpID  int primary key NOT NULL,
--EmpName varchar(255),
--EmpAddress varchar(255),
--EmpCell float,
--EmpPswrd  varchar(255)
--);
--select * from Customer