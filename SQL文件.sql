 /*�������ݿ�XKDB */
 CREATE DATABASE XKDB
 go
USE XKDB

Go

/*������DEpartmrnt*/
CREATE TABLE Departmrnt
  (
     Departno   NVARCHAR(2) NOT NULL,
     Departname NVARCHAR(20) NOT NULL
  )

Go

ALTER TABLE Departmrnt
  ADD CONSTRAINT Pk1 PRIMARY KEY(Departno)

Go

/*������Class*/
CREATE TABLE Class
  (
     Classno   NVARCHAR(8) NOT NULL,
     Departno  NVARCHAR(2) NOT NULL,
     Classname NVARCHAR(20) NOT NULL
  )

ALTER TABLE Class
  ADD CONSTRAINT Pk2 PRIMARY KEY(Classno)

Go




/*������ Student*/
CREATE TABLE Student
  (
     Stuno    NVARCHAR(8) NOT NULL,
     Classno  NVARCHAR(8) NOT NULL,
     Stuname  NVARCHAR(10) NOT NULL,
     Sex      NVARCHAR(1) NOT NULL DEFAULT '��',
     Birthday DATETIME  NULL,
     Pwd      NVARCHAR(8) NOT NULL 
  )

Go

ALTER TABLE Student
  ADD CONSTRAINT Pk3 PRIMARY KEY (Stuno)

Go


/*������� */
ALTER TABLE Student
  ADD CONSTRAINT Fk2 FOREIGN KEY (Classno) REFERENCES Class(Classno)

Go

/*������ Course*/
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

/*������ StuCou*/
CREATE TABLE Stucou
  (
     Stuno     NVARCHAR(8) NOT NULL,
     Couno     NVARCHAR(3) NOT NULL,
     Willorder SMALLINT NOT NULL,
     State     NVARCHAR(2) NOT NULL DEFAULT '����',
     Randomnum NVARCHAR(50)
  )

Go

ALTER TABLE Stucou
  ADD CONSTRAINT Pk5 PRIMARY KEY (Stuno, Couno)

Go

/*������� */
ALTER TABLE Stucou
  ADD CONSTRAINT Fk3 FOREIGN KEY(Stuno) REFERENCES Student(Stuno)

Go

ALTER TABLE Stucou
  ADD CONSTRAINT Fk4 FOREIGN KEY (Couno) REFERENCES Course(Couno)

Go

/*������ Users*/
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
/*����ʵ�����ݣ�ϵ�����༶��ѧ����*/
USE Xkdb

Go

INSERT INTO Departmrnt
VALUES      ('01',
             '���������ϵ')

INSERT INTO Departmrnt
VALUES      ('02',
             '�������ϵ')

INSERT INTO Departmrnt
VALUES      ('03',
             '���ӹ���ϵ')

Go

SELECT *
FROM   Departmrnt

INSERT INTO Class
VALUES      ('12000001',
             '01',
             '12�����1��')

INSERT INTO Class
VALUES      ('12000002',
             '01',
             '12�����2��')

INSERT INTO Class
VALUES      ('12000003',
             '01',
             '12�����3��')

INSERT INTO Class
VALUES      ('130000x1',
             '02',
             '13���1��')

INSERT INTO Class
VALUES      ('130000x2',
             '02',
             '13���2��')

INSERT INTO Class
VALUES      ('130000x3',
             '02',
             '13���3��')

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
             '��С��',
             'Ů',
             '1990/10/24',
             '111')

INSERT INTO Student
VALUES      ('12001002',
             '12000001',
             '���',
             '��',
             '1991/6/26',
             '111')

INSERT INTO Student
VALUES      ('12001003',
             '12000001',
             '������',
             '��',
             '1992/3/20',
             '111')

INSERT INTO Student
VALUES      ('12002004',
             '12000001',
             '��Ӣ',
             'Ů',
             '1991/9/2',
             '111')

INSERT INTO Student
VALUES      ('12002005',
             '12000001',
             '����',
             '��',
             '1991/11/13',
             '111')

INSERT INTO Student
VALUES      ('12002006',
             '12000001',
             '����',
             '��',
             '1990/5/24',
             '111')

Go

INSERT INTO Student
VALUES      ('13002011',
             '130000x1',
             'Jack',
             '��',
             '1991/8/14',
             '111')

INSERT INTO Student
VALUES      ('13002012',
             '130000x1',
             'Mary',
             'Ů',
             '1993/11/4',
             '111')

INSERT INTO Student
VALUES      ('13002013',
             '130000x1',
             'Tom',
             '��',
             '1992/10/15',
             '111')

INSERT INTO Student
VALUES      ('13002014',
             '130000x1',
             'Joans',
             'Ů',
             '1992/5/4',
             '111')

INSERT INTO Student
VALUES      ('13002015',
             '130000x1',
             'John',
             '��',
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

/*����ʵ�����ݣ��γ���Ϣ��*/
INSERT INTO Course
VALUES      ('001',
             'SQL Serverʵ�ü���',
             3.0,
             20)

INSERT INTO Course
VALUES      ('002',
             'JAVA�����Ŀ���Ӧ��',
             2.0,
             10)

INSERT INTO Course
VALUES      ('003',
             '������Ϣ����ԭ���뼼��',
             2.0,
             10)

INSERT INTO Course
VALUES      ('004',
             'Linux����ϵͳ',
             2.0,
             10)

INSERT INTO Course
VALUES      ('005',
             'Premiere6.0Ӱ������',
             2.0,
             20)

INSERT INTO Course
VALUES      ('006',
             'Director������Ӱ���������',
             2.0,
             10)

INSERT INTO Course
VALUES      ('007',
             'Delphi��������Ա',
             2.0,
             10)

INSERT INTO Course
VALUES      ('008',
             'ASP.NETӦ��',
             2.5,
             10)

INSERT INTO Course
VALUES      ('009',
             'ˮ��Դ���ù����뱣��',
             2.0,
             10)

INSERT INTO Course
VALUES      ('010',
             '�м��繤����',
             3.0,
             5)

INSERT INTO Course
VALUES      ('011',
             '���⽨������',
             2.0,
             20)

INSERT INTO Course
VALUES      ('012',
             '���ܽ���',
             2.0,
             10)

INSERT INTO Course
VALUES      ('013',
             '���ز���̸',
             2.0,
             10)

INSERT INTO Course
VALUES      ('014',
             '�Ƽ���̽��',
             1.5,
             10)

INSERT INTO Course
VALUES      ('015',
             '���׷�������',
             2.0,
             20)

INSERT INTO Course
VALUES      ('016',
             '�����羭Ӫ����',
             2.0,
             20)

INSERT INTO Course
VALUES      ('017',
             '��������',
             2.0,
             10)

INSERT INTO Course
VALUES      ('018',
             '�вͲ�������',
             2.0,
             5)

INSERT INTO Course
VALUES      ('019',
             '���ӳ������',
             2.0,
             10)

Go

SELECT *
FROM   Course

SELECT *
FROM   Course
ORDER  BY Couno

Go  