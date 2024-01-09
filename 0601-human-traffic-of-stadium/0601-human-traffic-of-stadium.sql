/* Write your T-SQL query statement below */
WITH 
T1 AS (SELECT id,visit_date,people, SUM(CASE WHEN people>=100 THEN 0 ELSE 1 END)
OVER (ORDER BY id) AS c FROM Stadium),

T2 AS(SELECT c,COUNT(id) AS CO FROM T1 WHERE people>=100
GROUP BY c HAVING COUNT(id) >= 3)

SELECT id,visit_date,people FROM T1 
WHERE people>=100 AND c IN (SELECT c FROM T2)