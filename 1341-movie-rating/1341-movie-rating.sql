/* Write your T-SQL query statement below */
SELECT results
FROM (
    SELECT TOP 1 u.name as results
    FROM MovieRating m
    JOIN Users u ON m.user_id = u.user_id
    GROUP BY m.user_id, u.name
    ORDER BY COUNT(*) DESC, u.name ASC
) AS userWithMaxReviews

UNION ALL

SELECT results
FROM (
    SELECT TOP 1 m.title as results
    FROM MovieRating mr
    INNER JOIN movies m ON mr.movie_id = m.movie_id
    WHERE MONTH(mr.created_at) = 2 AND YEAR(mr.created_at) = 2020
    GROUP BY mr.movie_id, m.title
    ORDER BY AVG(mr.rating*1.00) DESC, m.title ASC
) AS movieWithHighestRatingInFeb;