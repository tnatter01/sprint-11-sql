SELECT EventName, EventDate,
FORMAT(EventDate, 'dddd') AS 'Day of week',
FORMAT(EventDate, 'dd') AS 'Day number'
FROM tblEvent;
