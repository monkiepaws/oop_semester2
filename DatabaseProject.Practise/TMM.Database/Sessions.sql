CREATE TABLE [dbo].[Sessions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SessionStartTime] DATETIME NOT NULL, 
    [SessionEndTime] DATETIME NOT NULL, 
    [Name] TEXT NOT NULL, 
    [Description] TEXT NOT NULL, 
    [Topic] TEXT NOT NULL, 
    [TeacherName] TEXT NOT NULL, 
    [Location] TEXT NOT NULL
)
