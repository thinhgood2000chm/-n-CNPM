create database QLCHDC
use QLCHDC
create table taiKhoan(
	stt int IDENTITY(1,1) ,
	TenNV nvarchar(50),
	Chuc_vu varchar(50),
	tenTK varchar(100) not null,
	matkhau varchar(100),
	primary key (tenTK,stt),
	
)
insert into taikhoan values('Nguyen Van Dat','admin','Datamdmin','123456')
create table nhanVien(
	Ma_nv int IDENTITY(1,1) PRIMARY KEY,
	Ho_ten nvarchar(50),
	Diachi nvarchar(50),
	Gioi_tinh bit,
	Chuc_vu varchar(50),
	Ngay_sinh datetime,
)
 
insert into nhanVien values('Nguyen Anh Tung','742 Le Van Luong','1','Nhan vien kho','10-24-1992')
insert into nhanVien values('Bui Cam Tu','20 Doi Can','0','Nhan vien ban hang','11-04-1991')

create table khachHang(
	Ma_kh int IDENTITY(1,1) not null, 
	Ho_ten nvarchar(50),
	SDT char,
	Gioi_tinh bit,
	Lan_mua int,
	primary key (Ma_kh)
)

insert into khachHang values('Bui Manh Dung',548118112,'1',2)
insert into khachHang values('Nguyen Minh Nhat',324237902,'1',5)



create table doChoi(
	Ma_sp int IDENTITY(1,1) not null,
	Ten_sp nvarchar(50),
	Nsx nvarchar(50),
	Don_gia int,
	Loai_do_choi nvarchar(50),
	primary key(Ma_sp)
)

insert into doChoi values('Xe dieu khien tu xa','Thanh Hoa',500000,'tren 15 tuoi')
insert into doChoi values('Vit cao su','Ben Tre',7000,'tu 3 den 6 tuoi') 



create table thanhToan(
	Ma_kh int not null, 
	Ma_sp int ,
	Ho_ten nvarchar(50),
	SDT char,
	So_luong int,
	Gia_tien int,
	Tien_khach_tra int,
	Primary key(Ma_kh,Ma_sp),
	foreign key (Ma_kh) references khachHang(Ma_kh),
	foreign key (Ma_sp) references doChoi(Ma_sp)
)


drop table khachHang
select * from nhanVien