/* Write your T-SQL query statement below */
SELECT event_day day, emp_id, sum(out_time-in_time) total_time FROM Employees GROUP BY event_day,emp_id;