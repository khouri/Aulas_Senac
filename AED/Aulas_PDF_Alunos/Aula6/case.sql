SELECT 
	customerid, 
	firstname, 
	lastname, 
	CASE country WHEN "USA"
	THEN "Dosmetic"
	ELSE "Foreign"
	END CustomerGroup
FROM customers
ORDER BY LastName, FirstName;