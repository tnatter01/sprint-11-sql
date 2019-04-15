SELECT
tblEvent.EventName,
tblEvent.EventDate,
tblCategory.CategoryName
FROM
tblEvent
full OUTER JOIN tblCategory ON
tblEvent.CategoryID = tblCategory.CategoryID
WHERE CategoryName LIKE 'Old' OR CategoryName LIKE 'Alien Life'

