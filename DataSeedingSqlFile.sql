-- En måde vi kan generere Insert statements til vores tabeller. 
-- Bruges kun til at generere nye insert statements, slet hvis du ikke skal bruge dem.
SELECT 
    'INSERT INTO Photographers (Column1, Column2, Column3) VALUES (' +
    QUOTENAME(PhotographerId, '''') + ', ' +
    QUOTENAME(Name, '''') + ');'
FROM Photographers;

SELECT 
    'INSERT INTO Albums (Column1, Column2, Column3) VALUES (' +
    QUOTENAME(AlbumId, '''') + ', ' +
    QUOTENAME(Name, '''') + ', ' +
    QUOTENAME(Deadline, '''') + ', ' +
    QUOTENAME(AlbumLink, '''') + ', ' +
    QUOTENAME(PhotographerId, '''') + ');'
FROM Albums;

SELECT 
    'INSERT INTO Customers (Column1, Column2, Column3) VALUES (' +
    QUOTENAME(CustomerId, '''') + ', ' +
    QUOTENAME(Name, '''') + ', ' +
    QUOTENAME(Email, '''') + ', ' +
    QUOTENAME(Phone, '''') + ', ' +
    QUOTENAME(AlbumId, '''') + ');'
FROM Customers;


-- Insert statements

