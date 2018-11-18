CREATE TABLE [dbo].[Beacon]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Username] NVARCHAR(MAX) NULL, 
    [Game] NVARCHAR(50) NULL, 
    [StartTime] DATETIME NULL, 
    [EndTime] DATETIME NULL
)
