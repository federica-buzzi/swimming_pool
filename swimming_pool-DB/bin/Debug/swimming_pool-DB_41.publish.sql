﻿/*
Deployment script for swimming_pool_DB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "swimming_pool_DB"
:setvar DefaultFilePrefix "swimming_pool_DB"
:setvar DefaultDataPath "C:\Users\User\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\User\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
The type for column Password in table [dbo].[User] is currently  NVARCHAR (MAX) NOT NULL but is being changed to  VARBINARY (32) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARBINARY (32) NOT NULL.

The type for column Salt in table [dbo].[User] is currently  NCHAR (8) NOT NULL but is being changed to  CHAR (8) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  CHAR (8) NOT NULL.
*/

IF EXISTS (select top 1 1 from [dbo].[User])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Dropping [dbo].[FK_Booking_User]...';


GO
ALTER TABLE [dbo].[Booking] DROP CONSTRAINT [FK_Booking_User];


GO
PRINT N'Starting rebuilding table [dbo].[User]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_User] (
    [IdUser]    INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (50)  NOT NULL,
    [LastName]  NVARCHAR (50)  NOT NULL,
    [Telephone] NCHAR (12)     NOT NULL,
    [Email]     NVARCHAR (323) NOT NULL,
    [Password]  VARBINARY (32) NOT NULL,
    [Salt]      CHAR (8)       NOT NULL,
    [UserName]  NCHAR (10)     NOT NULL,
    PRIMARY KEY CLUSTERED ([IdUser] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[User])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_User] ON;
        INSERT INTO [dbo].[tmp_ms_xx_User] ([IdUser], [FirstName], [LastName], [Telephone], [Email], [Password], [Salt], [UserName])
        SELECT   [IdUser],
                 [FirstName],
                 [LastName],
                 [Telephone],
                 [Email],
                 CAST ([Password] AS VARBINARY (32)),
                 [Salt],
                 [UserName]
        FROM     [dbo].[User]
        ORDER BY [IdUser] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_User] OFF;
    END

DROP TABLE [dbo].[User];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_User]', N'User';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Creating [dbo].[FK_Booking_User]...';


GO
ALTER TABLE [dbo].[Booking] WITH NOCHECK
    ADD CONSTRAINT [FK_Booking_User] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([IdUser]);


GO
PRINT N'Refreshing [dbo].[V_Full_Reservation_User]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[V_Full_Reservation_User]';


GO
PRINT N'Altering [dbo].[SP_User_Insert]...';


GO
ALTER PROCEDURE [dbo].[SP_User_Insert]
	 @firstName NVARCHAR (50), 
     @lastName  NVARCHAR (50),
     @telephone NCHAR (12),
     @email     NVARCHAR (323),
     @password VARBINARY(32), 
     @userName NCHAR(10)
AS
    DECLARE @salt CHAR(8)
    SET @salt = [dbo].SF_GenerateSalt()
	INSERT INTO [User] ([FirstName],[LastName], [Telephone], [Email], [Password], [Salt], [Username]) 
    OUTPUT inserted.IdUser
    VALUES (@firstName, @lastName, @telephone ,@email ,dbo.SF_EncryptedPassword(@password, @salt), @salt, @userName)
GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Booking] WITH CHECK CHECK CONSTRAINT [FK_Booking_User];


GO
PRINT N'Update complete.';


GO
