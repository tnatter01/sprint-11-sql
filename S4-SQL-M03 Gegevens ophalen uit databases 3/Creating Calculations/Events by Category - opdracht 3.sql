SELECT tblEvent.EventName + ' (Category ' + CAST(tblCategory.CategoryID AS varchar) + ')',tblEvent.EventDate
FROM tblEvent
INNER JOIN tblCountry ON tblCountry.CountryID = tblEvent.CountryID
INNER JOIN tblCategory ON tblCategory.CategoryID = tblEvent.CategoryID
WHERE tblCountry.CountryName = 'Ukraine';