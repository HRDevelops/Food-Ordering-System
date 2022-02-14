select*from Cart1
use FOS1
Drop table Cart1

create table Cart1(
ID varchar(255),
Names varchar(255),
Descrip varchar(255),
Price varchar(255),
Quantity varchar(255),
);

create table Order1(
ID int identity(1,1) not null,
Price money,
Quantity int,
);
