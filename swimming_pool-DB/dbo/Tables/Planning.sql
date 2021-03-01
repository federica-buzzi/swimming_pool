CREATE TABLE [dbo].[Planning]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ScheduledDays] NVARCHAR(50) NOT NULL, 
    [ScheduledTimeStart] NVARCHAR(50) NOT NULL, 
    [ScheduledTimeEnd] NVARCHAR(50) NOT NULL, 
    [ExtraInfo] NVARCHAR(50) NULL
)
