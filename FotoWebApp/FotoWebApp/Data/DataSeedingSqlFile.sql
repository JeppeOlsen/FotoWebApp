﻿-- En måde vi kan generere Insert statements til vores tabeller. 
-- Bruges kun til at generere nye insert statements, slet hvis du ikke skal bruge dem.
--SELECT 
--    'INSERT INTO Photographers (PhotographerId, Name) VALUES (' +
--    QUOTENAME(PhotographerId, '''') + ', ' +
--    QUOTENAME(Name, '''') + ');'
--FROM Photographers;

--SELECT 
--    'INSERT INTO Albums (AlbumId, Name, Deadline, AlbumLink, PhotographerId) VALUES (' +
--    QUOTENAME(AlbumId, '''') + ', ' +
--    QUOTENAME(Name, '''') + ', ' +
--    QUOTENAME(Deadline, '''') + ', ' +
--    QUOTENAME(AlbumLink, '''') + ', ' +
--    QUOTENAME(PhotographerId, '''') + ');'
--FROM Albums;

--SELECT 
--    'INSERT INTO Customers (CustomerId, Name, Email, Phone, AlbumId) VALUES (' +
--    QUOTENAME(CustomerId, '''') + ', ' +
--    QUOTENAME(Name, '''') + ', ' +
--    QUOTENAME(Email, '''') + ', ' +
--    QUOTENAME(Phone, '''') + ', ' +
--    QUOTENAME(AlbumId, '''') + ');'
--FROM Customers;


--Insert statements
Begin transaction;

SET IDENTITY_INSERT Photographers ON;
INSERT INTO Photographers (PhotographerId, Name) VALUES ('1', 'Ben');
INSERT INTO Photographers (PhotographerId, Name) VALUES ('2', 'Hans');
INSERT INTO Photographers (PhotographerId, Name) VALUES ('3', 'Kalle');
INSERT INTO Photographers (PhotographerId, Name) VALUES ('4', 'Henning');
SET IDENTITY_INSERT Photographers OFF;

SET IDENTITY_INSERT Albums ON;
INSERT INTO Albums (AlbumId, Name, Deadline, AlbumLink, PhotographerId) VALUES ('11', 'Solsikken', '2025-05-16 05:50:06.0000000', 'www.juhuuu.com', '1');
INSERT INTO Albums (AlbumId, Name, Deadline, AlbumLink, PhotographerId) VALUES ('12', 'Bavian', '2027-12-02 14:00:00.0000000', 'www.bavian.com', '4');
INSERT INTO Albums (AlbumId, Name, Deadline, AlbumLink, PhotographerId) VALUES ('17', 'Nike', '2025-05-16 13:00:00.0000000', 'www.Nike.com', '1');
SET IDENTITY_INSERT Albums OFF;

SET IDENTITY_INSERT Customers ON;
INSERT INTO Customers (CustomerId, Name, Email, Phone, AlbumId) VALUES ('1', 'Nike', 'nike@gmail.com', '12121212', '17');
INSERT INTO Customers (CustomerId, Name, Email, Phone, AlbumId) VALUES ('2', 'Janne', 'janne@gmail.com', '28367374', '11');
INSERT INTO Customers (CustomerId, Name, Email, Phone, AlbumId) VALUES ('3', 'Tøjbutikken', 'Tøj@gmail.com', '65653355', '12');
SET IDENTITY_INSERT Customers OFF;

Commit transaction;