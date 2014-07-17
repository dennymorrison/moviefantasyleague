CREATE TABLE [dbo].[Teams]
(
	[TeamId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [UserId] UNIQUEIDENTIFIER NOT NULL, 
    [LeagueId] UNIQUEIDENTIFIER NOT NULL, 
    [SeasonId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_Teams_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]), 
    CONSTRAINT [FK_Teams_Leagues] FOREIGN KEY ([LeagueId]) REFERENCES [Leagues]([LeagueId]), 
    CONSTRAINT [FK_Teams_Seasons] FOREIGN KEY ([SeasonId]) REFERENCES [Seasons]([SeasonId])
)
