/****** Script for SelectTopNRows command from SSMS  ******/
SELECT  *  FROM user_profile;
SELECT  *  FROM user_favorite_genres;
SELECT  *  FROM user_movies;




DELETE  FROM user_profile; 
DELETE     FROM user_favorite_genres;
DELETE    FROM user_movies;

DELETE FROM user_movies WHERE user_id= 1;
DELETE FROM user_favorite_genres WHERE user_id= 1;
DELETE FROM user_profile WHERE user_id= 1;
