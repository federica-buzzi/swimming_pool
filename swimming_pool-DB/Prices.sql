﻿CREATE TABLE [dbo].[Table1]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TicketType] NVARCHAR(50) NOT NULL, 
    [TicketPrice] FLOAT NOT NULL, 
    [StGillois] BIT NOT NULL
)
