CREATE TABLE [dbo].[User] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [name]     NVARCHAR (100) NULL,
    [email]    NVARCHAR (50)  NULL,
    [phone]    INT            NULL,
    [password] NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Park] (
    [N*]          NCHAR (10)     NOT NULL,
    [nom]         NVARCHAR (50)  NULL,
    [addresse]    NVARCHAR (MAX) NULL,
    [matin/heure] NVARCHAR (50)  NULL,
    [nuit/heure]  NVARCHAR (50)  NULL,
    [ville]       NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([N*] ASC)
);