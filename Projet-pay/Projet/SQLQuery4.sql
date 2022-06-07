CREATE TABLE [dbo].[Ticket] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [id_user]       INT            NULL,
    [nom_user]      NVARCHAR (100) NULL,
    [email_user]    NVARCHAR (100) NULL,
    [phone_user]    INT            NULL,
    [nom_park]      NVARCHAR (100) NULL,
    [addresse_park] NVARCHAR (100) NULL,
    [numero_spot]   NVARCHAR (50)  NULL,
    [ville]         NVARCHAR (50)  NULL,
    [nombre_heure]  INT            NULL,
    [montant]       VARCHAR (50)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);