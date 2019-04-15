SELECT 
COUNT(tblEvent.EventID) AS [Number of events],
MAX(EventDate) AS [Last date],
MIN(EventDate) AS [First date]
FROM tblEvent