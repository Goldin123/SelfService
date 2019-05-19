CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeID] INT NULL, 
    [PhysicalAddressLine1] VARCHAR(100) NULL, 
    [PhysicalAddressLine2] VARCHAR(100) NULL, 
    [PhysicalAddressLine3] VARCHAR(100) NULL, 
    [PhysicalCode] VARCHAR(10) NULL, 
    [PostalAddressLine1] VARCHAR(100) NULL, 
    [PostalAddressLine2] VARCHAR(100) NULL, 
    [PostalAddressLine3] VARCHAR(100) NULL, 
    [PostalCode] VARCHAR(10) NULL, 
    [DateAdded] DATETIME NULL, 
    [DateUpdated] DATETIME NULL, 
    [DateDeleted] DATETIME NULL, 
    [Active] BIT NULL, 
    CONSTRAINT [FK_Address_Employee] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employee]([Id]) 
)
