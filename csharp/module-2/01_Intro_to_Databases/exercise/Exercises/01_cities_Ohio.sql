-- 1. The name and population of all cities in Ohio (OH) (6 rows)
--SELECT * FROM city;
SELECT city_name, population FROM CITY WHERE state_abbreviation = 'OH';
