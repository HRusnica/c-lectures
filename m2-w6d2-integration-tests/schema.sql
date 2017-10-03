--DROP TABLE ingredients;
--DROP TABLE recipe;

CREATE TABLE recipe
(
	id				int				primary key identity(1,1),
	name			varchar(254)	not null,
	instructions	varchar(max)	not null,
	description			varchar(254)	not null,
	cookTimeInMinutes	int				not null
);

CREATE TABLE ingredients
(
	id				int				primary key identity(1,1),
	name			varchar(254)	not null,
	quantity		varchar(254)	not null,
	recipeId		int				not null,

	CONSTRAINT fk_ingredients_recipe FOREIGN KEY (recipeId) REFERENCES recipe(id)
);




INSERT INTO recipe VALUES ('Grilled Cheese', 'Butter some bread, start the skillet, put cheese between the bread on the skillet. Whatever you do, DO NOT SMASH!', 'Bread and melted cheese', 15);

INSERT INTO ingredients VALUES ('Bread', '2 slices', 1);
INSERT INTO ingredients VALUES ('Cheese', '4 lbs', 1);
INSERT INTO ingredients VALUES ('Butter', '1 stick', 1);

INSERT INTO recipe VALUES ('Peanut Butter & Jelly', 'Dip the bread in some peanut butter and jelly', 'A classic staple', 15);
INSERT INTO ingredients VALUES ('Peanut Butter', '1 cup', 2);
INSERT INTO ingredients VALUES ('Jelly', '1 cup', 2);
INSERT INTO ingredients VALUES ('Bread', '2 slices', 2);