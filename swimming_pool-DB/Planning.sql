CREATE TABLE [dbo].[Planning]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ScheduledDays] NVARCHAR(50) NOT NULL, 
    [ScheduledTimes] TIME NOT NULL, 
    [ExtraInfo] NCHAR(10) NULL
)
