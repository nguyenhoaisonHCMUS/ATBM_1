--RBAC
--Xoa role
drop role role_BanGiamDoc;
drop role role_TruongDeAn;
drop role role_NhanSu;
drop role role_TaiChinh;
drop role role_TruongPhong;
drop role role_QLTrucTiep;
drop role role_NhanVien; 

--Tao role

create role role_BanGiamDoc;
create role role_TruongDeAn;
create role role_NhanSu;
create role role_TaiChinh;
create role role_TruongPhong;
create role role_QLTrucTiep;
create role role_NhanVien; 
--create role
-- VPD function:
CREATE OR REPLACE function Select_NHANVIEN(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
id VARCHAR2(10);
Begin
    user := SYS_CONTEXT('USERENV', 'SESSION_USER');
    if (user like 'NV%' or user like 'TDA%' ) then
        return 'USERNAME = ''' || lower(user) || '''';
    elsif (user like 'TP%') then
        id := substr(user,3);
        return 'PHG = (SELECT MAPB FROM AD.PHONGBAN WHERE TRPHG = '|| id ||')';
    elsif (user like 'QLTT%') then
        id := substr(user,5);
        return 'username = '''|| lower(user) ||''' or manql = ' || id;
    elsif (user = 'AD' or user like 'TC%' or user like 'NS%' or user like 'GD%' or user = 'LBACSYS') then
        return '1=1';
    end if;
End;
/
CREATE OR REPLACE function Select_PHANCONG(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
id VARCHAR2(10);
Begin
    return 'MANV IN (SELECT MANV FROM AD.NHANVIEN)';
End;
/
CREATE OR REPLACE function Update_NHANVIEN_Info(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
Begin
    user := SYS_CONTEXT('USERENV', 'SESSION_USER');
    if (user = 'AD') then 
     return '1=1';
    else
        return 'USERNAME = ''' || lower(user) || '''';
    end if;
End;
/
CREATE OR REPLACE function Select_NHANVIEN_LUONG(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
Begin
    user := SYS_CONTEXT('USERENV', 'SESSION_USER');
    if (user = 'AD' or user like 'TC%' or user like 'BGD%') then 
     return '1=1';
    else
        return 'USERNAME = ''' || lower(user) || '''';
    end if;
End;
/
-- CS1:
-- Grant quyen:
GRANT SELECT ON AD.NHANVIEN TO role_NhanVien;
GRANT SELECT ON AD.PHANCONG TO role_NhanVien;
GRANT UPDATE (NGAYSINH, DIACHI, SODT) ON AD.NHANVIEN TO role_NhanVien;
GRANT SELECT ON AD.PHONGBAN TO role_NhanVien;
GRANT SELECT ON AD.DEAN TO role_NhanVien;
GRANT SELECT ON AD.THONGBAO TO role_NhanVien;

-- Xoa policy select tren NHANVIEN:
begin
    DBMS_RLS.DROP_POLICY(object_schema => 'AD',
        object_name => 'NHANVIEN', 
        policy_name => 'Select_NHANVIEN');
end;
/
begin
    DBMS_RLS.DROP_POLICY(object_schema => 'AD',
        object_name => 'PHANCONG', 
        policy_name => 'Select_PHANCONG');
end;
/
begin
    DBMS_RLS.DROP_POLICY(object_schema => 'AD',
        object_name => 'NHANVIEN', 
        policy_name => 'update_NHANVIEN_Info');
end;
/
begin
    DBMS_RLS.DROP_POLICY(object_schema => 'AD',
        object_name => 'NHANVIEN', 
        policy_name => 'Select_NHANVIEN_LUONG');
end;
/
-- Them policy select tren NHANVIEN:
begin
    DBMS_RLS.ADD_POLICY(
        object_schema => 'AD', 
        object_name => 'NHANVIEN', 
        policy_name => 'Select_NHANVIEN', 
        policy_function => 'Select_NHANVIEN',
        statement_types => 'select',
        update_check => TRUE);
end;
/
begin
    DBMS_RLS.ADD_POLICY(
        object_schema => 'AD', 
        object_name => 'PHANCONG', 
        policy_name => 'Select_PHANCONG', 
        policy_function => 'Select_PHANCONG',
        statement_types => 'select');
end;
/
begin
    DBMS_RLS.ADD_POLICY(
        object_schema => 'AD', 
        object_name => 'NHANVIEN', 
        policy_name => 'Update_NHANVIEN_Info', 
        policy_function => 'Update_NHANVIEN_Info',
        statement_types => 'update',
        sec_relevant_cols => 'NGAYSINH, DIACHI, SODT',
        update_check => TRUE);
end;
/
begin
    DBMS_RLS.ADD_POLICY(
        object_schema => 'AD', 
        object_name => 'NHANVIEN', 
        policy_name => 'Select_NHANVIEN_LUONG', 
        policy_function => 'Select_NHANVIEN_LUONG',
        statement_types => 'select',
        sec_relevant_cols => 'LUONG, PHUCAP',
        sec_relevant_cols_opt => DBMS_RLS.ALL_ROWS,
        update_check => TRUE);
end;
/
-- CS2:
-- Grant quyen:
GRANT SELECT ON AD.PHONGBAN TO role_QLTrucTiep;
GRANT SELECT ON AD.DEAN TO role_QLTrucTiep;
GRANT SELECT ON AD.NHANVIEN TO role_QLTrucTiep;
GRANT SELECT ON AD.PHANCONG TO role_QLTrucTiep;
GRANT SELECT ON AD.THONGBAO TO role_QLTrucTiep;
GRANT UPDATE(NGAYSINH, DIACHI, SODT) ON AD.NHANVIEN TO role_QLTrucTiep;


-- CS3:
GRANT SELECT ON AD.PHONGBAN TO role_TruongPhong;
GRANT SELECT ON AD.DEAN TO role_TruongPhong;
GRANT SELECT ON AD.NHANVIEN TO role_TruongPhong;
GRANT SELECT ON AD.PHANCONG TO role_TruongPhong;
GRANT UPDATE ON AD.PHANCONG TO role_TruongPhong;
GRANT SELECT ON AD.THONGBAO TO role_TruongPhong;
GRANT UPDATE(NGAYSINH, DIACHI, SODT) ON AD.NHANVIEN TO role_TruongPhong;
/
-- Xoa Policy:
begin
    DBMS_RLS.DROP_POLICY(object_schema => 'AD',
        object_name => 'PHANCONG', 
        policy_name => 'Update_PHANCONG');
end;
/
-- Them Policy:
begin
    DBMS_RLS.ADD_POLICY(
        object_schema => 'AD', 
        object_name => 'PHANCONG', 
        policy_name => 'Update_PHANCONG', 
        policy_function => 'Select_PHANCONG',
        statement_types => 'update',
        update_check => TRUE);
end;
/
-- CS4:
GRANT SELECT ON AD.PHONGBAN TO role_TaiChinh;
GRANT SELECT ON AD.DEAN TO role_TaiChinh;
GRANT SELECT ON AD.NHANVIEN TO role_TaiChinh;
GRANT SELECT ON AD.PHANCONG TO role_TaiChinh;
GRANT SELECT ON AD.THONGBAO TO role_TaiChinh;
GRANT UPDATE(NGAYSINH, DIACHI, SODT, LUONG, PHUCAP) ON AD.NHANVIEN TO role_TruongPhong;
/
-- VPD function:
CREATE OR REPLACE function Update_NHANVIEN_LUONG(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
Begin
    user := SYS_CONTEXT('USERENV', 'SESSION_USER');
    if (user = 'AD' or user like 'TC%') then 
     return '1=1';
    else
     return '1=0';
    end if;
End;
/
-- Xoa policy:
begin
    DBMS_RLS.DROP_POLICY(object_schema => 'AD',
        object_name => 'NHANVIEN', 
        policy_name => 'UPDATE_NHANVIEN_LUONG');
end;
/
-- Them policy:
begin
    DBMS_RLS.ADD_POLICY(
        object_schema => 'AD', 
        object_name => 'NHANVIEN', 
        policy_name => 'Update_NHANVIEN_LUONG', 
        policy_function => 'Update_NHANVIEN_LUONG',
        statement_types => 'update',
        sec_relevant_cols => 'LUONG, PHUCAP',
        update_check => TRUE);
end;
/
-- CS5:
GRANT INSERT(TENNV, PHAI, NGAYSINH, DIACHI,SODT,VAITRO,MANQL,PHG,USERNAME) ON AD.NHANVIEN TO role_NhanSu;
GRANT SELECT ON AD.NHANVIEN TO role_NhanSu;
GRANT SELECT ON AD.PHONGBAN TO role_NhanSu;
GRANT SELECT ON AD.DEAN TO role_NhanSu;
GRANT UPDATE ON AD.THONGBAO TO role_TruongDeAn;


-- CS6:
GRANT SELECT ON AD.PHONGBAN TO role_TruongDeAn;
GRANT SELECT ON AD.DEAN TO role_TruongDeAn;
GRANT SELECT ON AD.NHANVIEN TO role_TruongDeAn;
GRANT SELECT ON AD.PHANCONG TO role_TruongDeAn;
GRANT UPDATE(NGAYSINH, DIACHI, SODT) ON AD.NHANVIEN TO role_TruongDeAn;
GRANT UPDATE ON AD.DEAN TO role_TruongDeAn;
GRANT UPDATE ON AD.THONGBAO TO role_TruongDeAn;


--CS7;BanGiamDoc
GRANT SELECT ON AD.PHONGBAN TO role_BanGiamDoc;
GRANT SELECT ON AD.DEAN TO role_BanGiamDoc;
GRANT SELECT ON AD.NHANVIEN TO role_BanGiamDoc;
GRANT SELECT ON AD.PHANCONG TO role_BanGiamDoc;
GRANT SELECT,UPDATE,INSERT,DELETE ON AD.THONGBAO TO role_BanGiamDoc;

--create user bgd1 identified by 123;
--grant connect to bgd1;
--grant role_BanGiamDoc to bgd1;
grant execute on proc_update_NhanVien to role_NhanVien;
GRANT EXECUTE ON proc_update_PhongBan TO role_NhanSu;
GRANT EXECUTE ON proc_update_DeAn TO role_TruongDeAn;
GRANT EXECUTE ON proc_insert_DeAn TO role_TruongDeAn;
grant execute on proc_send_notification to role_BanGiamDoc, role_TruongPhong;


--tao view xem tren NHANVIEN
create or replace view xem_NHANVIEN as 
select MANV, TENNV,PHAI,NGAYSINH,DIACHI,SODT,fun_TRAKETQUA(LUONG, MANV) as LUONG ,fun_TRAKETQUA(PHUCAP, MANV) as PHUCAP ,VAITRO,MANQL,PHG,USERNAME,LINHVUC,CHINHANH 
from AD.NHANVIEN;

grant select on  AD.xem_NHANVIEN to role_NhanSu, role_NhanVien, role_BanGiamDoc, role_TaiChinh, role_TruongPhong, role_TruongDeAn, role_QLTrucTiep;

grant execute on SP_XEPHANGNHANVIEN to role_TaiChinh;
grant execute on fun_TRAKETQUA to AD, role_NhanSu, role_NhanVien, role_BanGiamDoc, role_TaiChinh, role_TruongPhong, role_TruongDeAn, role_QLTrucTiep;
grant execute on fun_TAOKETQUA to role_NhanSu;
grant execute on sp_ThemNhanVien_NhanSu to role_NhanSu;


grant execute on TG_CAPNHATXEPHANG to role_TaiChinh;
grant all PRIVILEGES on  XEPHANG to role_NhanSu, role_NhanVien, role_BanGiamDoc, role_TaiChinh, role_TruongPhong, role_TruongDeAn, role_QLTrucTiep;

commit 







select * from nhanvien where manv=43;
update nhanvien set username='bgd43'where manv=43;