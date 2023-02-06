/* Write your T-SQL query statement below */
With RankEarners AS (
    
    Select
        (
            Select d.name 
            From   Department d 
            Where  e.departmentId=d.id
    ) 'Department'
    ,   e.[name] 'Employee'
    ,   e.salary 'Salary'
    ,   Dense_Rank() Over(Partition By e.departmentID Order By Salary Desc) 'RankBySalary'
    ,   e.ID As 'EmpID'
	
        From Employee e
)

Select   Department, Employee, Salary
From     RankEarners
Where    RankBySalary <= 3
Order By EmpID