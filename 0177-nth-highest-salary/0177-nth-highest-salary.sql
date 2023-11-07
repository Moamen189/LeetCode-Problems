CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
   RETURN (
       
         select distinct b.salary from Employee b 
             where 
               ( select count( distinct a.salary  ) from Employee a
                     where 
                   a.salary > b.salary ) = @N - 1
   );
END