CREATE TABLE student
(
	_Id int(100) PRIMARY KEY IDENTITY(170100000, 1) CHECK (_Id > 0),
	_Name varchar(255) NOT NULL,
	_Sex char(10) DEFAULT '女' CHECK(_Sex in('男', '女')),
	_Old int(10) DEFAULT 15,
	_Grade char(20) DEFAULT '一年级' CHECK(_Grade in('一年级', '二年级', '三年级', '四年级', '五年级', '六年级', '七年级', '八年级', '九年级', '高一', '高二', '高三')),
	_Address varchar(255) DEFAULT 'NULL',
	_Major int(10) DEFAULT 0,
	_Link char(20) DEFAULT '+86***********',
	_StartScore int(10) DEFAULT 0,
	_EndScore int(10) DEFAULT 0,
	_Evaluation char(1) DEFAULT 'A' CHECK(_Evaluation in('A', 'B', 'C', 'D', 'E', 'F')),
	_Discipline int(10) DEFAULT 0,
	_Birth varchar(20) DEFAULT 'NULL',
	_Remark varchar(100000) DEFAULT 'NULL',
)
CREATE INDEX stu_index ON student (_Id, _Name)