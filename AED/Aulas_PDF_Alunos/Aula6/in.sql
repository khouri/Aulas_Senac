SELECT 
	trackid, 
	name, 
	mediatypeid
FROM tracks
WHERE mediatypeid IN (1, 2)
ORDER BY name ASC;