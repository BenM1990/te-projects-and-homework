-- write a create script

--switch to using system database
USE master;
GO -- batch seperator, run the command and then move on to the next step

--check to see if the database already exists and if it does, drop it
DROP DATABASE IF EXISTS ArtGallery;

--create DB
CREATE DATABASE ArtGallery;
GO

--in order to add tables, etc to the ArtGalleryDB, I want to be using the ArtGallery DB
USE ArtGallery;
GO

--let's start adding tables -- all tables should be created, or none of them should, so let's use a transaction

BEGIN TRANSACTION;

--make the customer table
CREATE TABLE customer (
--column name - data type - maybe IDENTITY - CONSTRAINT
customer_id INT IDENTITY(1,1), -- IDENTITY is MS SQL Server auto-incrementing usually used for keys
customer_name VARCHAR(50) NOT NULL,
address VARCHAR(100) NOT NULL,
phone VARCHAR(14) NOT NULL,

--add primary key constraint
--CONSTRAINT (constraint name) TYPE (column name)
CONSTRAINT pk_customer PRIMARY KEY (customer_id)
);

CREATE TABLE artist (
artist_id INT IDENTITY(1,1),
artist_name VARCHAR(50) NOT NULL,
address VARCHAR(100) NOT NULL,
phone VARCHAR(14) NOT NULL

CONSTRAINT pk_artist PRIMARY KEY (artist_id)

);

CREATE TABLE artwork (
artwork_id INT IDENTITY(1,1),
description VARCHAR(50) NULL, -- allowed to be NULL
title VARCHAR(50) NOT NULL,
artist_id INT NOT NULL,

CONSTRAINT pk_artwork PRIMARY KEY (artwork_id),
CONSTRAINT fk_artist FOREIGN KEY (artist_id) REFERENCES artist(artist_id)
--CONSTRAINT name FOREIGN KEY (column name) REFERENCES table name (column name)
);

CREATE TABLE artwork_customer(
customer_id INT NOT NULL, -- the id is coming from another tabe so no IDENTITY here
artwork_id INT NOT NULL, -- same as above
purchase_date DATE NOT NULL,
price INT NOT NULL,

CONSTRAINT pk_artwork_customer PRIMARY KEY (customer_id, artwork_id),
CONSTRAINT fk_artwork_cusomter_customer FOREIGN KEY (customer_id) REFERENCES customer(customer_id),
CONSTRAINT fk_artwork_customer_artwork FOREIGN KEY (artwork_id) REFERENCES artwork(artwork_id)

);

COMMIT;
