SELECT 
	artists.ArtistId, 
	albums.albumId
FROM artists
LEFT JOIN albums 
ON albums.artistid = artists.artistid
ORDER BY albumid;