CREATE DATABASE Day1;
use Day1;

create table Produts(
id INT PRIMARY KEY,
ProName char,
category char(60),
prices int
);
insert into Produts values
(1, 'Laptop', 'Electronics', 50000),
(2, 'Mobile', 'Electronics', 25000),
(3, 'Shirt', 'Clothing', 1000),
(4, 'Jeans', 'Clothing', 2000),
(5, 'Refrigerator', 'Appliances', 30000),
(6, 'Washing Machine', 'Appliances', 28000),
(7, 'Headphones', 'Electronics', 3000),
(8, 'Shoes', 'Footwear', 2500),
(9, 'Watch', 'Accessories', 5000),
(10, 'Backpack', 'Accessories', 1500);
SELECT * FROM Produts;

select ProName,category,prices,row_number() over(
partition by category
order by prices desc 
) as RowNum
from produts;

select ProName, category,prices, rank() over(
partition by category
order by prices desc
) as RankNo 
from produts;

select ProName,category,prices, dense_rank() over(
partition by category
order by prices desc
) as denserank
from produts;

with rankedproducts as (
select *, row_number() over(
partition by category
order by prices desc
) as rn
from produts
)
select * from rankedproducts where rn<=3;


-- //////////////


create table Sales(
Region varchar(20),
Category varchar(20),
quantity int
);

insert into Sales values
('East', 'Electronics', 100),
('East', 'Clothing', 50),
('West', 'Electronics', 80),
('West', 'Clothing', 40),
('North', 'Electronics', 70),
('North', 'Clothing', 30);

select * from Sales;

select Region,Category,sum(quantity) as totalqQnty
from Sales
group by Region,category;


select Region ,Category,Sum(quantity) as totalQty
from Sales
group by Region,Category with rollup;

select Region,category,sum(quantity) as totalQty
from Sales
group by CUBE(Region,Category);

select Region,Category, SUM(quantity) as totalQty
from Sales
group by grouping set(
(Region),
(Category),(Region,Category)
);