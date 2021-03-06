﻿CREATE TABLE [dbo].[Leagues]
(
	[LeagueId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [IsPrivate] BIT NOT NULL, 
    [OwnerId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_League_Users] FOREIGN KEY ([OwnerId]) REFERENCES [Users]([UserId])
)
