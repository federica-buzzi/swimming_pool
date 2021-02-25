CREATE TABLE [dbo].[Planning]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ScheduledDays] NVARCHAR(50) NOT NULL, 
    [ScheduledTimes] NVARCHAR(50) NOT NULL, 
    [ExtraInfo] NCHAR(10) NOT NULL
)
