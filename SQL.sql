CREATE TABLE student
(
	_Id int PRIMARY KEY IDENTITY(170100000, 1) CHECK (_Id >= 170100000),
	_Name varchar(255) NOT NULL,
	_Sex char(3) DEFAULT '女' CHECK(_Sex in('男', '女')),
	_Old int DEFAULT 15,
	_Teacher int default 17011000 CHECK(_Teacher >= 17011000),
	_Address varchar(255) DEFAULT 'NULL',
	_Link char(20) DEFAULT '+86***********',
	_Birth date DEFAULT '2000-01-01',

	_Late int DEFAULT 0 CHECK(_Late >= 0),
	_Homework int DEFAULT 0 CHECK(_Homework >= 0),
	_Discipline int DEFAULT 0 CHECK(_Discipline >= 0),
	_Note char(3) DEFAULT '优' CHECK(_Note in('优', '良', '差')),
	_SelfStudy char(3) DEFAULT '优' CHECK(_SelfStudy in('优', '良', '差')),
	_Attitude char(3) DEFAULT '优' CHECK(_Attitude in('优', '良', '差')),

	_Remark varchar(8000) DEFAULT 'NULL'
)

CREATE TABLE teacher
(
	_Id int PRIMARY KEY IDENTITY(17011000, 1) CHECK (_Id >= 17011000),
	_Name varchar(225) NOT NULL,
	_Sex char(3) DEFAULT '女' CHECK(_Sex in('男', '女')),
	_Old int DEFAULT 20,
	_Link char(20) DEFAULT '+86***********',
	_Remark varchar(8000) DEFAULT 'NULL'
)

CREATE TABLE course
(
	_Id int PRIMARY KEY IDENTITY(17011000, 1) CHECK (_Id >= 17011000),
	_Name char(40) NOT NULL,
	_Teacher int DEFAULT 1701000,
	_Time time DEFAULT '00:00:00',
	_Place int DEFAULT 0
)

CREATE INDEX stu_index ON student (_Id, _Name)



ALTER TABLE student ADD FOREIGN KEY (_Teacher) REFERENCES teacher(_Id)