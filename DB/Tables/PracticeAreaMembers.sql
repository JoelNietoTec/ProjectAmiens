CREATE TABLE [dbo].[PracticeAreaMembers]
(
	[PracticeAreaID] INT NOT NULL, 
    [AttorneyID] INT NOT NULL, 
    [IsLeader] TINYINT NULL, 
    [Active] TINYINT NULL, 
    CONSTRAINT [FK_PracticeAreaMembers_ToPracticeArea] FOREIGN KEY ([PracticeAreaID]) REFERENCES [PracticeAreas]([Id]), 
    CONSTRAINT [FK_PracticeAreaMembers_ToAttorneys] FOREIGN KEY ([AttorneyID]) REFERENCES [Employees]([Id]) 
)

GO

CREATE UNIQUE CLUSTERED INDEX [PracticeAreaMembers_Index] ON [dbo].[PracticeAreaMembers] ([PracticeAreaID], [AttorneyID])
