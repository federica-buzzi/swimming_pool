CREATE TABLE [dbo].[BookingForm] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (50)  NOT NULL,
    [LastName]    NVARCHAR(50)     NOT NULL,
    [SpotsBooked] INT            NOT NULL,
    [Email]       NVARCHAR (323) NOT NULL,
    [Telephone]   NCHAR (12)     NOT NULL,
    [BookingDate]        DATE           NOT NULL,
    [Message]     NVARCHAR (MAX) NULL,
    [BookingTime] NVARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

