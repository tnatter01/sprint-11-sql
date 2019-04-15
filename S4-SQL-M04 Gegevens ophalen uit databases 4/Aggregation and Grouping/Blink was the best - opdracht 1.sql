SELECT tblAuthor.AuthorName,
COUNT(tblAuthor.AuthorName) AS Episodes,
MIN(tblEpisode.EpisodeDate) AS 'Earliest date',
MAX(tblEpisode.EpisodeDate) AS 'Latest date'


FROM tblAuthor
INNER JOIN tblEpisode ON tblAuthor.AuthorId = tblEpisode.AuthorId
GROUP BY tblAuthor.AuthorName