CREATE DATABASE TA_PROJECT;
USE TA_PROJECT;
--drop database TA_PROJECT;
CREATE TABLE TA_info (
    ID nchar(100) ,
    Name nCHAR(200),
    Password nCHAR(200),
    Email nCHAR(200)
);

CREATE TABLE LD_info (
    ID nchar(100) ,
    Name nCHAR(200),
    Password nCHAR(200),
    Email nCHAR(200)
);
CREATE TABLE faculty_info (
    ID nchar(100) ,
    Name nCHAR(200),
    Password nCHAR(200),
    Email nCHAR(200)
);
CREATE TABLE admin_info (
    ID nchar(100) ,
    Name nCHAR(200),
    Password nCHAR(200),
    Email nCHAR(200)
);
create table Faculty(
	faculty_Name varchar(255),
	faculty_id int primary key,
);
create table TA(
 ta_id int primary key,
 name varchar(255),
 email varchar(255),
 cgpa float,
 avl bit,
 faculty_id int,
 foreign key (faculty_id) references Faculty(faculty_id),
);
create table LD(
 ld_id int primary key,
 name varchar(255),
 email varchar(255),
 cgpa float,
 avl bit,
 faculty_id int,
 foreign key (faculty_id) references Faculty(faculty_id),
)
create table task_ta(
	task_ta_id int primary key identity(1,1),
	task varchar(1000),
	
	faculty_id int,
	foreign key (faculty_id) references Faculty(faculty_id),
);
create table task_ld(
	task_ld_id int primary key identity(1,1),
	task varchar(1000),
	
	faculty_id int,
	foreign key (faculty_id) references Faculty(faculty_id),
);
CREATE TRIGGER trgTaskAssignedToTA
ON task_ta
AFTER INSERT
AS
BEGIN
    DECLARE @TA_ID int;

    -- Get the TA_ID from the inserted row in task_ta
    SELECT @TA_ID = faculty_id FROM inserted;

    -- Update the avl column of TA to 0 if a task is assigned
    UPDATE TA SET avl = 0 WHERE ta_id = @TA_ID;
END;


CREATE TRIGGER trgTaskAssignedToLD
ON task_ld
AFTER INSERT
AS
BEGIN
    DECLARE @LD_ID int;

    -- Get the TA_ID from the inserted row in task_ta
    SELECT @LD_ID = faculty_id FROM inserted;

    -- Update the avl column of TA to 0 if a task is assigned
    UPDATE LD SET avl = 0 WHERE ld_id = @LD_ID;
END;

CREATE TRIGGER trgTaskDeletedFromTaskTA
ON task_ta
AFTER DELETE
AS
BEGIN
    DECLARE @DeletedFacultyID INT;

    -- Capture the deleted faculty_id (presumably ta_id) from the deleted rows in task_ta
    SELECT @DeletedFacultyID = faculty_id FROM deleted;

    -- Update the availability (avl) to 1 in the TA table after a task is deleted
    UPDATE TA SET avl = 1 WHERE ta_id = @DeletedFacultyID;
END;
CREATE TRIGGER trgTaskDeletedFromTaskLD
ON task_ld
AFTER DELETE
AS
BEGIN
    DECLARE @DeletedFacultyID INT;

    -- Capture the deleted faculty_id (presumably ta_id) from the deleted rows in task_ta
    SELECT @DeletedFacultyID = faculty_id FROM deleted;

    -- Update the availability (avl) to 1 in the TA table after a task is deleted
    UPDATE LD SET avl = 1 WHERE ld_id = @DeletedFacultyID;
END;

INSERT INTO admin_info (ID, Name, Password, Email) VALUES
('1', 'Admin1', '1', 'admin1@fast.com'),
('2', 'username', '2', 'un2@fast.com');
