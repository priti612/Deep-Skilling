use Day1;

create table Department(
	deptId int primary key,
    deptName varchar(100)
    );

create table Employe(
emplyId int primary key,
firstName varchar(50),
lastName varchar(50),
deptId int,
salary decimal(10,2),
joinDate date,

foreign key(deptId)
references Department(deptId)
);


insert into Department values
(1,'HR'),
(2,'IT'),
(3,'Finance');

INSERT INTO Employees VALUES
(101,'John','Smith',1,50000,'2022-01-15'),
(102,'Alice','Brown',2,60000,'2021-05-20'),
(103,'David','Wilson',3,70000,'2020-08-10');


CREATE VIEW vw_EmployeeBasicInfo AS
SELECT
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    d.DepartmentName
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID;


SELECT * FROM vw_EmployeeBasicInfo;

CREATE VIEW vw_EmployeeFullName AS
SELECT
    EmployeeID,
    CONCAT(FirstName,' ',LastName) AS FullName
FROM Employees;

SELECT * FROM vw_EmployeeFullName;

CREATE VIEW vw_EmployeeAnnualSalary AS
SELECT
    EmployeeID,
    FirstName,
    LastName,
    Salary,
    Salary * 12 AS AnnualSalary
FROM Employees;

SELECT * FROM vw_EmployeeAnnualSalary;

CREATE VIEW vw_EmployeeReport AS
SELECT
    e.EmployeeID,
    CONCAT(e.FirstName,' ',e.LastName) AS FullName,
    d.DepartmentName,
    e.Salary * 12 AS AnnualSalary,
    (e.Salary * 12) * 0.10 AS Bonus
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID;

SELECT * FROM vw_EmployeeReport;

SHOW FULL TABLES
WHERE Table_type = 'VIEW';

DROP VIEW vw_EmployeeReport;


