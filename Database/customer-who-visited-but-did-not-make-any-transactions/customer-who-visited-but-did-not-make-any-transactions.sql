SELECT V.[customer_id], COUNT([customer_id]) AS count_no_trans 
FROM [dbo].[Visits] AS V
LEFT OUTER JOIN [dbo].[Transactions] AS T ON V.[visit_id] = T.[visit_id]
WHERE T.[visit_id] IS NULL
GROUP BY [customer_id]
ORDER BY COUNT([customer_id]) DESC, V.[customer_id];
