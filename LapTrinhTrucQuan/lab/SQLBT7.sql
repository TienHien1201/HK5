create database LTTQ_Lab4_BT7_S4

create table Khoa
( 
	MaKhoa nchar(6) primary key,
	TenKhoa nchar(30)
)
create table SinhVien
(
	MaSo int primary key,
	HoTen nvarchar(50),
	NgaySinh date,
	GioiTinh bit,
	DiaChi nvarchar(50),
	DienThoai varchar(12),
	MaKhoa nchar(6),
	foreign key(MaKhoa) references Khoa(MaKhoa)
)
create table MonHoc
(
	MaMH nchar(6) primary key,
	TenMH nchar(50),
	SoTiet int,
)
create table KetQua
(
	MaSo int,
	MaMH nchar(6),
	Diem float,
	primary key(MaSo,MaMH),
	foreign key(MaSo) references SinhVien(MaSo),
	foreign key(MaMH) references MonHoc(MaMH)
)

insert into Khoa values
('CNTT',N'Công nghệ thông tin'),
('CNTP',N'Công nghệ thực phẩm'),
('QTKD',N'Quản trị kinh doanh'),
('DDT',N'Điện-điện tử');