


CREATE TABLE Musican (
    IdMusican int  NOT NULL IDENTITY,
    FirstName nvarchar(30)  NOT NULL,
    LastName nvarchar(50)  NOT NULL,
    Nickname nvarchar(20)  NULL,
    CONSTRAINT Musican_pk PRIMARY KEY  (IdMusican)
);

-- Table: Musican_Track
CREATE TABLE Musican_Track (
    IdTrack int  NOT NULL,
    IdMusican int  NOT NULL,
    CONSTRAINT Musican_Track_pk PRIMARY KEY  (IdTrack,IdMusican)
);

-- Table: MusicLabel
CREATE TABLE MusicLabel (
    IdMusicLabel int  NOT NULL IDENTITY,
    Name nvarchar(50)  NOT NULL,
    CONSTRAINT MusicLabel_pk PRIMARY KEY  (IdMusicLabel)
);

-- Table: Album
CREATE TABLE Album (
    IdAlbum int  NOT NULL IDENTITY,
    AlbumName nvarchar(30)  NOT NULL,
	PublishDate datetime  NOT NULL,
	IdMusicLabel int NOT NULL,
    CONSTRAINT Album_pk PRIMARY KEY  (IdAlbum)
);

-- Table: Track
CREATE TABLE Track (
    IdTrack int  NOT NULL IDENTITY,
    TrackName nvarchar(20)  NOT NULL,
    Duration float  NOT NULL,
    IdMusicAlbum int NOT NULL,
    CONSTRAINT Track_pk PRIMARY KEY  (IdTrack)
);

-- foreign keys
-- Reference: MusicLabel_Album (table: MusicLabel)
ALTER TABLE Album ADD CONSTRAINT MusicLabel_Album
    FOREIGN KEY (IdMusicLabel)
    REFERENCES MusicLabel (IdMusicLabel);

-- Reference: Country_Trip_Trip (table: Country_Trip)
ALTER TABLE Musican_Track ADD CONSTRAINT Musican_Musican_Track
    FOREIGN KEY (IdMusican)
    REFERENCES Musican (IdMusican);

-- Reference: Table_5_Client (table: Client_Trip)
ALTER TABLE Musican_Track ADD CONSTRAINT Track_Musican_Track
    FOREIGN KEY (IdTrack)
    REFERENCES Track (IdTrack);

-- Reference: Table_5_Trip (table: Client_Trip)
ALTER TABLE Track ADD CONSTRAINT Album_Track
    FOREIGN KEY (IdMusicAlbum)
    REFERENCES Album (IdAlbum);

-- End of file.
SET IDENTITY_INSERT Musican ON
insert into Musican (IdMusican, FirstName, LastName, Nickname) values (1, 'Dominick', 'Goodrich', 'Wonter');
insert into Musican (IdMusican, FirstName, LastName, Nickname) values (2, 'Celestia', 'Banford', 'Sanchiz');
insert into Musican (IdMusican, FirstName, LastName, Nickname) values (3, 'Gunter', 'McInnery', 'Brolechan');
insert into Musican (IdMusican, FirstName, LastName, Nickname) values (4, 'Harcourt', 'Colby', 'Petters');
insert into Musican (IdMusican, FirstName, LastName, Nickname) values (5, 'Rachele', 'Paddison', 'Shitliff');
SET IDENTITY_INSERT Musican OFF

SET IDENTITY_INSERT MusicLabel ON
insert into MusicLabel (IdMusicLabel, Name) values (1, 'Mat Lam Tam');
insert into MusicLabel (IdMusicLabel, Name) values (2, 'Namfix');
insert into MusicLabel (IdMusicLabel, Name) values (3, 'Bitchip');
insert into MusicLabel (IdMusicLabel, Name) values (4, 'Zontrax');
insert into MusicLabel (IdMusicLabel, Name) values (5, 'Duobam');
SET IDENTITY_INSERT MusicLabel OFF

SET IDENTITY_INSERT Album ON
insert into Album (IdAlbum, AlbumName, PublishDate, IdMusicLabel) values (1, 'Asoka', '2021-10-09', 1);
insert into Album (IdAlbum, AlbumName, PublishDate, IdMusicLabel) values (2, 'Bytecard', '2021-08-24', 2);
insert into Album (IdAlbum, AlbumName, PublishDate, IdMusicLabel) values (3, 'Overhold', '2022-03-24', 3);
insert into Album (IdAlbum, AlbumName, PublishDate, IdMusicLabel) values (4, 'Voltsillam', '2022-04-10', 4);
insert into Album (IdAlbum, AlbumName, PublishDate, IdMusicLabel) values (5, 'Keylex', '2021-07-17', 5);
SET IDENTITY_INSERT Album OFF

SET IDENTITY_INSERT Track ON
insert into Track (IdTrack, TrackName, Duration, IdMusicAlbum) values (1, 'Pixope', 56.6, 1);
insert into Track (IdTrack, TrackName, Duration, IdMusicAlbum) values (2, 'Topiclounge', 58.5, 2);
insert into Track (IdTrack, TrackName, Duration, IdMusicAlbum) values (3, 'Digitube', 2.9, 3);
insert into Track (IdTrack, TrackName, Duration, IdMusicAlbum) values (4, 'Pixoboo', 47.2, 4);
insert into Track (IdTrack, TrackName, Duration, IdMusicAlbum) values (5, 'Jabbersphere', 3.4, 5);
SET IDENTITY_INSERT Track OFF

insert into Musican_Track (IdTrack, IdMusican) values (1, 5);
insert into Musican_Track (IdTrack, IdMusican) values (2, 4);
insert into Musican_Track (IdTrack, IdMusican) values (3, 3);
insert into Musican_Track (IdTrack, IdMusican) values (4, 2);
insert into Musican_Track (IdTrack, IdMusican) values (5, 1);

