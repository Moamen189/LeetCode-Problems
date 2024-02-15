/* Write your T-SQL query statement below */
WITH A AS(SELECT tiv_2016,
count(*) over (partition by lat, lon) as countlatlon,
count(*) over (partition by tiv_2015) as counttiv2015
from Insurance)
SELECT ROUND(SUM(tiv_2016),2) as tiv_2016 FROM A 
WHERE countlatlon = 1 and counttiv2015 >1