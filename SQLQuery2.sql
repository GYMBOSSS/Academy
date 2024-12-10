use Academy;

create table Curators
(
	ID int primary key Identity(1,1) not null,
	Namee nvarchar(max) check(Namee != '') not null,
	Surname nvarchar(max) check(Surname != '') not null
)

create table Faculties
(
	ID int primary key Identity(1,1) not null,
	Financing money default(0) check(Financing > 0) not null,
	Namee nvarchar(20) check(Namee != '') unique not null
)

create table Departments
(
	ID int primary key Identity(1,1) not null,
	Financing money default(0) check(Financing > 0) not null,
	Namee nvarchar(20) check(Namee != '') unique not null,
	FacultyID int references Faculties(ID) not null
)

create table Groups
(
	ID int primary key Identity(1,1) not null,
	Namee nvarchar(20) check(Namee != '') unique not null,
	Yearr int check(Yearr >= 1 and Yearr <= 5) not null,
	DepartmentID int references Departments(ID) not null
)

create table GroupsCurators
(
	ID int primary key Identity(1,1) not null,
	CuratorID int references Curators(ID) not null,
	GroupID int references Groups(ID)
)

create table Sub

create table Lectures
(
	ID int primary key Identity(1,1) not null,
	LectureRoom nvarchar(max) check(LectureRoom != '') not null,
	SubjectID int references Subjects(ID) not null,
	TeacherID int references Teachers(ID) not null
)

create table GroupsLectors
(
	ID int primary key Identity(1,1) not null,
	GroupID int references Groups(ID) not null,
	LectureID int references Lectures(ID) not null
)
