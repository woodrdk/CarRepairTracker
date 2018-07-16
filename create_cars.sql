USE master
GO

/****** Object:  Database Cars     ******/
IF DB_ID('Cars') IS NOT NULL
	DROP DATABASE Cars
GO

CREATE DATABASE Cars
GO 

USE Cars
GO

/****** Object:  Table Makes  ******/   
CREATE TABLE Makes(
	VendorID int IDENTITY(1,1) NOT NULL,
	Le varchar(50) NULL,
	Fe varchar(50) NULL
)
GO

SET IDENTITY_INSERT ContactUpdates ON 
INSERT ContactUpdates (VendorID, LastName, FirstName) VALUES 
(5, 'Davison', 'Michelle'),
(123, 'Bucket', 'Charles')

SET IDENTITY_INSERT ContactUpdates OFF
GO
