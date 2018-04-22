CREATE TABLE [dbo].[Member] (
    [Id]     INT           NOT NULL,
    [name]   NCHAR (10)    NULL,
    [Phone]  NVARCHAR (50) NULL,
    [Gender] NCHAR (10)    NULL,
    [Email]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

