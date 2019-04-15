SELECT EventName, EventDate , DATEDIFF(Day,EventDate, 2000/06/29) AS [Days offset],ABS(DATEDIFF(Day,2000/06/29,EventDate)) AS [Days diffrences]
FROM tblEvent
ORDER BY [Days diffrences] asc;