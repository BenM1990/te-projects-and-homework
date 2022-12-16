USE master
GO

--drop database if it exists
IF DB_ID('final_capstone') IS NOT NULL
BEGIN
	ALTER DATABASE final_capstone SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE final_capstone;
END

CREATE DATABASE final_capstone
GO

USE final_capstone
GO

--create tables
CREATE TABLE users (
	user_id int IDENTITY(1,1) NOT NULL,
	username varchar(50) NOT NULL,
	password_hash varchar(200) NOT NULL,
	salt varchar(200) NOT NULL,
	user_role varchar(50) NOT NULL
	CONSTRAINT PK_user PRIMARY KEY (user_id)
)

--populate default data
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('user','Jg45HuwT7PZkfuKTz6IB90CtWY4=','LHxP4Xh7bN0=','user');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('admin','YhyGVQ+Ch69n4JMBncM4lNF/i9s=', 'Ar/aB2thQTI=','admin');

GO


BEGIN TRANSACTION;





-- Movie table data
SET IDENTITY_INSERT movie ON;
INSERT INTO movie (movie_id, title, overview, tagline, poster_path, home_page, release_date, length_minutes, director_id, collection_id) VALUES (155, N'The Dark Knight', N'Batman raises the stakes in his war on crime. With the help of Lt. Jim Gordon and District Attorney Harvey Dent, Batman sets out to dismantle the remaining criminal organizations that plague the streets. The partnership proves to be effective, but they soon find themselves prey to a reign of chaos unleashed by a rising criminal mastermind known to the terrified citizens of Gotham as the Joker.', N'Why So Serious?', N'https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg', N'https://www.warnerbros.com/movies/dark-knight/', '7/16/2008 12:00:00 AM', 152, '525', '263');
--

CREATE TABLE [movie_genre] (
    movie_id INT NOT NULL,
    genre_id INT NOT NULL,
	CONSTRAINT [PK_movie_genre] PRIMARY KEY (movie_id, genre_id),
    CONSTRAINT [FK_movie_genre_movie] FOREIGN KEY (movie_id) REFERENCES [movie] (movie_id),
    CONSTRAINT [FK_movie_genre_genre] FOREIGN KEY (genre_id) REFERENCES [genre] (genre_id)
);









COMMIT;