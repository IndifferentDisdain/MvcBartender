CREATE TABLE [dbo].[DrinkOrderItems] (
    [Id]           INT IDENTITY(1,1)  NOT NULL,
    [DrinkOrderId] INT   NOT NULL,
    [DrinkId]      INT   NOT NULL,
    [Quantity]     INT   NOT NULL,
    [UnitPrice]    MONEY NOT NULL,
	CONSTRAINT [PK_DrinkOrderItems] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DrinkOrderItems_DrinkOrders] FOREIGN KEY ([DrinkOrderId]) REFERENCES [dbo].[DrinkOrders] ([Id]),
    CONSTRAINT [FK_DrinkOrderItems_Drinks] FOREIGN KEY ([DrinkId]) REFERENCES [dbo].[Drinks] ([Id])
);

