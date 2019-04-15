select [EpisodeEnemyId], e.[EnemyName],[EpisodeNumber],[AuthorName]
from [dbo].[tblEpisodeEnemy] as epe
inner join [dbo].[tblEnemy] as e
on epe.EnemyId= e.EnemyId
inner join [dbo].[tblEpisode] as e1
on epe.EpisodeId = e1.EpisodeId
inner join [dbo].[tblAuthor] as a
on e1.AuthorId= a.AuthorId
where EnemyName like '%Daleks%' 