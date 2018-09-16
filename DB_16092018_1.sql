CREATE VIEW [dbo].[recentlyWatched] AS
	SELECT TOP 10 t.name, t.director, t.rating, t.watchingDate FROM [dbo].[Table] t
	ORDER BY t.watchingDate DESC;