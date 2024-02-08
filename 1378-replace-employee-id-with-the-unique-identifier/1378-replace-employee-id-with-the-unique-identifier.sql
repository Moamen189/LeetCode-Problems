/* Write your T-SQL query statement below */



select euni.unique_id,e.name
from employees e
left join
employeeuni euni
on e.id=euni.id