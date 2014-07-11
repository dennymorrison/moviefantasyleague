CREATE TABLE [dbo].[UserSeasons]
(
	[UserId] UNIQUEIDENTIFIER NOT NULL , 
    [SeasonId] UNIQUEIDENTIFIER NOT NULL , 
    CONSTRAINT [FK_UserSeasons_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]), 
    CONSTRAINT [FK_UserSeasons_Seasons] FOREIGN KEY ([SeasonId]) REFERENCES [Seasons]([SeasonId]), 
    CONSTRAINT [PK_UserSeasons] PRIMARY KEY ([UserId], [SeasonId])
)
