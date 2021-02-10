CREATE TABLE [dbo].[SwimSession]
(
	[IdSwimSession] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Date] DATE NOT NULL, 
    [TimeSlot] TIME NOT NULL, 
    [MaxCapacity] SMALLINT NOT NULL DEFAULT 30
)
