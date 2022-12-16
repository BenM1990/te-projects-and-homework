USE final_capstone;
GO
BEGIN TRANSACTION
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