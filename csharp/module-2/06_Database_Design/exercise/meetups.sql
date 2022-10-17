USE MASTER;
GO

DROP DATABASE IF EXISTS meetups;

CREATE DATABASE meetups;
GO

USE meetups;
GO

BEGIN TRANSACTION;

CREATE TABLE member (
member_id INT IDENTITY (1,1), 
last_name VARCHAR (50) NOT NULL,
first_name VARCHAR (50) NOT NULL,
email VARCHAR (50) NOT NULL,
phone_number VARCHAR (20) NOT NULL,
date_of_birth DATE NOT NULL,
email_reminder BIT NOT NULL

CONSTRAINT pk_member PRIMARY KEY (member_id)
);

CREATE TABLE interest_group (
group_id INT IDENTITY (1,1),
name VARCHAR (50) NOT NULL,
total_members INT NOT NULL,
member_id INT,

CONSTRAINT pk_interest_group PRIMARY KEY (group_id),
CONSTRAINT fk_member FOREIGN KEY (member_id) REFERENCES member(member_id)
);

CREATE TABLE event (
event_id INT IDENTITY (1,1) NOT NULL,
name VARCHAR (50) NOT NULL,
description VARCHAR (500) NOT NULL,
start_date_time DATETIME NOT NULL,
duration_in_mintues INT NOT NULL,
group_id INT,
total_members INT,
member_id INT,

CONSTRAINT pk_event PRIMARY KEY (event_id),
CONSTRAINT fk_interest_group FOREIGN KEY (group_id) REFERENCES interest_group(group_id)
);

CREATE TABLE member_interest_group (
member_id INT,
group_id INT

CONSTRAINT pk_member_interest_group PRIMARY KEY (member_id, group_id), --composite primary key based on two columns
CONSTRAINT fk_member_interest_group FOREIGN KEY (member_id) REFERENCES member(member_id),
CONSTRAINT fk_interest_group_member FOREIGN KEY (group_id) REFERENCES interest_group(group_id)
);

CREATE TABLE member_event(
member_id INT,
event_id INT

CONSTRAINT pk_member_event PRIMARY KEY (member_id, event_id),
CONSTRAINT fk_member_event FOREIGN KEY (member_id) REFERENCES member(member_id),
CONSTRAINT fk_event_member FOREIGN KEY (event_id) REFERENCES event(event_id)
);

COMMIT;
GO

INSERT INTO member (last_name, first_name, email, phone_number, date_of_birth, email_reminder) VALUES
	('Glick', 'Jiminy', 'jiminyglick@gmail.com', '123-456-7890', '1969-04-11', 0),
	('Glick', 'Morgan', 'morganglick@gmail.com', '123-789-8800', '1990-05-04', 1),
	('Glick', 'Mason', 'masonglick@gmail.com', '440-321-6654', '1991-06-21', 1),
	('Glick', 'Matthew', 'matthewglick@gmail.com', '216-970-4433', '1993-07-21', 0),
	('Glick', 'Modine', 'modineglick@gmail.com', '800-555-5555', '1995-12-25', 1),
	('Glick', 'Dixie', 'dixieglick@gmail.com', '447-342-3484', '1965-02-24', 1),
	('Gyllenhaal', 'Jake', 'jakegyl@yahoo.com', '212-808-8877', '1980-12-19', 0),
	('Adams', 'Amy', 'amyadams@altavista.com', '333-333-0333', '1981-11-19', 0);

	
SELECT * FROM member;

INSERT INTO interest_group (name, total_members) VALUES
	('Glick Family', 6),
	('Hollywood', 2),
	('Gold', 3);

SELECT * FROM interest_group;

INSERT INTO event (name, description, start_date_time, duration_in_mintues, group_id, total_members, member_id) VALUES
	('The Roast of Jiminy Glick', 'Hollywood comes together for another roast, this years guest is Jiminy Glick', '2022-12-01 12:00:00', 60, (SELECT group_id FROM interest_group WHERE name = 'Glick Family'), 200, (SELECT member_id FROM member WHERE last_name = 'Gyllenhaal')),
	('Brunch', 'A brunch meeting for creative minds', '2022-04-11 12:30:00', 45, (SELECT group_id FROM interest_group WHERE name = 'Hollywood'), 50, (SELECT member_id FROM member WHERE first_name = 'Jiminy')),
	('Oscars', 'The annual Academy Awards in Los Angeles', '2023-03-16', 120, (SELECT group_id FROM interest_group WHERE name = 'Gold'), 300, (SELECT member_id FROM member WHERE last_name = 'Adams')),
	('Finale', 'Series finale of The Jiminy Glick Show', '2022-11-16 18:00:00', 60, (SELECT group_id FROM interest_group WHERE name = 'Glick Family'), 100, (SELECT member_id FROM member WHERE first_name = 'Dixie'));

SELECT * FROM event;
