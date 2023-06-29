show con_name;
alter session set container = QLDTPDB;

--Tao bang 

--2.1. xoa bang
drop table "AD"."PHONGBAN" cascade constraints;
drop table "AD"."DEAN" cascade constraints;
drop table "AD"."NHANVIEN" cascade constraints;
drop table "AD"."PHANCONG" cascade constraints;
drop table "AD"."THONGBAO" cascade constraints;

/
--2.2. Tao bang
create table PHONGBAN(
    MAPB number(5) GENERATED ALWAYS AS IDENTITY (START WITH 1 INCREMENT BY 1) NOT NULL,
    TENPB varchar2(50),
    TRPHG number(5),
    primary key (MAPB)
    );
/ 
create table DEAN(
    MADA number(5) GENERATED ALWAYS AS IDENTITY (START WITH 1 INCREMENT BY 1) NOT NULL,
    TENDA varchar2(50),
    NGAYBD date,
    PHONG number(5),
    primary key (MADA)
    );
/
create table NHANVIEN(
    MANV number(5) GENERATED ALWAYS AS IDENTITY (START WITH 1 INCREMENT BY 1) NOT NULL,
    TENNV varchar2(50),
    PHAI varchar2(10),
    NGAYSINH date,
    DIACHI varchar2(100),
    SODT varchar(15),
    --LUONG number(9,2),
    --PHUCAP number(9,2),
    LUONG varchar2(255),
    PHUCAP varchar2(255),
    VAITRO varchar2(50),
    MANQL number(5),
    PHG number(5),
    USERNAME varchar2(50),
    LINHVUC NVARCHAR2(100),
    CHINHANH NVARCHAR2(100),
    primary key (MANV)
    );
/  
create table PHANCONG(
    MANV number(5),
    MADA number(5),
    THOIGIAN date,
    primary key(MANV, MADA)
    );
/
alter table NHANVIEN 
add constraint FK_MANQL_NHANVIEN
foreign key (MANQL) references NHANVIEN(MANV);
/ 
alter table NHANVIEN 
add constraint FK_PHG_NHANVIEN
foreign key (PHG) references PHONGBAN(MAPB);
/
alter table PHONGBAN 
add constraint FK_TRPHG_PHONGBAN
foreign key (TRPHG) references NHANVIEN(MANV);
/   
alter table DEAN 
add constraint FK_PHONG_DEAN
foreign key (PHONG) references PHONGBAN(MAPB);
/    
alter table PHANCONG 
add constraint FK_MANV_PHANCONG
foreign key (MANV) references NHANVIEN(MANV);
/
alter table PHANCONG 
add constraint FK_MADA_PHANCONG
foreign key (MADA) references DEAN(MADA);
/
DROP TABLE THONGBAO;

create table THONGBAO(
    MATB number(5) GENERATED ALWAYS AS IDENTITY (START WITH 1 INCREMENT BY 1) NOT NULL,
    NOIDUNG varchar2(255),
    THOIGIAN date,
    VAITRO varchar2(50),
    LINHVUC varchar2(50),
    CHINHANH varchar2(50)
);
/
--Tao bang luu khoa
drop table "AD"."XEPHANG" cascade constraints;

create table XEPHANG(
    MA number(5),
    DIEM RAW(128),
    THANHTICH number(5),
    primary key (MA)
    )
/

/
--Toa khoa
CREATE OR REPLACE PROCEDURE SP_XEPHANGNHANVIEN(
    ID NUMBER,
    DIEM VARCHAR2,
    ketqua OUT RAW)
IS
    TEMP VARCHAR2(100);
BEGIN
    ketqua := DBMS_CRYPTO.ENCRYPT(
        src => UTL_I18N.STRING_TO_RAW(DIEM, 'AL32UTF8'),
        typ => SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5,
        key => UTL_I18N.STRING_TO_RAW('ATBM', 'AL32UTF8')
    );
    
    DECLARE
        cnt NUMBER;
    BEGIN
        SELECT COUNT(*) INTO cnt FROM XEPHANG WHERE MA = ID;
        
        IF cnt > 0 THEN
            UPDATE XEPHANG SET DIEM = ketqua WHERE MA = ID;
        ELSE
            INSERT INTO XEPHANG VALUES (ID, ketqua, ID * 3 - 2);
        END IF;
    END;
END;
/
--Ma hoa
DROP FUNCTION fun_TAOKETQUA;

CREATE OR REPLACE FUNCTION fun_TAOKETQUA(
    dauvao VARCHAR2,
    ID RAW
) RETURN varchar2
IS
    ketqua RAW(2000);
    ma raw(2000);
BEGIN
    ketqua := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW(TO_CHAR(dauvao), 'AL32UTF8'),
             typ => SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5,
             key => ID
         );
    RETURN TO_CHAR(RAWTOHEX(ketqua));
END;
/

--Giai ma
drop function fun_TRAKETQUA;

CREATE OR REPLACE FUNCTION fun_TRAKETQUA(nguon VARCHAR2, ma1 number)
   RETURN VARCHAR2
IS
   ketqua RAW(2000);
   ID raw(2000);
BEGIN
    select DIEM into ID from XEPHANG where MA = ma1;
    ketqua :=  DBMS_CRYPTO.DECRYPT(
    src => HEXTORAW(nguon),
    typ => SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5,
    key => ID
  );
  return TO_NCHAR(UTL_I18N.RAW_TO_CHAR (ketqua, 'AL32UTF8'));
END;
