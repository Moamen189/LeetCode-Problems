/* Write your T-SQL query statement below */

SELECT Employee.name, Bonus.bonus
FROM Employee
Left JOIN Bonus ON Employee.empId = Bonus.empId where Bonus <1000 Or Bonus is null;