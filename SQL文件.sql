 /*创建数据库XKDB */
 CREATE DATABASE XKDB
 go
USE XKDB

Go

/*创建表DEpartmrnt*/
CREATE TABLE Departmrnt
  (
     Departno   NVARCHAR(2) NOT NULL,
     Departname NVARCHAR(20) NOT NULL
  )

Go

ALTER TABLE Departmrnt
  ADD CONSTRAINT Pk1 PRIMARY KEY(Departno)

Go

/*创建表Class*/
CREATE TABLE Class
  (
     Classno   NVARCHAR(8) NOT NULL,
     Departno  NVARCHAR(2) NOT NULL,
     Classname NVARCHAR(20) NOT NULL
  )

ALTER TABLE Class
  ADD CONSTRAINT Pk2 PRIMARY KEY(Classno)

Go




/*创建表 Student*/
CREATE TABLE Student
  (
     Stuno    NVARCHAR(8) NOT NULL,
     Classno  NVARCHAR(8) NOT NULL,
     Stuname  NVARCHAR(10) NOT NULL,
     Sex      NVARCHAR(1) NOT NULL DEFAULT '男',
     Birthday DATETIME  NULL,
     Pwd      NVARCHAR(8) NOT NULL 
  )

Go

ALTER TABLE Student
  ADD CONSTRAINT Pk3 PRIMARY KEY (Stuno)

Go


/*创建外键 */
ALTER TABLE Student
  ADD CONSTRAINT Fk2 FOREIGN KEY (Classno) REFERENCES Class(Classno)

Go

/*创建表 Course*/
CREATE TABLE Course
  (
     Couno    NVARCHAR(3) NOT NULL,
     Couname  NVARCHAR(30) NOT NULL,
     Credit   DECIMAL(3, 1) NOT NULL,
     Limitnum DECIMAL(5, 0) NOT NULL
  )

Go

ALTER TABLE Course
  ADD CONSTRAINT Pk4 PRIMARY KEY (Couno)

Go

/*创建表 StuCou*/
CREATE TABLE Stucou
  (
     Stuno     NVARCHAR(8) NOT NULL,
     Couno     NVARCHAR(3) NOT NULL,
     Willorder SMALLINT NOT NULL,
     State     NVARCHAR(2) NOT NULL DEFAULT '报名',
     Randomnum NVARCHAR(50)
  )

Go

ALTER TABLE Stucou
  ADD CONSTRAINT Pk5 PRIMARY KEY (Stuno, Couno)

Go

/*创建外键 */
ALTER TABLE Stucou
  ADD CONSTRAINT Fk3 FOREIGN KEY(Stuno) REFERENCES Student(Stuno)

Go

ALTER TABLE Stucou
  ADD CONSTRAINT Fk4 FOREIGN KEY (Couno) REFERENCES Course(Couno)

Go

/*创建表 Users*/
CREATE TABLE Users
  (
     Userid    NVARCHAR(8) NOT NULL,
     Username NVARCHAR(8) NOT NULL,
     Pwd       NVARCHAR(8) NOT NULL,
     Email     NVARCHAR(50) NOT NULL,
     Telephine NVARCHAR(20) NOT NULL
  )

Go

/*
ALTER TABLE Users
ADD CONSTRAINT Fk4 Foreign Key*/
/*增加实验数据：系部表，班级表，学生表*/
USE Xkdb

Go

INSERT INTO Departmrnt
VALUES      ('01',
             '计算机工程系')

INSERT INTO Departmrnt
VALUES      ('02',
             '软件工程系')

INSERT INTO Departmrnt
VALUES      ('03',
             '电子工程系')

Go

SELECT *
FROM   Departmrnt

INSERT INTO Class
VALUES      ('12000001',
             '01',
             '12计算机1班')

INSERT INTO Class
VALUES      ('12000002',
             '01',
             '12计算机2班')

INSERT INTO Class
VALUES      ('12000003',
             '01',
             '12计算机3班')

INSERT INTO Class
VALUES      ('130000x1',
             '02',
             '13软件1班')

INSERT INTO Class
VALUES      ('130000x2',
             '02',
             '13软件2班')

