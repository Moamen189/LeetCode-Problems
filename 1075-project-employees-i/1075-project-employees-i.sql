/* Write your T-SQL query statement below */
   select  p.project_id  ,ROUND(AVG(e.experience_years * 1.0), 2)  as average_years 
    from Employee e inner join Project p 
    on e.employee_id = p.employee_id 
    WHERE e.experience_years IS NOT NULL
    group by p.project_id  