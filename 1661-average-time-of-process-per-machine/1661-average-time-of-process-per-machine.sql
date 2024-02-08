/* Write your T-SQL query statement below */
select   s.machine_id,round(avg(s.processing_time),3) as processing_time from
(SELECT 
    a.machine_id,
    ( a.timestamp- b.timestamp) AS processing_time
FROM 
    Activity AS a
JOIN 
    Activity AS b ON a.machine_id = b.machine_id 
                  AND a.process_id = b.process_id 
                  AND a.activity_type = 'end'
                  AND b.activity_type = 'start') as s
group by s.machine_id