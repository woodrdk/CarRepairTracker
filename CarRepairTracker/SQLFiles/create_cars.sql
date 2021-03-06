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
	MakeID int IDENTITY(1,1) NOT NULL,
	Name  varchar(50) NOT NULL,
	YearStarted int,
	YearEnded int
)
GO

Select* 
from Makes

/****** Object:  Table Models  ******/   
CREATE TABLE Models(
	ModelID int IDENTITY(1,1) NOT NULL,
	Name  varchar(50) NOT NULL,
	YearStarted int,
	YearEnded int
)
GO

/****** Object:  Table Users  ******/   
CREATE TABLE Users(
	UserID int IDENTITY(1,1) NOT NULL,
	UserName  varchar(50) NOT NULL,
)
GO






--Select * 
--From Users

--Select * 
--from Models

--SELECT BrandName
--From Makes
--where YearStarted <= 2009 AND (YearEnded >= 2009 OR YearEnded IS NULL);

--Select ModelName
--From Models 
--where ModelYearStart <= 2009 AND (ModelYearEnd >= 2009 OR ModelYearEnd IS NULL);