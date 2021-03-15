CREATE TABLE [dbo].[Booking] (
    [IdBooking] INT IDENTITY NOT NULL,
    [Message]   NVARCHAR (MAX) NULL, 
    [IdSwimSession] INT NOT NULL, 
    [IdUser] INT NOT NULL,
    CONSTRAINT PK_Booking PRIMARY KEY ([IdBooking]),
    CONSTRAINT FK_Booking_SwimSession FOREIGN KEY ([IdSwimSession]) REFERENCES [SwimSession](IdSwimSession),
    CONSTRAINT FK_Booking_User FOREIGN KEY ([IdUser]) REFERENCES [User](IdUser),
);




