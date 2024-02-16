/* Write your T-SQL query statement below */
with cte as ( select visited_on, sum(amount) as amount
              from customer
              group by visited_on
            ),
    cte_out as( select *,
                row_number() over(order by visited_on) as rwn,
                sum(amount) over(order by visited_on rows BETWEEN 6 PRECEDING AND CURRENT ROW) as sum,
                avg(cast(amount as float)) over(order by visited_on rows BETWEEN 6 PRECEDING AND CURRENT ROW) as average
                from cte)

select visited_on,sum as amount,round(average,2) as average_amount
from cte_out 
where rwn>6