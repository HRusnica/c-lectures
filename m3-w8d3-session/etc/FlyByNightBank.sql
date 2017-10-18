CREATE TABLE customer_surveys
(
	survey_id			int					identity(1,1),
	customer_name		varchar(200)		null,
	state				varchar(100)		not null,
	customer_experience	int					not null,
	additional_feedback	varchar(max)		null,
	survey_submitted	datetime			not null,

	constraint pk_customer_surveys primary key(survey_id)
);

CREATE TABLE rates
(
	zip_code			varchar(10)			not null,
	savings_rate		decimal(10,2)		not null,
	checking_rate		decimal(10,2)		not null,
	cd_rate				decimal(10,2)		not null,
);

INSERT INTO rates (zip_code, savings_rate, checking_rate, cd_rate) VALUES ('44212', 0.21, 0.31, 0.41);
INSERT INTO rates (zip_code, savings_rate, checking_rate, cd_rate) VALUES ('44123', 1.21, 1.31, 1.41);
INSERT INTO rates (zip_code, savings_rate, checking_rate, cd_rate) VALUES ('12345', 0.01, 0.01, 0.01);
INSERT INTO rates (zip_code, savings_rate, checking_rate, cd_rate) VALUES ('11111', 11.11, 11.21, 11.41);
INSERT INTO rates (zip_code, savings_rate, checking_rate, cd_rate) VALUES ('22222', 2.21, 2.31, 2.41);

create table loan_applications
(
	application_id		int				identity(1,1),
	first_name			varchar(200)	not null,
	last_name			varchar(200)	not null,
	logon_username		varchar(100)	not null,

	home_address		varchar(200)	not null,
	home_city			varchar(200)	not null,
	home_state			varchar(100)	not null,
	home_postalCode		varchar(10)		not null,
	home_phone			varchar(10)		not null,

	job_title			varchar(100)	null,
	work_address		varchar(200)	null,
	work_city			varchar(200)	null,
	work_state			varchar(100)	null,
	work_postalCode		varchar(10)		null,
	work_phone			varchar(10)		null,

	net_worth			decimal			not null,
	reference1_name		varchar(100)	not null,
	reference1_phone	varchar(10)		not null,
	
	date_submitted		datetime		not null,


	constraint pk_loan_applications primary key(application_id)
);