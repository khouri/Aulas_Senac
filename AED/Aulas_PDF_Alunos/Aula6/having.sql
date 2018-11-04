SELECT 
	albumid, 
	COUNT(trackid)
FROM tracks
GROUP BY albumid
HAVING albumid = 1;