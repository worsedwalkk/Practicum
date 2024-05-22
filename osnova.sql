USE SchoolDB;

-- ������� ������������� ��� ����������� � �����������
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE,
    Password NVARCHAR(100),
    Role NVARCHAR(50)
);

-- ������� �����
CREATE TABLE Groups (
    GroupID INT PRIMARY KEY IDENTITY,
    GroupName NVARCHAR(100)
);

-- ������� ��������
CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY IDENTITY,
    UserID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- ������� ���������
CREATE TABLE Students (
    StudentID INT PRIMARY KEY IDENTITY,
    UserID INT,
    GroupID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (GroupID) REFERENCES Groups(GroupID)
);

-- ������� ���������
CREATE TABLE Disciplines (
    DisciplineID INT PRIMARY KEY IDENTITY,
    DisciplineName NVARCHAR(100),
    TeacherID INT,
    FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID)
);

-- ������� ������� ��������
CREATE TABLE Assignments (
    AssignmentID INT PRIMARY KEY IDENTITY,
    DisciplineID INT,
    GroupID INT,
    FilePath NVARCHAR(200),
    DateAdded DATETIME,
    FOREIGN KEY (DisciplineID) REFERENCES Disciplines(DisciplineID),
    FOREIGN KEY (GroupID) REFERENCES Groups(GroupID)
);

-- ������� ������� ���������
CREATE TABLE Reports (
    ReportID INT PRIMARY KEY IDENTITY,
    StudentID INT,
    AssignmentID INT,
    FilePath NVARCHAR(200),
    DateUploaded DATETIME,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (AssignmentID) REFERENCES Assignments(AssignmentID)
);
