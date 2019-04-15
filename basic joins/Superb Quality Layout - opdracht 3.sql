SELECT tblCountry.CountryName AS [Country], tblEvent.EventName AS [What happenend], tblEvent.EventDate AS [When happened]
FROM     tblEvent INNER JOIN
                  tblCountry ON tblEvent.CountryID = tblCountry.CountryID
ORDER BY Country