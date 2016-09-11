IF NOT EXISTS (SELECT 1 FROM Drinks)
BEGIN

SET IDENTITY_INSERT Drinks ON

INSERT INTO Drinks (Id, Name, Price)
VALUES
(1, 'Jack Daniels and Coke', 4.00),
(2, 'Vodka Tonic', 3.50),
(3, 'Screwdriver', 4.50),
(4, 'Martini', 6.00)

SET IDENTITY_INSERT Drinks OFF

END