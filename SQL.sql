CREATE TABLE teacher
(
	_Id int PRIMARY KEY IDENTITY(1701000, 1) CHECK (_Id >= 1701000),
	_Name varchar(225) NOT NULL,
	_Sex varchar(3) DEFAULT '女' CHECK(_Sex in('男', '女')),
	_Old int DEFAULT 20,
	_Link varchar(20) DEFAULT '+86***********',
	
	_Remark varchar(800) DEFAULT NULL
)

CREATE TABLE student
(
	_Id int PRIMARY KEY IDENTITY(17020000, 1) CHECK (_Id >= 17020000),
	_Name varchar(255) NOT NULL,
	_Sex varchar(3) DEFAULT '男' CHECK(_Sex in('男', '女')),
	_Birth date DEFAULT '2000-01-01',
	_Nation varchar(6) DEFAULT '汉',
	_Payment varchar(10) DEFAULT '未缴费' CHECK(_Payment in('未缴费', '预缴费', '已缴费')),
	_Link varchar(20) DEFAULT '+86**********',
	_Teacher int FOREIGN KEY REFERENCES teacher(_Id) DEFAULT 1701000,
	_Grade varchar(10) DEFAULT '高一' CHECK(_Grade in('一年级', '二年级', '三年级', '四年级', '五年级', '六年级', '七年级', '八年级', '九年级', '高一' ,'高二' ,'高三')),
	_Address varchar(255) DEFAULT NULL,
	_Organization varchar(40) DEFAULT '比丽弗教育机构',
	_Campus varchar(40) DEFAULT '普格',
	
	_Absenteeism int DEFAULT 0 CHECK(_Absenteeism >= 0),
	_Late int DEFAULT 0 CHECK(_Late >= 0),
	_Homework int DEFAULT 0 CHECK(_Homework >= 0),
	_Discipline int DEFAULT 0 CHECK(_Discipline >= 0),
	_ClassPerform varchar(3) DEFAULT '优' CHECK(_ClassPerform in('优', '良', '合格', '不合格', '差')),
	_StudyPerform varchar(3) DEFAULT '优' CHECK(_StudyPerform in('优', '良', '合格', '不合格', '差')),
	_Attitude varchar(3) DEFAULT '优' CHECK(_Attitude in('优', '良', '合格', '不合格', '差')),
	_Overall varchar(800) DEFAULT NULL
)

CREATE TABLE course
(
	_Id int PRIMARY KEY IDENTITY(170300, 1) CHECK (_Id >= 170300),
	_Name varchar(40) NOT NULL,
	_Teacher int FOREIGN KEY REFERENCES teacher(_Id),
	_Time time DEFAULT '00:00:00',
	_Place int DEFAULT 0
)

CREATE TABLE elective
(
	_IdStu int NOT NULL FOREIGN KEY REFERENCES student(_Id),
	_IdCou int NOT NULL FOREIGN KEY REFERENCES course(_Id),
	_Score1 int DEFAULT 0 CHECK(_Score1 >= 0 AND _Score1 <=150),
	_Score2 int DEFAULT 0 CHECK(_Score2 >= 0 AND _Score2 <=150),
	_Score3 int DEFAULT 0 CHECK(_Score3 >= 0 AND _Score3 <=150),
	_Score4 int DEFAULT 0 CHECK(_Score4 >= 0 AND _Score4 <=150),
	_Score5 int DEFAULT 0 CHECK(_Score5 >= 0 AND _Score5 <=150),
	_Score6 int DEFAULT 0 CHECK(_Score6 >= 0 AND _Score6 <=150),
	_Score7 int DEFAULT 0 CHECK(_Score7 >= 0 AND _Score7 <=150),
	_Score8 int DEFAULT 0 CHECK(_Score8 >= 0 AND _Score8 <=150),
	CONSTRAINT _IdEle PRIMARY KEY (_IdStu, _IdCou)
)

CREATE TABLE users
(
	_Id int PRIMARY KEY,
	_Type varchar(20) DEFAULT 'Public' CHECK (_Type in('Administrator', 'Teacher', 'student', 'public')),
	_Permission varchar(30) DEFAULT 'select'
)

CREATE INDEX stu_index ON student (_Id, _Name)
