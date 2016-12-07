CREATE TABLE [dbo].[Matters]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[ClientId] INT NOT NULL, 
	[AttorneyID] INT NOT NULL,
	[MatterTypeID] INT NOT NULL, 
	[Title] NVARCHAR(150) NULL, 
	[Description] NCHAR(10) NULL,
	[PracticeAreaID] INT NOT NULL, 
	[OpeningDate] DATE NULL, 
	[AdvanceBalance] MONEY NULL, 
	[StatusId] INT NOT NULL, 
	[CreateDate] DATETIME NULL, 
	[ModifyDate] DATETIME NULL, 
	CONSTRAINT [FK_Matters_ToClients] FOREIGN KEY ([ClientId]) REFERENCES [Clients]([Id]), 
	CONSTRAINT [FK_Matters_ToAttorneys] FOREIGN KEY ([AttorneyID]) REFERENCES [Employees]([Id]), 
	CONSTRAINT [FK_Matters_ToMatterTypes] FOREIGN KEY ([MatterTypeID]) REFERENCES [MatterTypes]([Id]), 
    CONSTRAINT [FK_Matters_ToPracticeAreas] FOREIGN KEY ([PracticeAreaID]) REFERENCES [PracticeAreas]([Id]) 
)