/* Write your T-SQL query statement below */
SELECT T.product_id , COALESCE( P.new_price , 10 ) AS price 
FROM (
    SELECT product_id , MAX(
        CASE WHEN 
          CAST( change_date  AS DATE) <= 
          CAST('2019-08-16'  AS DATE )
        THEN change_date END
    ) AS dt
    FROM Products
    GROUP BY product_id
) AS T 
LEFT JOIN Products P
ON P.product_id = T.product_id AND T.dt = P.change_date;