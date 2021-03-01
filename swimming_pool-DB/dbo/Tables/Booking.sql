CREATE TABLE [dbo].[Booking]
(
	[IdBooking] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdSwimSession] INT NOT NULL,
    FOREIGN KEY (IdSwimSession) REFERENCES [SwimSession](IdSwimSession),
    [IdUser] INT NOT NULL, 
    [Message] NVARCHAR(MAX) NULL, 
    [SpotsBooked] INT NOT NULL, 
    FOREIGN KEY (IdUser) REFERENCES [User](IdUser)
)
