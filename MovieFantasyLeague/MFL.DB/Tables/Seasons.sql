CREATE TABLE [dbo].[Seasons]
(
	[SeasonId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [StartDate] DATE NOT NULL, 
    [EndDate] DATE NOT NULL, 
    [LastUpdateDate] DATE NOT NULL, 
    [StartEdits] DATE NOT NULL, 
    [EndEdits] DATE NOT NULL, 
    [Note] NTEXT NULL, 
    [ChampionId] UNIQUEIDENTIFIER NULL, 
    [Budget] INT NOT NULL, 
    CONSTRAINT [FK_Seasons_Users] FOREIGN KEY ([ChampionId]) REFERENCES [Users]([UserId])
)
