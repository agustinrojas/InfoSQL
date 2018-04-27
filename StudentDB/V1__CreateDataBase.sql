USE master;
GO
-- Create the database with the default data
-- filegroup, filstream filegroup and a log file. Specify the
-- growth increment and the max size for the
-- primary data file.
CREATE DATABASE StundetBD
ON PRIMARY
  ( NAME='StudentDB_Primary',
    FILENAME=
       'c:\DataSQL\StudentDB_Prm.mdf',
    SIZE=4MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB),
FILEGROUP StudentDB_FG1
  ( NAME = 'StudentDB_FG1_Dat1',
    FILENAME =
       'c:\DataSQL\StudentDB_FG1_1.ndf',
    SIZE = 1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB),
  ( NAME = 'StudentDB_FG1_Dat2',
    FILENAME =
       'c:\DataSQL\StudentDB_FG1_2.ndf',
    SIZE = 1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB)
LOG ON
  ( NAME='StundetDB_log',
    FILENAME =
       'c:\DataSQL\StudentDB.ldf',
    SIZE=1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB);
GO


