-- 7. The population of the state with the highest population. Name the column 'largest_state_population'.
-- Expected answer is around 39,500,000
-- (1 row)

--SELECT * FROM state;
SELECT TOP 1 population AS largest_state_population FROM state ORDER BY population DESC;