CREATE TABLE [dbo].[Admin]
(
	[IdAdmin] INT PRIMARY KEY IDENTITY NOT NULL, 
    [AdminName] NCHAR(10) NOT NULL, 
    [AdminPassword] VARBINARY(32) NOT NULL, 
    [Salt] CHAR(8) NOT NULL
)
