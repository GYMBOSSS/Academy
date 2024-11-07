
-- create
create table Departments
(
  Id int PRIMARY KEY not null Identity(1,1),
  Building int not null check(Building >= 1 and Building <= 6),
  Financing money not null default 0 check(Financing > 0),
  Name nvarchar(15),
);
insert into Departments(Building, Financing, Name) VALUES('6','20000','Pulmonology')
insert into Departments(Building, Financing, Name) VALUES('5','40000','Neurology')
insert into Departments(Building, Financing, Name) VALUES('3','130000','Cardiology')
insert into Departments(Building, Financing, Name) VALUES('3','13000','Daunology')
insert into Departments(Building, Financing, Name) VALUES('3','14000','Plotinalogy')
insert into Departments(Building, Financing, Name) VALUES('3','130000','Sosiology')

create table Wards
(
  Id int Identity(1,1) not null primary key,
  Name nvarchar(15) not null unique check(len(Name) != 0),
  DepId int not null REFERENCES Departments(Id)
)
insert into Wards(Name, DepId) VALUES('BENIS','3')

create table Diseases
(
  Id int PRIMARY KEY Identity(1,1) not null,
  Name nvarchar(15) not null unique,
  Severity int not null default 1,
  check(Name != "" and Severity >= 1)
);
insert into Diseases(Name, Severity) VALUES('Astma','2')
insert into Diseases(Name, Severity) VALUES('Flu','5')
insert into Diseases(Name, Severity) VALUES('Dementia','10')

CREATE TABLE Doctors
(
  Id int PRIMARY KEY Identity(1,1) not null,
  Name varchar(15),
  Surname varchar(15),
  Salary int,
  Premium int not NULL default 0 check(Premium > 0)
);
insert into Doctors(Name,Surname,Premium,Salary) VALUES('John','Smidt','228228','110000')
insert into Doctors(Name,Surname,Premium,Salary) VALUES('Alice','Smidt','1337','100000')
insert into Doctors(Name,Surname,Premium,Salary) VALUES('Jack','Daniels','322','120000')

CREATE TABLE Specialisations
(
  Id int PRIMARY KEY Identity(1,1) not null,
  Name nvarchar(15) not null unique CHECK(Name != "")
)

CREATE TABLE DoctorSpecialisation
(
  Id int PRIMARY KEY Identity(1,1) not null,
  DoctorId int not null REFERENCES Doctors(Id),
  SpecId int not null REFERENCES Specialisations(Id)
)

CREATE TABLE Sponsors
(
  Id int PRIMARY KEY Identity(1,1) not null,
  Name nvarchar(15) not null unique CHECK(Name != "")
)

CREATE TABLE Donations
(
  Id int PRIMARY KEY Identity(1,1) not null,
  Amount money not null CHECK(Amount > 0),
  Date date DEFAULT GETDATE() CHECK(Date <= GETDATE()),
  DepId int not null REFERENCES Departments(Id),
  SponsorId int not null REFERENCES Sponsors(Id)
)

CREATE TABLE Vacations
(
  Id int PRIMARY KEY Identity(1,1) not null,
  EndDate date not null,
  StartDate date not null,
  DoctorId int not null REFERENCES Doctors(Id),
  CHECK(EndDate > StartDate)
)

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
-- select * from Departments
select Doctors.Name + " " + Doctors.Surname AS Student, Specialisations.Name AS Specialisation
from Doctors, Specialisations, DoctorSpecialisation
where Specialisations.Id = DoctorSpecialisation.SpecId and DoctorSpecialisation.DoctorId = Doctors.Id
-- select Name as NameOfDisease, Severity as SeverityOfDisease from Diseases
-- select Name from Departments where Building = 5 and Financing < 30000
-- select Name from Departments where Building = 3 and Financing >12000 and Financing < 15000
-- select Name from Wards where Building = '4' or Building = '5' and Floor = '1'
-- select Name, Building, Financing from Departments where Building = '3' or Building = '6' and Financing < '11000' or Financing > '25000'