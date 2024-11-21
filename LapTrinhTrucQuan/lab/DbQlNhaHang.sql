	-- Tạo cơ sở dữ liệu QLNHAHANG6
	CREATE DATABASE QLNHAHANG4;
	GO

	-- Sử dụng cơ sở dữ liệu QLNHAHANG6
	USE QLNHAHANG4;
	GO

	-- Tạo bảng nhacungcap trước để sử dụng làm khóa ngoại cho bảng nguyenlieu
	CREATE TABLE nhacungcap (
		id INT PRIMARY KEY IDENTITY(1,1),
		ten NVARCHAR(100) NOT NULL,
		email NVARCHAR(100) UNIQUE NOT NULL,
		phone NVARCHAR(20) NULL,
		diachi NVARCHAR(255) NULL,
		ngaythem DATETIME NOT NULL DEFAULT GETDATE()
	);
	GO

	-- Tạo bảng nguyenlieu với khóa ngoại idnhacungcap
	CREATE TABLE nguyenlieu (
		id INT PRIMARY KEY IDENTITY(1,1),
		ten NVARCHAR(100) NOT NULL,
		mota NVARCHAR(255) NULL,
		daysanxuat DATE NOT NULL,
		hansudung DATE NOT NULL,
		soluong INT NOT NULL,
		ngaythem DATETIME NOT NULL DEFAULT GETDATE(),
		donvi NVARCHAR(50) NOT NULL,
		idnhacungcap INT,
		CONSTRAINT FK_NGUYENLIEU_NHACUNGCAP FOREIGN KEY (idnhacungcap) REFERENCES nhacungcap(id) ON UPDATE CASCADE ON DELETE CASCADE
	);
	GO

	GO

	-- Tạo bảng quyen để sử dụng làm khóa ngoại cho bảng account
	CREATE TABLE quyen (
		id INT PRIMARY KEY IDENTITY(1,1),
		mota NVARCHAR(255),
		email NVARCHAR(100) UNIQUE NOT NULL,
		trangthai bit NOT NULL,	
		ngaythem DATETIME NOT NULL DEFAULT GETDATE()
	);
	GO

	-- Tạo bảng account với khóa ngoại idquyen
		CREATE TABLE account (
			taikhoan NVARCHAR(50) PRIMARY KEY,
			pass VARBINARY(64) NOT NULL,
			thamquyen INT NOT NULL,
			idquyen INT,
			CONSTRAINT FK_ACCOUNT_QUYEN FOREIGN KEY (idquyen) REFERENCES quyen(id) ON UPDATE CASCADE ON DELETE CASCADE
		);
		GO

	-- Tạo bảng ban
	CREATE TABLE ban (
		id INT PRIMARY KEY IDENTITY(1,1),
		tenban NVARCHAR(100) NOT NULL,
		mota NVARCHAR(255) NULL,
		trangthai NVARCHAR(50) NOT NULL,
		ngaytao DATETIME NOT NULL DEFAULT GETDATE()
	);
	GO

	-- Tạo bảng danhmuc với khóa ngoại idmonan
	CREATE TABLE danhmuc (
		id INT PRIMARY KEY IDENTITY(1,1),
		hinhAnh IMAGE NULL,
		tenmonan NVARCHAR(100) NOT NULL,
		gia NVARCHAR(255),
		ngaytao DATETIME NOT NULL DEFAULT GETDATE(),
		idmonan INT,
		idnguyenlieu INT,
		CONSTRAINT FK_NGUYENLIEU_MONAN FOREIGN KEY (idnguyenlieu) REFERENCES nguyenlieu(id) ON UPDATE CASCADE ON DELETE CASCADE,

	);
	GO

	-- Tạo bảng hoadon với khóa ngoại idban và tennguoidung
CREATE TABLE hoadon (
    id INT PRIMARY KEY IDENTITY(1,1),
    idban INT,
    tennguoidung NVARCHAR(50),
    tongtien DECIMAL(18, 2) NOT NULL,
    trangthai NVARCHAR(50) DEFAULT 'Chưa thanh toán' NOT NULL,
    ngaytao DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_HOADON_BAN FOREIGN KEY (idban) REFERENCES ban(id) ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FK_HOADON_ACCOUNT FOREIGN KEY (tennguoidung) REFERENCES account(taikhoan) ON UPDATE CASCADE ON DELETE SET NULL,
   
);
GO


	-- Tạo bảng CTHoaDon với khóa ngoại liên kết đến bảng hoadon và bảng monan
	CREATE TABLE CTHoaDon (
		STT INT PRIMARY KEY IDENTITY(1,1),		
		idmonan INT,
		SoHD INT NULL,
		soLuong INT NULL,	
		giaban INT NULL
		CONSTRAINT FK_CTHOADON_HOADON FOREIGN KEY (SoHD) REFERENCES hoadon(id) ON UPDATE CASCADE ON DELETE CASCADE,
		CONSTRAINT FK_CTHOADON_MONAN FOREIGN KEY (idmonan) REFERENCES danhmuc(id) ON UPDATE CASCADE ON DELETE CASCADE

	);
	GO
	

	INSERT INTO nhacungcap (ten, email, phone, diachi)
