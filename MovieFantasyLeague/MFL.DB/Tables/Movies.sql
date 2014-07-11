CREATE TABLE [dbo].[Movies]
(
	[MovieId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [DraftCost] INT NOT NULL, 
    [ReleaseDate] DATE NOT NULL, 
    [DomesticGross] MONEY NOT NULL, 
    [BoxOfficeMojoLink] NVARCHAR(500) NOT NULL, 
    [PosterLink] NVARCHAR(500) NOT NULL, 
    [SeasonId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_Movies_Seasons] FOREIGN KEY ([SeasonId]) REFERENCES [Seasons]([SeasonId])
)
