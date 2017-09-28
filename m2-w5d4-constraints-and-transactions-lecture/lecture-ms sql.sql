
SELECT * FROM INFORMATION_SCHEMA.COLUMNS;
SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS;
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS;
SELECT * FROM INFORMATION_SCHEMA.TABLES;




-- Subqueries
-- What if we wanted to get the name of the smallest country (by surface area)
-- how would we do that??
SELECT MIN(country.surfacearea) FROM country;
SELECT country.name FROM country WHERE country.surfacearea = 0.4;

SELECT country.name 
FROM country
WHERE country.surfacearea IN (SELECT MIN(country.surfacearea) FROM country);

SELECT TOP 1 country.name
FROM country
ORDER BY country.surfacearea


-- GET ALL LANGUAGES SPOKEN IN NORTH AMERICA
SELECT DISTINCT(countrylanguage.language)
FROM countrylanguage
JOIN country ON country.code = countrylanguage.countrycode
WHERE country.continent = 'North America';

SELECT DISTINCT(countrylanguage.language)
FROM countrylanguage
WHERE countrylanguage.countrycode IN (SELECT country.code FROM country WHERE country.continent = 'North America');


DECLARE @minSurfaceArea REAL;

SET @minSurfaceArea = (SELECT MIN(country.surfaceArea) FROM country);

SELECT country.name FROM country WHERE country.surfacearea = @minSurfaceArea;


-- Constraints


-- INSERT DATA
-- Let's add Klingon to the languages in the database.
--  Don't have a country code handy, and not sure about whether its an offical language anywhere, or the percentage of people who speak, but I want to get it into the database before I forget.
INSERT INTO countrylanguage  (countrycode, language) VALUES ('USA', 'Klingon');





-- That wasn't very friendly.
-- But I really want to get the record into the table, so I'll use a made up countrycode, 
-- and guess that its likely not an official language anywhere, and the percentage is near enough to zero, that its ok to specify that.
INSERT INTO countrylanguage (countrycode, language, percentage, isofficial) VALUES
	('ZZZ', 'Klingon', 100, 1);




-- Referential integrity requires that foreign keys point to valid primary keys. There is no country with a code of XQR in the database
-- Since Star Trek is an American TV show, let's set the countrylanguage.countrycode to 'USA', and hope it all works out.
INSERT INTO countrylanguage (countrycode, language, percentage, isofficial) VALUES
	('USA', 'Klingon', 100, 1);

-- let's confirm
SELECT countrylanguage.language from countrylanguage where countrylanguage.countrycode = 'USA';


-- Add the exciting new language, Klinglish.
INSERT INTO countrylanguage (countrycode, language, percentage, isofficial) VALUES
	('USA', 'Klinglish', 100, 1);


-- You can also rearrange the column names in the list, you just need to make sure the values match.
INSERT INTO countrylanguage(isofficial, percentage, countrycode, language)
VALUES (1, 50, 'USA', 'Englon');


-- Lets add a new city
SELECT MAX(id) FROM city;

INSERT INTO city ( name, countrycode, district, population) 
VALUES ('Kent', 'USA', 'Ohio', 4);
SELECT @@IDENTITY; -- GETS THE MOST RECENT GENERATED IDENTITY VALUE


-- DELETE
-- Let's delete all the Klingon, Klingish, and Englon rows we just added, starting with Englon.
DELETE FROM countrylanguage
WHERE countrylanguage.language = 'Klingon';

-- Then a simple select to confirm the deletion
DELETE FROM country
WHERE country.code = 'USA';


-- The WHERE clause can have other conditions besides equals. 
 -- We can could do `language='Klingon' or language='Klinglish'`. 
 -- We might even do something daring, `'language LIKE 'Kling%'`, and remove the rows with a wildcard LIKE.  
 -- BETWEEN n AND n+1` is also a really handy technique for deleting rows within a range of values, such numeric keys.

 

-- The last deletion exercise demonstrates referential integrity.
-- Confirm the county.captial for USA is Washington.


-- Remember, country.capital is a foreign key pointing to city.id.  Attempting to delete Washington from the city table using its id will violate referential integrity, and the deletion will not be allowed.




-- UPDATE
-- Let's start by adding back Klingon.
INSERT INTO countrylanguage (countrycode, language, percentage, isofficial)
VALUES ('USA', 'Klingon', 100, 1);


-- And just in time, because Klingon is now an official language in the US, and is spoken by 2 percent of the population.
UPDATE countrylanguage
SET percentage = 2, isofficial = 0
WHERE language = 'Klingon' AND countrycode = 'USA';

select * From countrylanguage where countrylanguage.language = 'Klingon';


-- TRANSACTIONS
-- Let's wrap updating the Klingon row in a trasaction. Begin by noting the current values for isofficial and percentage.
BEGIN TRANSACTION;

UPDATE countrylanguage
SET percentage = 20
WHERE language = 'Klingon' AND countrycode = 'USA';

select * From countrylanguage where countrylanguage.language = 'Klingon';


ROLLBACK TRANSACTION;



-- Now start the transaction, change isofficial and percentage, and then commit.

-- Confirm the commited transaction took place.


-- Repeat with new values for isoficial and percentage, and this time rollback the tranaction.



-- Finally, confirm that the changes were not committed, but were rolled back.
