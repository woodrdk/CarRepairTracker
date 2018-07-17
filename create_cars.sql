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
	BrandID int IDENTITY(1,1) NOT NULL,
	BrandName  varchar(50) NOT NULL,
	YearStarted int,
	YearEnded int
)
GO

SET IDENTITY_INSERT Makes ON 
INSERT Makes (BrandID, BrandName, YearStarted, YearEnded) VALUES 
(1, 'Dodge', 1900, 2018),
(2, 'Honda', 1963 , 2018)

SET IDENTITY_INSERT Makes OFF
GO

Select* 
from Makes

/****** Object:  Table Makes  ******/   
CREATE TABLE Models(
	ModelID int IDENTITY(1,1) NOT NULL,
	ModelName  varchar(50) NOT NULL,
	ModelYearStart int,
	ModelYearEnd int
)
GO

SET IDENTITY_INSERT Models ON 
INSERT Models(ModelID, ModelName, ModelYearStart, ModelYearEnd) VALUES 
(1, 'Accord', 1982, 2018),
(2, 'Magnum', 2005, 2008)


SET IDENTITY_INSERT Models OFF
GO

Select* 
from Models

SELECT BrandName
From Makes


SELECT column_name(s)
FROM table_name
WHERE column_name BETWEEN value1 AND value2;