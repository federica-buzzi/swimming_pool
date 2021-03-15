CREATE TABLE [dbo].[SwimSession] (
    [IdSwimSession]           INT PRIMARY KEY IDENTITY NOT NULL,
    [SwimSessionDate]         NVARCHAR (50) NOT NULL,
    [SwimSessionTimeSlot]     NVARCHAR (50) NOT NULL,
    [SwimSessionNumberPeople] INT           NOT NULL,
    [SwimSessionMaxCapacity]  INT DEFAULT 5 NULL,
    
);

