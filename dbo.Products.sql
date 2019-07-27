CREATE TABLE [dbo].[Products] (
    [Id]       INT            NOT NULL,
    [Serial]   INT            NULL,
    [Name]     NVARCHAR (MAX) NOT NULL,
    [Size]     NVARCHAR (5)   NOT NULL,
    [Color]    NVARCHAR (50)  NULL,
    [Quantity] INT            NOT NULL,
    [Price]    FLOAT (53)     NOT NULL,
    [ActPrice] FLOAT NOT NULL, 
    [SoldQuantity] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

