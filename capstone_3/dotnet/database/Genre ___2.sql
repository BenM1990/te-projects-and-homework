USE final_capstone
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