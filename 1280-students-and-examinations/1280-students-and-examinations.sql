/* Write your T-SQL query statement below */
select s.student_id, s.student_name, s.subject_name ,count(e.subject_name) as attended_exams  from Examinations e right join (select * from Students CROSS JOIN Subjects) s 
on s.student_id=e.student_id and e.subject_name=s.subject_name group by s.student_id, s.student_name,s.subject_name order by s.student_id, s.subject_name ;