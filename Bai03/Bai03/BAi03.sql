IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'SunriseHomestayDB')
BEGIN
    CREATE DATABASE SunriseHomestayDB;
END
GO

USE SunriseHomestayDB;
GO

-- 1. Bảng Loại Phòng
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'LoaiPhong')
BEGIN
    CREATE TABLE LoaiPhong (
        MaLoai INT IDENTITY(1,1) PRIMARY KEY,
        TenLoai NVARCHAR(100) NOT NULL,
        GiaMoiDem DECIMAL(18,2) NULL,
        MoTa NVARCHAR(255) NULL
    );
END
GO

-- 2. Bảng Phòng
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Phong')
BEGIN
    CREATE TABLE Phong (
        MaPhong INT IDENTITY(1,1) PRIMARY KEY,
        SoPhong VARCHAR(10) NOT NULL,
        TangSo INT NULL,
        TinhTrang NVARCHAR(20) NULL, -- Trống / Đang ở / Đang dọn
        HinhAnh NVARCHAR(255) NULL,   -- Chỉ lưu tên file ảnh (VD: room1.jpg)
        MaLoai INT FOREIGN KEY REFERENCES LoaiPhong(MaLoai) ON DELETE CASCADE
    );
END
GO

-- Dữ liệu mẫu
IF NOT EXISTS (SELECT 1 FROM LoaiPhong)
BEGIN
    INSERT INTO LoaiPhong (TenLoai, GiaMoiDem, MoTa) VALUES 
    (N'Phòng Đơn', 350000, N'Phòng dành cho 1 người'),
    (N'Phòng Đôi', 500000, N'Phòng dành cho 2 người'),
    (N'Phòng VIP', 800000, N'Phòng sang trọng view đẹp');
END
GO

IF NOT EXISTS (SELECT 1 FROM Phong)
BEGIN
    INSERT INTO Phong (SoPhong, TangSo, TinhTrang, HinhAnh, MaLoai) VALUES 
    ('101', 1, N'Trống', 'room1.jpg', 1),
    ('102', 1, N'Đang ở', 'room2.jpg', 2),
    ('201', 2, N'Đang dọn', 'room1.jpg', 1);
END
GO