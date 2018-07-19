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

/****** Object:  Table Models  ******/   
CREATE TABLE Models(
	ModelID int IDENTITY(1,1) NOT NULL,
	ModelName  varchar(50) NOT NULL,
	ModelYearStart int,
	ModelYearEnd int
)
GO


INSERT Models(ModelName, ModelYearStart, ModelYearEnd) VALUES 

('Magnum', 2005, 2008),

('Avenger', 1995, 2000),
('Avenger', 2007, 2014),
('Caravan Passenger', 1984, null),
('Dakota', 1987, 2011),
('Durango', 1998, null),
('Intrepid', 1993, 2004),
('Neon', 1995, 2005),
('Ram', 1981, null),
('Ram Van', 1971, 2003),
('Stratus', 1995, 2006),
('Viper', 1991, 2017),

('Accord', 1976, null),
('Civic', 1972, null),
('CR-V', 1995, null),
('Insight', 1999, 2006),
('Insight', 2009, 2014),
('Insight', 2019, null),
('Odyssey', 1995, null),
('Passport', 1994, 2002),
('Prelude',  1978, 2001),
('S2000', 1999, 2008)

SET IDENTITY_INSERT Models OFF
GO



/****** Object:  Table Users  ******/   
CREATE TABLE Users(
	UserID int IDENTITY(1,1) NOT NULL,
	UserName  varchar(50) NOT NULL,

)
GO

SET IDENTITY_INSERT Users ON 
INSERT Users(UserID,UserName) VALUES 
(1, 'Anthony McMann'),
(2, 'Robert Wood')


SET IDENTITY_INSERT Users OFF
GO

Select * 
From Users

Select * 
from Models

SELECT BrandName
From Makes


Select ModelName
From Models 
where ModelYearStart <= 2009 AND (ModelYearEnd >= 2009 OR ModelYearEnd IS NULL);