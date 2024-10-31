
-- create
create table Departments
(
  Ident int not null Identity(1,1),
  Building int not null,
  Financing money not null default 0,
  Name nvarchar(100),
  check(Building > 1 and Building < 5 and Financing > 0)
);

create table Diseases
(
  Id int Identity(1,1) not null primary key,
  Name nvarchar(100) not null unique,
  Severity int not null default 1,
  check(Name != "" and Severity >= 1)
);

CREATE TABLE Doctors
(
  Id int Identity(1,1),
  Name varchar(15),
  Surname varchar(15),
  Phone varchar(12),
  Salary int
);

CREATE TABLE Examinations 
(
  Id int Identity(1,1) not null primary key,
  Name nvarchar(15) not null,
  WeekDay int not null check(WeekDay >=1 and WeekDay <= 7),
  StartTime time not null check(StartTime >= '8:00' and StartTime <= '18:00'),
  EndTime time,
  check (EndTime > StartTime)
);

Set IDENTITY_INSERT Departments on;


-- insert
INSERT INTO Examinations(Name, WeekDay, StartTime, Endtime) VALUES ('Rentgen', '1','8:00', '14:00');
INSERT INTO Examinations(Name, WeekDay, StartTime, Endtime) VALUES ('Rentgen', '1','8:00', '14:00');
INSERT INTO Examinations(Name, WeekDay, StartTime, Endtime) VALUES ('Rentgen', '1','8:00', '14:00');
 
-- fetch 
SELECT * FROM Examinations;
GO