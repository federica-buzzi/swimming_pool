CREATE TABLE [dbo].[User]
(
	[IdUser] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Telephone] NCHAR(12) NOT NULL, 
    [Email] NVARCHAR(323) NOT NULL, 
    [isAdmin] BIT NOT NULL

)
