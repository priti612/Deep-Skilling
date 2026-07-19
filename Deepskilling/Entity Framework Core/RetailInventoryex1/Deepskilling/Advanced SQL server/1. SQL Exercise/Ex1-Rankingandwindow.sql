CREATE DATABASE Day1;
USE Day1;

CREATE TABLE Products(
    id INT PRIMARY KEY,
    ProName VARCHAR(50),
    Category VARCHAR(60),
    Price INT
);

INSERT INTO Products VALUES
(1,'Laptop','Electronics',50000),
(2,'Mobile','Electronics',25000),
(3,'Shirt','Clothing',1000),
(4,'Jeans','Clothing',2000),
(5,'Refrigerator','Appliances',30000),
(6,'Washing Machine','Appliances',28000),
(7,'Headphones','Electronics',3000),
(8,'Shoes','Footwear',2500),
(9,'Watch','Accessories',5000),
(10,'Backpack','Accessories',1500);

SELECT * FROM Products;

-- ROW_NUMBER()

SELECT ProName,Category,Price,
ROW_NUMBER() OVER(
    PARTITION BY Category
    ORDER BY Price DESC
) AS RowNum
FROM Products;

-- RANK()

SELECT ProName,Category,Price,
RANK() OVER(
    PARTITION BY Category
    ORDER BY Price DESC
) AS RankNo
FROM Products;

-- DENSE_RANK()

SELECT ProName,Category,Price,
DENSE_RANK() OVER(
    PARTITION BY Category
    ORDER BY Price DESC
) AS DenseRankNo
FROM Products;

-- Top 3 Products in Each Category

WITH RankedProducts AS
(
    SELECT *,
    ROW_NUMBER() OVER(
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS rn
    FROM Products
)
SELECT *
FROM RankedProducts
WHERE rn <= 3;