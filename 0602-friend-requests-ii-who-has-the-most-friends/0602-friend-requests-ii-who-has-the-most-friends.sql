/* Write your T-SQL query statement below */
With CTE as(
    select requester_id, count(requester_id) as CountRequest from 
    (select requester_id from RequestAccepted Union all select accepter_id from RequestAccepted) S Group by requester_id
)

select requester_id as id, CountRequest as num
from CTE
where CountRequest = (select max(CountRequest) from CTE)