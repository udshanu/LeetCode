SELECT [sell_date], COUNT(DISTINCT [product]) AS num_sold, STUFF((SELECT DISTINCT ',' + [product]
          FROM [dbo].[Activities] AS A2
          WHERE A1.sell_date = A2.sell_date
          FOR XML PATH('')), 1, 1, '') products
FROM [dbo].[Activities] AS A1
GROUP BY [sell_date] 
ORDER BY [sell_date];
