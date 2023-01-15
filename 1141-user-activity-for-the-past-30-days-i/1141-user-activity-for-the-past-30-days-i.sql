/* Write your T-SQL query statement below */
select activity_date as day, count( distinct user_id) as active_users from Activity
where  DATEDIFF(day, activity_date,'2019-07-27') between 0 and 29
group by  activity_date