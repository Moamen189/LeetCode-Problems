/* Write your T-SQL query statement below */
select viewer_id as id
from Views
where author_id=viewer_id
group by viewer_id


order by viewer_id ASC
