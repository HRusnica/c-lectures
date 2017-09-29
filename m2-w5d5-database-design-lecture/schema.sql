--DROP TABLE IF EXISTS purchases; FOR SQL SERVER 2016
--IF OBJECT_ID('dbo.purchases', 'U') IS NOT NULL DROP TABLE dbo.purchases; FOR SQL SERVER 2014

--DROP TABLE purchases;
--DROP TABLE art;
--DROP TABLE artist;
--DROP TABLE customers;


CREATE TABLE customers
(
	id				int			primary key		identity(1, 1),
	first_name		varchar(50)	not null,
	last_name		varchar(50)	not null,
	street_address1	varchar(50)	not null,
	city			varchar(50)	not null,
	state			varchar(50) not null,
	zipcode			varchar(5)	not null,	
	phone			varchar(14) not null,
);

CREATE TABLE artists
(
	id				int			primary key		identity(1,1),
	first_name		varchar(50)	not null,
	last_name		varchar(50)	null,
);

CREATE TABLE art
(
	id				int			identity(1,1),
	name			varchar(64)	not null,
	value			money		not null,
	artist_id		int			not null,

	constraint pk_art primary key (id),
	constraint fk_art_artist foreign key (artist_id) references artists(id),
	constraint uq_name_artist_id unique(name, artist_id)
);

CREATE TABLE purchases
(
	id				int			identity(1,1),
	customer_id		int			not null,
	art_id			int			not null,
	purchase_date	date		not null,
	purchase_price	money		not null,

	constraint pk_purchases primary key (id),
	constraint fk_purchases_customer foreign key (customer_id) references customers(id),
	constraint fk_purchases_art foreign key (art_id) references art(id),
	constraint uq_purchases unique (customer_id, art_id, purchase_date)
);
