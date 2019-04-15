SELECT 
EventName, 
EventDate,
CONVERT(CHAR(10) ,EventDate, 101) AS UsingConvert,
CONVERT(CHAR(10) ,EventDate, 101) AS UsingFormat

FROM tblEvent

WHERE EventDate BETWEEN '1997-01-01' AND '2019-01-01'

ORDER BY EventDate
asc;