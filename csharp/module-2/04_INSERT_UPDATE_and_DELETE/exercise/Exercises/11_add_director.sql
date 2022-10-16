-- 11. Hollywood is remaking the classic movie "The Blob" and doesn't have a director yet. Add yourself to the person table, and assign yourself as the director of "The Blob" 
--(the movie is already in the movie table). (1 record each)

--select * from person;

BEGIN TRANSACTION;

INSERT INTO person (person_name, birthday, deathday, biography, profile_path, home_page)
VALUES ('Ben Measor', '1990-04-11', NULL, '6 Time Academy Award Nominee', NULL, NULL)

UPDATE movie SET director_id = (SELECT person_id FROM person WHERE person_name = 'Ben Measor')
WHERE title = 'The Blob'

COMMIT;