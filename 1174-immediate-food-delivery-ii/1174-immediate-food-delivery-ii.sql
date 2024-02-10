/* Write your T-SQL query statement below */
SELECT ROUND(AVG(CASE WHEN order_date = customer_pref_delivery_date THEN 100.0
ELSE 0
END), 2) AS immediate_percentage
FROM (SELECT *,
      RANK() OVER (PARTITION BY customer_id ORDER BY order_date) AS rank
      FROM Delivery) AS data
WHERE rank = 1;