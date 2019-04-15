USE WorldEvents
GO

SELECT 
CASE 
WHEN DATEPART(YY,tblEvent.EventDate) like '18%' THEN '19th Century'
WHEN DATEPART(YY,tblEvent.EventDate) like '17%' THEN '18th Century'
WHEN DATEPART(YY,tblEvent.EventDate) like '19%' THEN '20th Century'
WHEN DATEPART(YY,tblEvent.EventDate) like '20%' THEN '21st Century'
END AS Century,COUNT(tblEvent.EventName) AS NumberOfEvents
FROM tblEvent
GROUP BY CUBE(CASE 
WHEN DATEPART(YY,tblEvent.EventDate) like '18%' THEN '19th Century'
WHEN DATEPART(YY,tblEvent.EventDate) like '17%' THEN '18th Century'
WHEN DATEPART(YY,tblEvent.EventDate) like '19%' THEN '20th Century'
WHEN DATEPART(YY,tblEvent.EventDate) like '20%' THEN '21st Century'
END)
ORDER BY NumberOfEvents DESC