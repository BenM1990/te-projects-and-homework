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
BEGIN TRANSACTION
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

CREATE TABLE genre (
genre_id INT IDENTITY (1,1) PRIMARY KEY,
genre_name NVARCHAR(50) NOT NULL
);

SET IDENTITY_INSERT genre ON; -- so I can insert primary key value
INSERT INTO genre (genre_id, genre_name) VALUES (28, 'Action');
INSERT INTO genre (genre_id, genre_name) VALUES (12, 'Adventure');
INSERT INTO genre (genre_id, genre_name) VALUES (16, 'Animation');
INSERT INTO genre (genre_id, genre_name) VALUES (35, 'Comedy');
INSERT INTO genre (genre_id, genre_name) VALUES (80, 'Crime');
INSERT INTO genre (genre_id, genre_name) VALUES (99, 'Documentary');
INSERT INTO genre (genre_id, genre_name) VALUES (18, 'Drama');
INSERT INTO genre (genre_id, genre_name) VALUES (10751, 'Family');
INSERT INTO genre (genre_id, genre_name) VALUES (14, 'Fantasy');
INSERT INTO genre (genre_id, genre_name) VALUES (36, 'History');
INSERT INTO genre (genre_id, genre_name) VALUES (27, 'Horror');
INSERT INTO genre (genre_id, genre_name) VALUES (10402, 'Music');
INSERT INTO genre (genre_id, genre_name) VALUES (9648, 'Mystery');
INSERT INTO genre (genre_id, genre_name) VALUES (10749, 'Romance');
INSERT INTO genre (genre_id, genre_name) VALUES (878, 'Science Fiction');
INSERT INTO genre (genre_id, genre_name) VALUES (10770, 'TV Movie');
INSERT INTO genre (genre_id, genre_name) VALUES (53, 'Thriller');
INSERT INTO genre (genre_id, genre_name) VALUES (10752, 'War');
INSERT INTO genre (genre_id, genre_name) VALUES (37, 'Western');
SET IDENTITY_INSERT genre OFF;

CREATE TABLE [movie] (
    movie_id       INT            NOT NULL IDENTITY (1,1) PRIMARY KEY,
    title          NVARCHAR (200) NOT NULL,
    overview       NVARCHAR (MAX) NULL,
    tagline        NVARCHAR (400) NULL,
    poster_path    VARCHAR (200)  NULL,
    home_page      VARCHAR (200)  NULL,
    release_date   DATE           NULL,
    length_minutes INT            NOT NULL,
);


SET IDENTITY_INSERT movie ON;

INSERT INTO final_capstone.dbo.movie( movie_id,title,overview,tagline,poster_path,home_page,release_date,length_minutes)
SELECT  movie_id,title,overview,tagline,poster_path,home_page,release_date,length_minutes from MovieDB.dbo.movie

SET IDENTITY_INSERT movie OFF;

CREATE TABLE movie_genre (
    movie_id INT NOT NULL,
    genre_id INT NOT NULL,
	CONSTRAINT [PK_movie_genre] PRIMARY KEY (movie_id, genre_id),
    CONSTRAINT [FK_movie_genre_movie] FOREIGN KEY (movie_id) REFERENCES [movie] (movie_id),
    CONSTRAINT [FK_movie_genre_genre] FOREIGN KEY (genre_id) REFERENCES [genre] (genre_id)
);

INSERT INTO final_capstone.dbo.movie_genre( movie_id,genre_id)
SELECT  movie_id,genre_id from MovieDB.dbo.movie_genre WHERE genre_id IN (SELECT genre_id FROM final_capstone.dbo.genre)


 
CREATE TABLE user_profile (
profile_id INT IDENTITY PRIMARY KEY NOT NULL,
about_me VARCHAR(100) NOT NULL,
user_id INT NOT NULL

CONSTRAINT  FK_user_profile_User FOREIGN KEY (user_id) REFERENCES users(user_id) ,
);


CREATE TABLE user_movies (
Id INT NOT NULL  IDENTITY (1,1) PRIMARY KEY,
seen_movies INT ,
favorite_movies BIT ,
user_id INT  NOT NULL 

CONSTRAINT fk_user_movies_users_user_profile FOREIGN KEY (user_id) REFERENCES users(user_id),
CONSTRAINT fk_user_movies_movie FOREIGN KEY (seen_movies) REFERENCES movie(movie_id)
);

CREATE TABLE user_favorite_genres (
genre_id INT NOT NULL,
user_id INT NOT NULL
CONSTRAINT fk_user_favorite_genres_genre FOREIGN KEY (genre_id) REFERENCES genre(genre_id)
);


COMMIT;



 