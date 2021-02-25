CREATE TABLE [dbo].[Week]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [monday] BIT NOT NULL, 
    [tuesday] BIT NOT NULL, 
    [wednesday] BIT NOT NULL, 
    [thursday] BIT NOT NULL, 
    [friday] BIT NOT NULL, 
    [saturday] BIT NOT NULL, 
    [sunday] BIT NOT NULL
)
