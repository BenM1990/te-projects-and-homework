-- 17. The titles and taglines of movies that are in the "Family" genre that Samuel L. Jackson has acted in.
-- Order the results alphabetically by movie title.
-- (4 rows)

SELECT title, tagline FROM movie

WHERE genre_name = 'Family' AND person_name = 'Samuel L. Jackson'
ORDER BY title;