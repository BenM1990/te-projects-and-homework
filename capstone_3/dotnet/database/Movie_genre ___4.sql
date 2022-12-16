USE final_capstone
GO
CREATE TABLE movie_genre (
    movie_id INT NOT NULL,
    genre_id INT NOT NULL,
	CONSTRAINT [PK_movie_genre] PRIMARY KEY (movie_id, genre_id),
    CONSTRAINT [FK_movie_genre_movie] FOREIGN KEY (movie_id) REFERENCES [movie] (movie_id),
    CONSTRAINT [FK_movie_genre_genre] FOREIGN KEY (genre_id) REFERENCES [genre] (genre_id)
);

INSERT INTO final_capstone.dbo.movie_genre( movie_id,genre_id)
SELECT  movie_id,genre_id from MovieDB.dbo.movie_genre

 