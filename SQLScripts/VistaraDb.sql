CREATE TABLE Bookings
(
    FCode      INT NULL,
    FlyDate    DATETIME NULL,
    Pass_Name  VARCHAR(50) NULL,
    Addr       VARCHAR(200) NULL,
    Phone      VARCHAR(20) NULL,
    Class      VARCHAR(20) NULL,
    Seatno     VARCHAR(20) NULL,
    CrdtNo     VARCHAR(20) NULL,
    Fare       DECIMAL(18, 0) NULL
);

CREATE TABLE Cancels
(
    CancelId    INT IDENTITY(1,1) PRIMARY KEY,  -- PK
    FCode       INT NULL,
    CancelDate  DATETIME NULL,
    FlyDate     DATETIME NULL,
    Pass_Name   VARCHAR(50) NULL,
    Addr        VARCHAR(200) NULL,
    Phone       VARCHAR(20) NULL,
    Class       VARCHAR(20) NULL,
    Seatno      VARCHAR(20) NULL,
    Amount      VARCHAR(20) NULL,
    Fare        DECIMAL(18, 0) NULL,
    Reduction   DECIMAL(18, 0) NULL,
    ReturnBal   CHAR(10) NULL
);

CREATE TABLE EmployeeLogin (
    UserName VARCHAR(12) PRIMARY KEY,
    Password VARCHAR(12) NULL
);
CREATE TABLE ManagerLogin (
    UserName VARCHAR(12) PRIMARY KEY,
    Password VARCHAR(12) NULL
);
 
INSERT INTO EmployeeLogin (UserName, Password )
VALUES ('emp1', '12345'),
       ('man1', '123'  );
 
 INSERT INTO EmployeeLogin (UserName, Password) VALUES ('emp2', 'pass1');
INSERT INTO ManagerLogin (UserName, Password) VALUES ('mgr1', 'pass1');
select * from EmployeeLogin
select * from ManagerLogin

select * from Flight
select * from FlStatus


DROP TABLE Cancels;
DROP TABLE FlStatus;
 
 
-- Final corrected database schema using the table name 'Flights'

CREATE TABLE Flights (
    FCode INT PRIMARY KEY,
    FName VARCHAR(50) NULL,
    Source VARCHAR(50) NULL,
    Destination VARCHAR(50) NULL,
    Arrival TIME NULL,
    Departure TIME NULL
);

-- The FlStatus table with a foreign key referencing the 'Flights' table
CREATE TABLE FlStatus (
    FCode INT PRIMARY KEY,
    Exe_Seats INT NULL,
    Exe_Fare DECIMAL(18, 0) NULL,
    Eco_Seats INT NULL,
    Eco_Fare DECIMAL(18, 0) NULL,
    Bus_Seats INT NULL,
    Bus_Fare DECIMAL(18, 0) NULL,
    CONSTRAINT FK_FlStatus_Flights FOREIGN KEY (FCode) REFERENCES Flights(FCode)
);

CREATE TABLE PassengerDetails
(
    FCode   INT NULL,
    FlyDate DATETIME NULL,
    Name    VARCHAR(50) NULL,
    Addr    VARCHAR(50) NULL,
    PhNo    VARCHAR(20) NULL,
    Email   VARCHAR(50) NULL,
    Amount  VARCHAR(20) NULL,
    SeatNo  VARCHAR(20) NULL
);










 drop Flight
 drop FlStatus
select * from Flight
select * from FlStatus

CREATE TABLE Flight (
    FCode INT PRIMARY KEY,
    FName VARCHAR(50) NULL,
    Source VARCHAR(50) NULL,
    Destination VARCHAR(50) NULL,
    Arrival TIME NULL,
    Departure TIME NULL
);

CREATE TABLE FlStatus (
    FCode INT PRIMARY KEY FOREIGN KEY REFERENCES Flight(FCode),
    Exe_Seats INT,
    Exe_Fare DECIMAL(18, 0),
    Eco_Seats INT,
    Eco_Fare DECIMAL(18, 0),
    Bus_Seats INT,
    Bus_Fare DECIMAL(18, 0)
);
SELECT * FROM Bookings

CREATE TABLE Bookings (
BookingId INT IDENTITY(1,1) PRIMARY KEY, -- Added a unique primary key
FCode INT,
FlyDate DATETIME NULL,
Pass_Name VARCHAR(50) NULL,
Addr VARCHAR(200) NULL,
Phone VARCHAR(20) NULL,
Class VARCHAR(20) NULL,
Seatno VARCHAR(20) NULL,
CrdtNo VARCHAR(20) NULL,
Fare DECIMAL(18, 0) NULL,
-- Added foreign key constraints
FOREIGN KEY (FCode) REFERENCES Flight(FCode),
FOREIGN KEY (FCode) REFERENCES FlStatus(FCode)
);