VALUES
(N'Nhà Cung Cấp 1', 'nhacungcap1@example.com', '0123456789', 'Địa chỉ 1'),
(N'Nhà Cung Cấp 2', 'nhacungcap2@example.com', '0123456790', 'Địa chỉ 2'),
(N'Nhà Cung Cấp 3', 'nhacungcap3@example.com', '0123456791', 'Địa chỉ 3'),
(N'Nhà Cung Cấp 4', 'nhacungcap4@example.com', '0123456792', 'Địa chỉ 4'),
(N'Nhà Cung Cấp 5', 'nhacungcap5@example.com', '0123456793', 'Địa chỉ 5'),
(N'Nhà Cung Cấp 6', 'nhacungcap6@example.com', '0123456794', 'Địa chỉ 6'),
(N'Nhà Cung Cấp 7', 'nhacungcap7@example.com', '0123456795', 'Địa chỉ 7'),
(N'Nhà Cung Cấp 8', 'nhacungcap8@example.com', '0123456796', 'Địa chỉ 8'),
(N'Nhà Cung Cấp 9', 'nhacungcap9@example.com', '0123456797', 'Địa chỉ 9'),
(N'Nhà Cung Cấp 10', 'nhacungcap10@example.com', '0123456798', 'Địa chỉ 10'),
(N'Nhà Cung Cấp 11', 'nhacungcap11@example.com', '0123456799', 'Địa chỉ 11'),
(N'Nhà Cung Cấp 12', 'nhacungcap12@example.com', '0123456800', 'Địa chỉ 12'),
(N'Nhà Cung Cấp 13', 'nhacungcap13@example.com', '0123456801', 'Địa chỉ 13'),
(N'Nhà Cung Cấp 14', 'nhacungcap14@example.com', '0123456802', 'Địa chỉ 14'),
(N'Nhà Cung Cấp 15', 'nhacungcap15@example.com', '0123456803', 'Địa chỉ 15'),
(N'Nhà Cung Cấp 16', 'nhacungcap16@example.com', '0123456804', 'Địa chỉ 16'),
(N'Nhà Cung Cấp 17', 'nhacungcap17@example.com', '0123456805', 'Địa chỉ 17'),
(N'Nhà Cung Cấp 18', 'nhacungcap18@example.com', '0123456806', 'Địa chỉ 18'),
(N'Nhà Cung Cấp 19', 'nhacungcap19@example.com', '0123456807', 'Địa chỉ 19'),
(N'Nhà Cung Cấp 20', 'nhacungcap20@example.com', '0123456808', 'Địa chỉ 20');

INSERT INTO nguyenlieu (ten, mota, daysanxuat, hansudung, soluong, donvi, idnhacungcap)
VALUES
(N'Thịt Bò', N'Thịt bò tươi', '2024-07-01', '2024-12-31', 100, 'kg', 20),
('NThịt Gà', N'Thịt gà tươi', '2024-07-01', '2024-12-31', 200, 'kg', 1),
(N'Cá Hồi', N'Cá hồi tươi', '2024-07-01', '2024-12-31', 150, 'kg', 2),
(N'Cá Basa', N'Cá basa tươi', '2024-07-01', '2024-12-31', 120, 'kg', 3),
(N'Tôm', N'Tôm tươi', '2024-07-01', '2024-12-31', 180, 'kg', 4),
(N'Mực', N'Mực tươi', '2024-07-01', '2024-12-31', 90, 'kg', 5),
(N'Nấm Hương', N'Nấm hương khô', '2024-07-01', '2025-07-01', 50, 'kg', 6),
(N'Hành Tây', N'Hành tây tươi', '2024-07-01', '2024-12-31', 300, 'kg', 7),
(N'Cà Chua', N'Cà chua tươi', '2024-07-01', '2024-12-31', 250, 'kg', 8),
(N'Ớt', N'Ớt tươi', '2024-07-01', '2024-12-31', 100, 'kg', 9),
(N'Gừng', N'Gừng tươi', '2024-07-01', '2024-12-31', 70, 'kg', 10),
(N'Tỏi', N'Tỏi tươi', '2024-07-01', '2024-12-31', 80, 'kg', 11),
(N'Rau Xà Lách', N'Rau xà lách tươi', '2024-07-01', '2024-12-31', 200, 'kg', 12),
(N'Rau Mùi', N'Rau mùi tươi', '2024-07-01', '2024-12-31', 150, 'kg', 13),
(N'Bí Đao', 'NBí đao tươi', '2024-07-01', '2024-12-31', 120, 'kg', 14),
(N'Su Su', N'Su su tươi', '2024-07-01', '2024-12-31', 130, 'kg', 15),
(N'Củ Cải', N'Củ cải tươi', '2024-07-01', '2024-12-31', 90, 'kg', 16),
(N'Khoai Tây', N'Khoai tây tươi', '2024-07-01', '2024-12-31', 160, 'kg', 17),
(N'Đậu Hà Lan', N'Đậu hà lan tươi', '2024-07-01', '2024-12-31', 110, 'kg', 18),
(N'Ngô', N'Ngô tươi', '2024-07-01', '2024-12-31', 140, 'kg', 19);


INSERT INTO quyen (mota, email, trangthai)
VALUES
('admin1', 'quyen1f@example.com',1),
(N'nhân viên', 'quyen2@exdample.com', 1),
(N'nhân viên', 'quyen3@exfample.com', 1),
(N'nhân viên', 'quyen4@exdample.com',1),
(N'nhân viên ','quyen5@exafmple.com', 0);
GO

INSERT INTO account (taikhoan, pass,  thamquyen, idquyen)
VALUES
('admin1', HASHBYTES('MD5', '123456'), 2, 1),
('user2', HASHBYTES('MD5', '123456'),  1, 2),
('user3', HASHBYTES('MD5', 'password3'),  1, 3),
('user14', HASHBYTES('MD5', 'password4'),  1, 4),
('user1', HASHBYTES('MD5', 'password5'),  1, 5);
GO

INSERT INTO account (taikhoan, pass,  thamquyen, idquyen)
VALUES
('user14', HASHBYTES('MD5', 'password4'),  1, 14),
('user1', HASHBYTES('MD5', 'password5'),  1, 13);
GO
