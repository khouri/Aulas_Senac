SELECT 
	trackid, 
	name, 
	title
FROM tracks
INNER JOIN albums 
ON albums.albumid = tracks.albumid;