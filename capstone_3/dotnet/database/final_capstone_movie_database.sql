USE final_capstone;
GO

BEGIN TRANSACTION;

CREATE TABLE movie (
movie_id INT IDENTITY(1,1), 
title VARCHAR(200) NOT NULL,
overview VARCHAR(max) NOT NULL,
tagline VARCHAR(400),
poster_path VARCHAR (200),
home_page VARCHAR(200),
release_date DATE,
length_minutes INT NOT NULL

CONSTRAINT pk_movie PRIMARY KEY (movie_id),
);

--BEGIN TRANSACTION;

--CREATE TABLE movie (
--movie_id INT IDENTITY(1,1) NOT NULL, 
--title VARCHAR(200) NOT NULL,
--overview VARCHAR(max) NOT NULL,
--tagline VARCHAR(400),
--poster_path VARCHAR (200),
--home_page VARCHAR(200),
--release_date DATE,
--length_minutes INT

--CONSTRAINT pk_movie PRIMARY KEY (movie_id),
--);

--CREATE TABLE genre (

--genre_id INT IDENTITY (1,1),
--genre_name VARCHAR NOT NULL

--CONSTRAINT pk_genre_id PRIMARY KEY (genre_id)
--);


genre_id INT IDENTITY (1,1),
genre_name NVARCHAR(50) NOT NULL

--CONSTRAINT pk_user_favorite_genres PRIMARY KEY (genre_id, user_id),
--CONSTRAINT fk_user_favorite_genres_genre FOREIGN KEY (genre_id) REFERENCES genre(genre_id),
--CONSTRAINT fk_user_favorite_genres_users FOREIGN KEY (user_id) REFERENCES users(user_id)
--);

--CREATE TABLE user_profile (

--profile_id INT IDENTITY(1,1) NOT NULL,
--about_me VARCHAR(100),
--user_id INT NOT NULL

--CONSTRAINT pk_user_profile PRIMARY KEY (profile_id),
--CONSTRAINT fk_user_profile_users FOREIGN KEY (user_id) REFERENCES users(user_id)

--);

--CREATE TABLE user_movies (

user_movies_id INT IDENTITY (1,1), 
seen_movies INT NOT NULL,
favorite_movies BIT NOT NULL,
user_id INT NOT NULL

CONSTRAINT pk_user_movies PRIMARY KEY (user_movies_id),
CONSTRAINT fk_user_movies_users FOREIGN KEY (user_id) REFERENCES users(user_id),
CONSTRAINT fk_user_movies_users FOREIGN KEY (user_id) REFERENCES users(user_id),
CONSTRAINT fk_user_movies_movie FOREIGN KEY (seen_movies) REFERENCES movie(movie_id)
);


--CREATE TABLE movie_genre (

--movie_id INT NOT NULL,
--genre_id INT NOT NULL

--constraint pk_movie_genre PRIMARY KEY (movie_id, genre_id),
--CONSTRAINT fk_movie_genre_movie FOREIGN KEY (movie_id) REFERENCES movie(movie_id),
--CONSTRAINT fk_movie_genre_genre FOREIGN KEY (genre_id) REFERENCES genre(genre_id)
--);


--COMMIT;

SELECT * FROM users

