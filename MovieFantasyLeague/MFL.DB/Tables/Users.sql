CREATE TABLE [dbo].[Users]
(
	[UserId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(100) NOT NULL, 
    [IsAdmin] BIT NOT NULL, 
    [ReceiveEmails] BIT NOT NULL
)
