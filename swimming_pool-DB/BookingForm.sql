CREATE TABLE [dbo].[BookingForm]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NCHAR(10) NOT NULL, 
    [SpotsBooked] INT NOT NULL, 
    [Email] NVARCHAR(323) NOT NULL, 
    [Telephone] NCHAR(12) NOT NULL, 
    [Date] DATE NOT NULL, 
    [TimeSlot] TIME NOT NULL, 
    [Message] NVARCHAR(MAX) NULL
)
