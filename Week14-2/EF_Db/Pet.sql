CREATE TABLE [dbo].[Pet]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PName] NVARCHAR(50) NULL, 
    [Type] NVARCHAR(50) NULL, 
    [Age] INT NULL, 
    [OwnerId] INT NULL, 
    CONSTRAINT [FK_Pet_Owner] FOREIGN KEY ([OwnerId]) REFERENCES [Owner]([OwnerId])
)
