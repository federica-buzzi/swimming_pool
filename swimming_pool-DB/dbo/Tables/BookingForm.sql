CREATE TABLE [dbo].[BookingForm] (
    [IdBookingForm]          INT PRIMARY KEY  IDENTITY NOT NULL,
    [FirstName]   NVARCHAR (50)  NOT NULL,
    [LastName]    NVARCHAR(50)     NOT NULL,
    [SpotsBooked] INT            NOT NULL,
    [Email]       NVARCHAR (323) NOT NULL,
    [Telephone]   NCHAR (12)     NOT NULL,
    [BookingDate]        DATE           NOT NULL,
    [Message]     NVARCHAR (MAX) NULL,
    [BookingTime] NVARCHAR(50) NOT NULL, 
);

