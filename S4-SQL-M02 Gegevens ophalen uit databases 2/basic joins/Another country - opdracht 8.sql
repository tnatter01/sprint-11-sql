SELECT tblCountry.CountryName, tblEvent.EventName
FROM     tblCountry INNER JOIN
                  tblEvent ON tblCountry.CountryID = tblEvent.CountryID
WHERE  (tblEvent.EventName IS NULL)