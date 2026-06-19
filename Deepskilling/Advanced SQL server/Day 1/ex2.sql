use Day1;
create table Orders(
odID int primary key,
custId int,
Amount int);

insert into Orders values

(101,1,500),
(102,1,700),
(103,1,300),
(104,1,200),

(105,2,1000),
(106,2,600),

(107,3,900),
(108,3,700),
(109,3,800),
(110,3,500),
(111,3,400);
select * from Orders;
show tables;
with CoustomerOrder as(
select custId,count(*) as TotalOrder
from Orders
group by custId)
select * from CoustomerOrder where TotalOrder>3;

with recursive Calendar as(
select date("2025-01-01") as dt
union all
select date_add(dt,interval 1 day)
from Calendar
where dt <"2025-01-31"
)
select * from Calendar;

create table employee(
empId int primary key,
empName varchar(50),
manageId int);
insert into employee values
(1,'CEO',NULL),
(2,'Manager A',1),
(3,'Manager B',1),
(4,'Developer A',2),
(5,'Developer B',2);
select * from employee;

with  recursive empHierarchy  as (
select empId,
empName,
manageId, 1 as LevelNo
from employee
where manageId is null
union all
 select e.empId,
e.empName,
e.manageId,eh.LevelNo+1
from employee e
join empHierarchy eh
on e.manageId=eh.empId
)
select * from empHierarchy;
show tables;
select version();


create table Products1(
proId int primary key,
proName varchar(40),
price int
);

insert into products1 values
(1,'Laptop',50000),
(2,'Mobile',25000);

merge products1 as p
using StagingProduct as S
on p.proId=S.proId

when matched then update set
p.price =S.price
when not matched then insert(proId,proName,price)
values(s.proId,s.proName,s.price);

INSERT INTO Products
(ProductID, ProductName, Price)
VALUES
(1,'Laptop',55000)

ON DUPLICATE KEY UPDATE
Price = VALUES(Price);
