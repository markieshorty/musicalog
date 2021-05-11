CREATE TABLE [dbo].[Albums] (
    [AlbumId]      INT           IDENTITY (1, 1) NOT NULL,
    [AlbumName]    VARCHAR (255) NULL,
    [Artist]       VARCHAR (255) NOT NULL,
    [PhysicalType] VARCHAR (10)  NULL,
    [Stock]        INT           NULL,
    [RecordLabel]  VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([AlbumId] ASC)
);

