CREATE TABLE [dbo].[User] (
    [IdUser]    INT PRIMARY KEY IDENTITY NOT NULL,
    [FirstName] NVARCHAR (50)  NOT NULL,
    [LastName]  NVARCHAR (50)  NOT NULL,
    [Telephone] NCHAR (12)     NOT NULL,
    [Email]     NVARCHAR (323) NOT NULL,
    [Password] NVARCHAR(MAX) NOT NULL, 
    [Salt] CHAR(8) NOT NULL, 
    [UserName] NCHAR(10) NOT NULL,

);


