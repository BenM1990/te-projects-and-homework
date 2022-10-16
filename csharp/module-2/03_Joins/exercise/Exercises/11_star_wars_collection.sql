-- 11. The titles of the movies in the "Star Wars Collection" ordered by release date, most recent first. 
-- (9 rows)

--SELECT * from collection;

SELECT title FROM movie
JOIN collection ON collection.collection_id = movie.collection_id
WHERE collection.collection_id = '10'
ORDER BY movie.release_date DESC;