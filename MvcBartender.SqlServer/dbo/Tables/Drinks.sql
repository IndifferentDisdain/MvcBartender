CREATE TABLE [dbo].[Drinks] (
    [Id]    INT  IDENTITY(1,1)        NOT NULL,
    [Name]  VARCHAR (50) NOT NULL,
    [Price] MONEY        NOT NULL,
	CONSTRAINT [PK_Drinks] PRIMARY KEY CLUSTERED ([Id] ASC)
);