INSERT INTO Class
VALUES      ('130000x3',
             '02',
             '13软件3班')

Go

SELECT *
FROM   Class

SELECT *
FROM   Class C,
       Departmrnt D
WHERE  C.Departno = D.Departno

INSERT INTO Student
VALUES      ('12001001',
             '12000001',
             '张小红',
             '女',
             '1990/10/24',
             '111')

INSERT INTO Student
VALUES      ('12001002',
             '12000001',
             '李长安',
             '男',
             '1991/6/26',
             '111')

INSERT INTO Student
VALUES      ('12001003',
             '12000001',
             '熊天亮',
             '男',
             '1992/3/20',
             '111')

INSERT INTO Student
VALUES      ('12002004',
             '12000001',
             '王英',
             '女',
             '1991/9/2',
             '111')

INSERT INTO Student
VALUES      ('12002005',
             '12000001',
             '李亮',
             '男',
             '1991/11/13',
             '111')

INSERT INTO Student
VALUES      ('12002006',
             '12000001',
             '王贺',
             '男',
             '1990/5/24',
             '111')

Go

INSERT INTO Student
VALUES      ('13002011',
             '130000x1',
             'Jack',
             '男',
             '1991/8/14',
             '111')

INSERT INTO Student
VALUES      ('13002012',
             '130000x1',
             'Mary',
             '女',
             '1993/11/4',
             '111')

INSERT INTO Student
VALUES      ('13002013',
             '130000x1',
             'Tom',
             '男',
             '1992/10/15',
             '111')

INSERT INTO Student
VALUES      ('13002014',
             '130000x1',
             'Joans',
             '女',
             '1992/5/4',
             '111')

INSERT INTO Student
VALUES      ('13002015',
             '130000x1',
             'John',
             '男',
             '1992/4/14',
             '111')

Go

SELECT *
FROM   Student

SELECT *
FROM   Student S,
       Class C,
       Departmrnt D
WHERE  C.Departno = D.Departno
       AND S.Classno = C.Classno

/*增加实验数据：课程信息表*/
INSERT INTO Course
VALUES      ('001',
             'SQL Server实用技术',
             3.0,
             20)

INSERT INTO Course
VALUES      ('002',
             'JAVA技术的开发应用',
             2.0,
             10)

INSERT INTO Course
VALUES      ('003',
             '网络信息检索原理与技术',
             2.0,
             10)

INSERT INTO Course
VALUES      ('004',
             'Linux操作系统',
             2.0,
             10)

INSERT INTO Course
VALUES      ('005',
             'Premiere6.0影视制作',
             2.0,
             20)

INSERT INTO Course
VALUES      ('006',
             'Director动画电影设计与制作',
             2.0,
             10)

INSERT INTO Course
VALUES      ('007',
             'Delphi初级程序员',
             2.0,
             10)

INSERT INTO Course
VALUES      ('008',
             'ASP.NET应用',
             2.5,
             10)

INSERT INTO Course
VALUES      ('009',
             '水资源利用管理与保护',
             2.0,
             10)

INSERT INTO Course
VALUES      ('010',
             '中级电工理论',
             3.0,
             5)

INSERT INTO Course
VALUES      ('011',
             '中外建筑欣赏',
             2.0,
             20)

INSERT INTO Course
VALUES      ('012',
             '智能建筑',
             2.0,
             10)

INSERT INTO Course
VALUES      ('013',
             '房地产漫谈',
             2.0,
             10)

INSERT INTO Course
VALUES      ('014',
             '科技与探索',
             1.5,
             10)

INSERT INTO Course
VALUES      ('015',
             '民俗风情旅游',
             2.0,
             20)

INSERT INTO Course
VALUES      ('016',
             '旅行社经营管理',
             2.0,
             20)

INSERT INTO Course
VALUES      ('017',
             '世界旅游',
             2.0,
             10)

INSERT INTO Course
VALUES      ('018',
             '中餐菜肴制作',
             2.0,
             5)

INSERT INTO Course
VALUES      ('019',
             '电子出版概论',
             2.0,
             10)

Go

SELECT *
FROM   Course

SELECT *
FROM   Course
ORDER  BY Couno

Go  