SELECT ContinentID, ContinentName, Summary, ISNULL(Summary, 'No Summary') AS 'Using ISNULL', COALESCE (Summary, 'No Summary') AS 'Using COALESCE', CASE WHEN summary IS NULL 
                  THEN 'No Summary' ELSE summary END AS 'Using CASE'
FROM     tblContinent;