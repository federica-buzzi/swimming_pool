CREATE TABLE [dbo].[Prices] (
    [IdPrices]    INT           IDENTITY (1, 1) NOT NULL,
    [TicketType]  NVARCHAR (50) NOT NULL,
    [TicketPrice] FLOAT (53)    NOT NULL,
    [StGillois]   BIT           NOT NULL,
    CONSTRAINT [PK__tmp_ms_x__0781BE019DA781E3] PRIMARY KEY CLUSTERED ([IdPrices] ASC)
);





