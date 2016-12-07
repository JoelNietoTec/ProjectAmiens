CREATE TABLE [dbo].[CompanyTypes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(100) NULL, 
    [Status] CHAR NOT NULL
)
