create database Day1;
use Day1;

create table Emp
(
    Eid int identity(1,1) primary key,
    Fname varchar(50),
    Lname varchar(50),
    Did int,
    Sal decimal(10,2),
    Jdate date
);

insert into Emp
(Fname,Lname,Did,Sal,Jdate)
values
('John','Smith',1,50000,'2023-01-10'),
('Alice','Brown',2,60000,'2022-05-15'),
('David','Wilson',1,55000,'2021-08-20');

create procedure sp_GetEmp
@Did int
as
begin
    select *
    from Emp
    where Did=@Did;
end;

exec sp_GetEmp 1;


create procedure sp_AddEmp
@Fname varchar(50),
@Lname varchar(50),
@Did int,
@Sal decimal(10,2),
@Jdate date
as
begin

insert into Emp
(Fname,Lname,Did,Sal,Jdate)
values
(@Fname,@Lname,@Did,@Sal,@Jdate);

end;