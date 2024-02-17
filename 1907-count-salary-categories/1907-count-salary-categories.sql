/* Write your T-SQL query statement below */
select category='Low Salary', count(*) as accounts_count
from accounts
where income < 20000
union 
select category='Average Salary', count(*) as accounts_count
from accounts
where income between 20000 and 50000
union 
select category='High Salary', count(*) as accounts_count
from accounts
where income > 50000