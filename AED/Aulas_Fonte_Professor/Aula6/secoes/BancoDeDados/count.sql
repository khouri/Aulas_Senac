SELECT 
	albumid, 
	COUNT(trackid)
FROM tracks
GROUP BY albumid
ORDER BY COUNT(trackid) DESC;