/* Write your T-SQL query statement below */
SELECT stock_name, ((SELECT sum(price) FROM Stocks s1 WHERE operation='Sell' AND s1.stock_name=s.stock_name)-(SELECT sum(price) FROM Stocks s2 WHERE operation='Buy' AND s2.stock_name=s.stock_name)) capital_gain_loss FROM Stocks s GROUP BY stock_name;