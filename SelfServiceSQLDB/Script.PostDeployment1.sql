/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
USE [SelfServiceSQLDB]
GO
truncate TABLE [dbo].[Title]
Go
SET IDENTITY_INSERT [dbo].[Title] ON 
GO
INSERT [dbo].[Title] ([Id], [Description], [Active]) VALUES (1, N'Mr', 1)
GO
INSERT [dbo].[Title] ([Id], [Description], [Active]) VALUES (2, N'Ms', 1)
GO
INSERT [dbo].[Title] ([Id], [Description], [Active]) VALUES (3, N'Mrs', 1)
GO
INSERT [dbo].[Title] ([Id], [Description], [Active]) VALUES (4, N'Dr', 1)
GO
INSERT [dbo].[Title] ([Id], [Description], [Active]) VALUES (5, N'Prof', 1)
GO
SET IDENTITY_INSERT [dbo].[Title] OFF
GO
--truncate table [dbo].[Department]
--GO
SET IDENTITY_INSERT [dbo].[Department] ON 
GO
INSERT [dbo].[Department] ([Id], [Description], [Active]) VALUES (1, N'HR', 1)
GO
INSERT [dbo].[Department] ([Id], [Description], [Active]) VALUES (2, N'Dev', 1)
GO
INSERT [dbo].[Department] ([Id], [Description], [Active]) VALUES (3, N'Testing', 1)
GO
INSERT [dbo].[Department] ([Id], [Description], [Active]) VALUES (4, N'BI', 1)
GO
INSERT [dbo].[Department] ([Id], [Description], [Active]) VALUES (5, N'Finance', 1)
GO
INSERT [dbo].[Department] ([Id], [Description], [Active]) VALUES (6, N'IT Operations', 1)
GO
INSERT [dbo].[Department] ([Id], [Description], [Active]) VALUES (7, N'Intergrations', 1)
GO
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 
GO
INSERT [dbo].[Gender] ([Id], [Description]) VALUES (1, N'Male')
GO
INSERT [dbo].[Gender] ([Id], [Description]) VALUES (2, N'Female')
GO
SET IDENTITY_INSERT [dbo].[Gender] OFF
GO

--CREATE LOGIN [selfDev] WITH PASSWORD=N'+kJsFKuhGej4x7lM8BYfBc3UP9ygw3Y5QXlG9DWVi4M=', DEFAULT_DATABASE=[SelfServiceSQLDB], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
--GO

--ALTER LOGIN [selfDev] DISABLE
--GO

--ALTER SERVER ROLE [sysadmin] ADD MEMBER [selfDev]
--GO
--ALTER LOGIN [selfDev] ENABLE
--GO

