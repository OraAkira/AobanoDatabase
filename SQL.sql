CREATE TABLE student
(
	_Id int PRIMARY KEY IDENTITY(170100000, 1) CHECK (_Id >= 170100000),
	_Name varchar(255) NOT NULL,
	_Sex char(3) DEFAULT '女' CHECK(_Sex in("男', '女")),
	_Old int DEFAULT 15,
	_Grade char(10) DEFAULT '一年级' CHECK(_Grade in("一年级', '二年级', '三年级', '四年级', '五年级', '六年级', '七年级', '八年级', '九年级', '高一', '高二', '高三")),
	_Teacher int default 17011000 CHECK(_Teacher >= 17011000),
	_Address varchar(255) DEFAULT 'NULL',
	_Major int DEFAULT 0,
	_Link char(20) DEFAULT '+86***********',
	_StartScore int DEFAULT 0,
	_EndScore int DEFAULT 0,
	_Evaluation char(1) DEFAULT 'A' CHECK(_Evaluation in('A', 'B', 'C', 'D', 'E', 'F')),
	_Discipline int DEFAULT 0,
	_Birth date DEFAULT '2000-01-01',
	_Remark varchar(8000) DEFAULT 'NULL'
)
CREATE INDEX stu_index ON student (_Id, _Name)

CREATE TABLE teacher
(
	_Id int PRIMARY KEY IDENTITY(17011000, 1) CHECK (_Id >= 17011000),
	_Name varchar(225) NOT NULL,
	_Sex char(3) DEFAULT '女' CHECK(_Sex in('男', '女')),
	_Old int DEFAULT 20,
	_Major int DEFAULT 0,
	_Grade char(40) DEFAULT '一年级' ,
	_Link char(20) DEFAULT "+86***********",
	_Remark varchar(8000) DEFAULT 'NULL'
)

ALTER TABLE student ADD FOREIGN KEY (_Teacher) REFERENCES teacher(_Id)