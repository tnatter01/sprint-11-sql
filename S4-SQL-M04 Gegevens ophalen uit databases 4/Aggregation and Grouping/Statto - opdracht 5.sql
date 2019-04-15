SELECT 
tblAuthor.AuthorName,
tblDoctor.DoctorName,
COUNT(tblAuthor.AuthorName) AS [Episodes]
FROM tblEpisode
INNER JOIN tblAuthor ON tblAuthor.AuthorId = tblEpisode.AuthorId
INNER JOIN tblDoctor ON tblDoctor.DoctorId = tblEpisode.DoctorId
GROUP BY tblAuthor.AuthorName, tblDoctor.DoctorName
HAVING COUNT(tblAuthor.AuthorName) > 5
ORDER BY COUNT(tblAuthor.AuthorName) DESC;