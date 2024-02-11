select query_name, Round(AVG((rating+0.00)/position),2)as quality ,
Round(AVG(case when rating <3 then 1.00 else 0.00 end)*100,2)as poor_query_percentage
from queries
where query_name is not null
group by query_name