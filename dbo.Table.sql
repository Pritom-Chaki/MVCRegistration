CREATE TABLE [dbo].[Table]
(
    [UserID] INT NOT NULL PRIMARY KEY IDENTITY , 
    [Username] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [FullName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL
)
