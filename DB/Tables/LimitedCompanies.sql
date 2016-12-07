CREATE TABLE [dbo].[LimitedCompanies]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[ClientID] INT NOT NULL, 
	[AttorneyID] INT NOT NULL,
    [TypeID] INT NOT NULL, 
    [Name] NVARCHAR(200) NULL,
	[CountryID] INT NOT NULL, 
    [JurisdictionID] INT NOT NULL, 
    [ActivityID] INT NOT NULL, 
    [CreateDate] DATE NULL, 
    [Document] VARCHAR(20) NULL, 
    [DocumentNumber] VARCHAR(20) NULL, 
    [DocumentDate] NCHAR(10) NULL, 
    [ActivationDate] DATE NULL, 
    [Status] CHAR NOT NULL, 
    CONSTRAINT [FK_LimitedCompanies_ToClients] FOREIGN KEY ([ClientID]) REFERENCES [Clients]([Id]), 
    CONSTRAINT [FK_LimitedCompanies_ToAttorneys] FOREIGN KEY ([AttorneyID]) REFERENCES [Employees]([Id]), 
    CONSTRAINT [FK_LimitedCompanies_ToCountries] FOREIGN KEY ([CountryID]) REFERENCES [Countries]([Id]), 
    CONSTRAINT [FK_LimitedCompanies_ToType] FOREIGN KEY ([TypeID]) REFERENCES [CompanyTypes]([Id]), 
    CONSTRAINT [FK_LimitedCompanies_ToActivities] FOREIGN KEY ([ActivityID]) REFERENCES [CompanyActivities]([Id]) 
)
