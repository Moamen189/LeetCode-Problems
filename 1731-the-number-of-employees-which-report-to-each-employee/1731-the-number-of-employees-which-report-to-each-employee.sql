/* Write your T-SQL query statement below */
select e.employee_id , e.name ,count(r.employee_id) as reports_count  ,round(avg(cast(r.age as float)),0) as average_age
from Employees e inner join Employees r
on e.employee_id = r.reports_to  
group by e.employee_id , e.name
order by e.employee_id 