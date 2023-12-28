/* Write your T-SQL query statement below */
select Day,round(sum(cancel)/count(*),2) [Cancellation Rate]
from
(select t.request_at Day,cast(case
                        when t.status in ('cancelled_by_driver','cancelled_by_client') then 1
                        else 0
                        end  as float) cancel
                        
from trips t
join users u1
on t.client_id=u1.users_id and u1.banned='No'
join users u2
on t.driver_id=u2.users_id and u2.banned='No'
where t.request_at between '2013-10-01' and '2013-10-03')a
group by Day