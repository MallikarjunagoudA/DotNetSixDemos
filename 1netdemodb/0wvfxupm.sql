IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212163025_init')
BEGIN
    CREATE TABLE [tblEmployee] (
        [PersonID] uniqueidentifier NOT NULL,
        [LastName] varchar(255) NULL,
        [FirstName] varchar(255) NULL,
        [Address] varchar(255) NULL,
        [City] varchar(255) NULL,
        CONSTRAINT [PK__tblEmplo__AA2FFB850E5E9DB0] PRIMARY KEY ([PersonID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212163025_init')
BEGIN
    CREATE TABLE [tblgmaas] (
        [gmaasPartnerid] uniqueidentifier NOT NULL,
        [Name] varchar(255) NULL,
        [Employeeid] uniqueidentifier NULL,
        [Address] varchar(255) NULL,
        [City] varchar(255) NULL,
        [testingColumn1] nvarchar(max) NULL,
        [testingColumn2] nvarchar(max) NULL,
        CONSTRAINT [PK__tblgmaas__78CE22081C81CEE6] PRIMARY KEY ([gmaasPartnerid]),
        CONSTRAINT [FK__tblgmaas__Employ__267ABA7A] FOREIGN KEY ([Employeeid]) REFERENCES [tblEmployee] ([PersonID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212163025_init')
BEGIN
    CREATE INDEX [IX_tblgmaas_Employeeid] ON [tblgmaas] ([Employeeid]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212163025_init')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230212163025_init', N'7.0.2');
END;
GO

COMMIT;
GO

