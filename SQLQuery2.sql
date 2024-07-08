CREATE TABLE Users (
    id INT PRIMARY KEY,
    name NVARCHAR(15),
    surname NVARCHAR(15),
    tc NVARCHAR(11) UNIQUE
);
CREATE TABLE Cars (
    id INT PRIMARY KEY,
    carname NVARCHAR(15),
    cardetail NVARCHAR(15),
    plaka NVARCHAR(11) UNIQUE,
    usertc NVARCHAR(11),
    FOREIGN KEY (usertc) REFERENCES Users(tc)
);
CREATE TABLE Parks (
    id INT PRIMARY KEY,
    parkloc NVARCHAR(10),
    plaka NVARCHAR(11),
    enterence DATE,
    FOREIGN KEY (plaka) REFERENCES Cars(plaka)
);

CREATE TABLE Earning (
    id int PRIMARY KEY IDENTITY(1,1),
    money nvarchar(50)
);