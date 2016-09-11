CREATE TABLE [dbo].[DrinkOrders] (
    [Id]         INT  IDENTITY(1,1)          NOT NULL,
    [OrderedOn]  DATETIME2 (2) NOT NULL,
	[TotalPrice] MONEY NOT NULL,
    [IsComplete] BIT           NOT NULL,
	CONSTRAINT [PK_DrinkOrders] PRIMARY KEY CLUSTERED ([Id] ASC)
);

