CREATE TABLE [dbo].[UsersMovies]
(
	[UserId] UNIQUEIDENTIFIER NOT NULL , 
    [MovieId] UNIQUEIDENTIFIER NOT NULL , 
    CONSTRAINT [FK_UsersMovies_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]), 
    CONSTRAINT [FK_UsersMovies_Movies] FOREIGN KEY ([MovieId]) REFERENCES [Movies]([MovieId]), 
    CONSTRAINT [PK_UsersMovies] PRIMARY KEY ([UserId], [MovieId])
)
