/* Write your T-SQL query statement below */
select top 1 x.person_name 
from(
    select *, 
    sum(weight) over(order by turn rows between unbounded preceding and current row) as Total_Weight
    from Queue
    ) x
where x.Total_Weight <=1000
order by x.Total_Weight desc