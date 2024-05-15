CREATE TABLE Products (
Id INT PRIMARY KEY,
Name NVARCHAR(50) NOT NULL
);



CREATE TABLE Categories (
Id INT PRIMARY KEY,
Name NVARCHAR(50) NOT NULL
);



INSERT INTO Products VALUES (1,'Baton'),(2,'Limonad'),(3,'Water'),(4,'Eggs')




INSERT INTO Categories VALUES (1,'Cat1'),(2,'Napitki'),(3,'Cat2')


CREATE TABLE ProductCategories(
ProductId INT FOREIGN KEY REFERENCES Products(Id) NOT NULL,
CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
PRIMARY KEY(ProductId, CategoryId)
);


INSERT INTO ProductCategories VALUES (2,2),(3,2),(4,1),(4,3)



SELECT Products.Name, Categories.Name
FROM Products
LEFT JOIN ProductCategories
ON Products.Id = ProductCategories.ProductId
LEFT JOIN Categories
ON ProductCategories.CategoryId = Categories.Id
