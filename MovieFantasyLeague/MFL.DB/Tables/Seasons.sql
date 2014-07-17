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
    [Budget] INT NOT NULL, 
    [ChampionTeamId] UNIQUEIDENTIFIER NULL, 
    CONSTRAINT [FK_Seasons_Teams] FOREIGN KEY ([ChampionTeamId]) REFERENCES [Teams]([TeamId]) 
)
