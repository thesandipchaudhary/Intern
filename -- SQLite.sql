-- SQLite
-- Projections
select * from Authors

--Get Name of persons who lives in canada
select Name from Authors where Address="Canada"




INSERT INTO AuthorDEtails
VALUES (NULL, 'MAster in CS', 'None', 'Appsoft', '1');
INSERT INTO AuthorDetails
VALUES (NULL, 'MIT', 'NLP/ML', 'AppSoft', 2);

--create Publishers table
CREATE TABLE Publishers(
    ID int PRIMARY KEY,
    Name nvarchar(200),
    Address nvarchar(400),
    Phone varchar(10),
    RegistrationNo nvarchar(100)
);

CREATE TABLE AuthorDEtails (
    ID int PRIMARY KEY,
    Education nvarchar(200),
    Publication nvarchar(400),
    Organization nvarchar(100),
    Authorid integer,
    FOREIGN KEY(Authorid) REFERENCES Authors(ID)
);


drop table Authors

--Create Authors table
CREATE TABLE Authors(
    ID integer PRIMARY KEY,
    Name nvarchar(350),
    Gender char(1),
    Address nvarchar(100),
    Email nvarchar(200),
    Dob varchar(100),
    BookId integer,
    FOREIGN KEY(BookId) REFERENCES Books(ID)
);
--Insert in Authors row
INSERT INTO Authors
VALUES (NULL, 'Ram','M', 'Canada', 'ram@gmail', '1990/07/15',1);
INSERT INTO Authors
VALUES (NULL, 'Gita','F', 'Nepal', 'gita@gmail', '2000/07/15',1);


--create Book table
CREATE TABLE Books (
    ID integer PRIMARY KEY,
    Title nvarchar(200),
    Edition nvarchar(400),
    Price varchar(500),
    ISBN nvarchar(100),
    Published nvarchar(100)

);
INSERT INTO Books
VALUES (NULL, 'Java', 'second', '1000', '12-345', '2024');

SELECT b.Title,a.Name
FROM Books b
INNER JOIN Authors a ON b.ID=a.Bookid;

select * from Books

drop table Books