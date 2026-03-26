CREATE TABLE [dbo].[Musteriler] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [KullaniciAdi] NVARCHAR (50) NULL,
    [Sifre]        NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);