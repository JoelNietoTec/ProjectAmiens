﻿CREATE TABLE [dbo].[ClientTypes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Name] NVARCHAR(50) NOT NULL, 
	[CreateDate] DATETIME NULL, 
	[ModifyDate] DATETIME NULL
)