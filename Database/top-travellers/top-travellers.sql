SELECT U.[name], ISNULL(SUM(R.[distance]),0) AS travelled_distance
FROM [dbo].[Users] AS U
LEFT JOIN [dbo].[Rides] AS R ON U.[id] = R.[user_id]
GROUP BY U.[name]
ORDER BY SUM(R.[distance]) DESC, U.[name] ASC;
