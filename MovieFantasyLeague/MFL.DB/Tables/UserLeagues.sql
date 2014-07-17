CREATE TABLE [dbo].[UserLeagues]
(
	[UserId] UNIQUEIDENTIFIER NOT NULL , 
    [LeagueId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [PK_UserLeagues] PRIMARY KEY ([UserId], [LeagueId]), 
    CONSTRAINT [FK_UserLeagues_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]), 
    CONSTRAINT [FK_UserLeagues_Leagues] FOREIGN KEY ([LeagueId]) REFERENCES [Leagues]([LeagueId])
)
