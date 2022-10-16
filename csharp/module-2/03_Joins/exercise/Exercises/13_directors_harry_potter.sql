-- 13. The directors of the movies in the "Harry Potter Collection", sorted alphabetically.
-- (4 rows)

--select * from movie;
--select * from collection;
--select * from movie_actor;

SELECT DISTINCT person_name FROM movie
JOIN collection ON collection.collection_id = movie.collection_id
JOIN person ON person.person_id = movie.director_id
WHERE collection.collection_id = '1241'
ORDER BY person_name;
