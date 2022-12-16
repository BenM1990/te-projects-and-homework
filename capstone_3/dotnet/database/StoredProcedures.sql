 USE final_capstone
GO


CREATE PROCEDURE GetGenreNameById @id int
AS
SELECT genre_name 
FROM genre
WHERE genre_id = @id
GO



CREATE PROCEDURE GetMovieNameById @id int
AS
SELECT title 
FROM movie
WHERE movie_id = @id
GO



--EXEC GetGenreNameById @id = 28
