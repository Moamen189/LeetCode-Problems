/* Write your T-SQL query statement below */
select round(count(distinct Sub.player_id)*1.0/(select count(distinct player_id) from activity),2) as fraction from (select player_id, datediff(day, event_date, min(event_date) over(partition by player_id)) as t from Activity) Sub where Sub.t = -1