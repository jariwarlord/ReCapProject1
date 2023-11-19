-- Yeni bir veritabanı oluştur
CREATE DATABASE CarDatabase;
GO

-- Oluşturulan veritabanını kullan
USE CarDatabase;
GO

-- Brands tablosunu oluştur
CREATE TABLE Brands
(
    BrandId INT PRIMARY KEY,
    BrandName NVARCHAR(50) NOT NULL
);
GO

-- Colors tablosunu oluştur
CREATE TABLE Colors
(
    ColorId INT PRIMARY KEY,
    ColorName NVARCHAR(50) NOT NULL
);
GO

-- Cars tablosunu oluştur
CREATE TABLE Cars
(
    CarId INT PRIMARY KEY,
    BrandId INT FOREIGN KEY REFERENCES Brands(BrandId),
    ColorId INT FOREIGN KEY REFERENCES Colors(ColorId),
    ModelYear INT NOT NULL,
    DailyPrice DECIMAL(10, 2) NOT NULL
);
GO
