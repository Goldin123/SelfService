USE [SelfServiceSQLDB]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [dev]    Script Date: 17/05/2019 07:29:06 AM ******/
CREATE LOGIN [dev] WITH PASSWORD=N'q8q62CNW/mF9zeAm/ew/asMPlhzupvpTUnJlWqP4140=', DEFAULT_DATABASE=[SelfServiceSQLDB], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO

ALTER LOGIN [dev] DISABLE
GO

ALTER SERVER ROLE [sysadmin] ADD MEMBER [dev]
GO

ALTER LOGIN [dev] ENABLE
GO