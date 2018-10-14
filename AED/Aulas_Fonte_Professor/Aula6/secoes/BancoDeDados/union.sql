SELECT firstname, lastname
FROM employees
UNION
SELECT firstname, lastname
FROM customers
ORDER BY firstname, lastname;