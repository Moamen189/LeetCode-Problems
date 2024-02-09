/* Write your T-SQL query statement below */
select name
from Employee e 
inner join 
(select managerId , Count(managerId ) as mount from Employee
 group by managerId Having Count(managerId) > 4) m on e.id = m.managerId 