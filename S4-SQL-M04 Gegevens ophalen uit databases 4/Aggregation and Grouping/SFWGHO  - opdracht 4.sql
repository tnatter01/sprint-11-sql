SELECT tblContinent.ContinentName AS Continent,
tblCountry.CountryName AS Country,
COUNT(tblEvent.EventID) AS [Number of events]

FROM tblContinent
INNER JOIN tblCountry ON tblCountry.ContinentID = tblContinent.ContinentID
INNER JOIN tblEvent ON tblEvent.CountryID = tblCountry.CountryID
WHERE ContinentName NOT IN ('Europe')
GROUP BY tblContinent.ContinentName, tblCountry.CountryName
HAVING COUNT(tblEvent.EventID) > 5
ORDER BY COUNT(tblEvent.EventID)
