CREATE TABLE [dbo].[TeamMovies]
(
	[TeamId] UNIQUEIDENTIFIER NOT NULL , 
    [MovieId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [PK_TeamMovies] PRIMARY KEY ([TeamId], [MovieId]), 
    CONSTRAINT [FK_TeamMovies_Teams] FOREIGN KEY ([TeamId]) REFERENCES [Teams]([TeamId]), 
    CONSTRAINT [FK_TeamMovies_Movies] FOREIGN KEY ([MovieId]) REFERENCES [Movies]([MovieId])
)
