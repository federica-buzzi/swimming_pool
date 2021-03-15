CREATE TABLE [dbo].[Planning]
(
	[IdPlanning] INT PRIMARY KEY IDENTITY  NOT NULL, 
    [ScheduledDays] NVARCHAR(50) NOT NULL, 
    [ScheduledTimeStart] NVARCHAR(50) NOT NULL, 
    [ScheduledTimeEnd] NVARCHAR(50) NOT NULL, 
    [ExtraInfo] NVARCHAR(50) NULL
)
