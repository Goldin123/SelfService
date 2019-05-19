CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] VARCHAR(5) NULL, 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Email] VARCHAR(100) NULL, 
	[Gender] VARCHAR(10) NULL,
	[Cell] VARCHAR(20) NULL, 
	[DepartmentID] INT NULL,
    [Telephone] VARCHAR(20) NULL, 
    [DateCreated] DATETIME NULL, 
    [DateUpdated] DATETIME NULL, 
    [DateDeleted] DATETIME NULL, 
    [Active] BIT NULL, 
    CONSTRAINT [FK_Employee_Department] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Department]([Id])     
)
