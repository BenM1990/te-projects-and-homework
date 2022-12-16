USE final_capstone
GO

CREATE TABLE [movie] (
    movie_id       INT            NOT NULL IDENTITY (1,1) PRIMARY KEY,
    title          NVARCHAR (200) NOT NULL,
    overview       NVARCHAR (MAX) NULL,
    tagline        NVARCHAR (400) NULL,
    poster_path    VARCHAR (200)  NULL,
    home_page      VARCHAR (200)  NULL,
    release_date   DATE           NULL,
    length_minutes INT            NOT NULL,
);


SET IDENTITY_INSERT movie ON;

INSERT INTO final_capstone.dbo.movie( movie_id,title,overview,tagline,poster_path,home_page,release_date,length_minutes)
SELECT  movie_id,title,overview,tagline,poster_path,home_page,release_date,length_minutes from MovieDB.dbo.movie

SET IDENTITY_INSERT movie OFF;
