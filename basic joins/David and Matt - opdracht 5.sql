SELECT tblDoctor.DoctorName, tblEpisode.Title, tblEpisode.EpisodeDate
FROM     tblDoctor INNER JOIN
                  tblEpisode ON tblDoctor.DoctorId = tblEpisode.DoctorId
WHERE EpisodeDate BETWEEN '2010/01/01' AND '2010/12/31';