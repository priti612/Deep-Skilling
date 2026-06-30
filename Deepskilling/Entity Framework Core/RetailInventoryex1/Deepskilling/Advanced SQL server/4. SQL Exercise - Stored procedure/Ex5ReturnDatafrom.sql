create database Day1;
use Day1;

create table Emp
(
    Eid int primary key,
    Fname varchar(50),
    Lname varchar(50),
    Did int,
    Sal decimal(10,2)
);

insert into Emp values
(1,'John','Smith',1,50000),
(2,'Alice','Brown',2,60000),
(3,'David','Wilson',1,55000),
(4,'Ravi','Kumar',1,45000);

create procedure sp_CntEmp
@Did int
as
begin

select count(*) as TotEmp
from Emp
where Did=@Did;

end;

exec sp_CntEmp 1;