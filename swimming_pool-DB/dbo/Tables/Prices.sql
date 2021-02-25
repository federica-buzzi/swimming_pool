CREATE TABLE [dbo].[Prices] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [TicketType]  NVARCHAR (50) NOT NULL,
    [TicketPrice] FLOAT (53)    NOT NULL,
    [StGillois]   BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

