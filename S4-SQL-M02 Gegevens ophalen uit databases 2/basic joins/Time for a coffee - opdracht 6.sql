SELECT tblAuthor.AuthorName, tblEpisode.Title, tblDoctor.DoctorName, tblEnemy.EnemyName, LEN(CONCAT(tblAuthor.AuthorName, tblEpisode.Title, tblDoctor.DoctorName,tblEnemy.EnemyName))  AS Totallength
FROM tblAuthor
INNER JOIN tblEpisode ON tblAuthor.AuthorId = tblEpisode.AuthorId
INNER JOIN tblDoctor ON tblEpisode.DoctorId = tblDoctor.DoctorId
INNER JOIN tblEpisodeEnemy ON tblEpisode.EpisodeId = tblEpisodeEnemy.EpisodeId
INNER JOIN tblEnemy ON tblEpisodeEnemy.EnemyId = tblEnemy.EnemyId
where LEN(CONCAT(tblAuthor.AuthorName,tblEpisode.Title,tblDoctor.DoctorName,tblEnemy.EnemyName)) <40