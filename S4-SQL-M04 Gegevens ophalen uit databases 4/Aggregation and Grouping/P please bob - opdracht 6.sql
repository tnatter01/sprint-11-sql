SELECT YEAR(tblEpisode.EpisodeDate) AS 'Episode year',
tblEnemy.EnemyName,
COUNT(tblEpisodeEnemy.EpisodeEnemyId) AS 'Number of episodes'
FROM tblEpisode
INNER JOIN tblDoctor ON tblEpisode.DoctorId = tblDoctor.DoctorId
INNER JOIN tblEpisodeEnemy ON tblEpisode.EpisodeId = tblEpisodeEnemy.EpisodeId
INNER JOIN tblEnemy ON tblEnemy.EnemyId = tblEpisodeEnemy.EnemyId
WHERE tblDoctor.BirthDate < '1970'
GROUP BY tblEnemy.EnemyName, YEAR(tblEpisode.EpisodeDate)
HAVING COUNT(tblEpisodeEnemy.EpisodeEnemyId) != 1