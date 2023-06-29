-- a. Nh?ng ng??i ?ã c?p nh?t tr??ng THOIGIAN trong quan h? PHANCONG
-- xoa policy
begin
    DBMS_FGA.DROP_POLICY(
        object_schema => 'AD', 
        object_name => 'PHANCONG', 
        policy_name => 'audit_update_PhanCong');
end;
/
-- them policy
begin
    DBMS_FGA.ADD_POLICY(
        object_schema => 'AD', 
        object_name => 'PHANCONG', 
        policy_name => 'audit_update_PhanCong', 
        audit_column => 'THOIGIAN',  
        enable => TRUE,
        statement_types => 'UPDATE',
        audit_trail => DBMS_FGA.DB + DBMS_FGA.EXTENDED);
end;
/

-- b. Nh?ng ng??i ?ã ??c trên tr??ng LUONG và PHUCAP c?a ng??i khác. 
-- xoa policy
begin
    DBMS_FGA.DROP_POLICY(
        object_schema => 'AD', 
        object_name => 'NHANVIEN', 
        policy_name => 'audit_select_Luong_PhuCap_NhanVien');
end;
/
-- them policy
begin
    DBMS_FGA.ADD_POLICY(
        object_schema => 'AD', 
        object_name => 'NHANVIEN', 
        policy_name => 'audit_select_Luong_PhuCap_NhanVien', 
        audit_column => 'LUONG, PHUCAP', 
        audit_condition => 'VaiTro=''TaiChinh'' or VaiTro=''BanGiamDoc''',
        enable => TRUE,
        statement_types => 'SELECT',
        audit_trail => DBMS_FGA.DB + DBMS_FGA.EXTENDED);
end;
/
-- c. M?t ng??i không thu?c vai trò “Tài chính�? nh?ng ?ã c?p nh?t thành công trên tr??ng LUONG và PHUCAP
-- xoa policy
begin
    DBMS_FGA.DROP_POLICY(
        object_schema => 'AD', 
        object_name => 'NHANVIEN', 
        policy_name => 'audit_update_Luong');
end;
/
-- them policy
begin
    DBMS_FGA.ADD_POLICY(
        object_schema => 'AD', 
        object_name => 'NHANVIEN', 
        policy_name => 'audit_update_Luong', 
        audit_condition => 'VAITRO != ''TaiChinh''', 
        audit_column => 'LUONG, PHUCAP', 
        enable => TRUE,
        statement_types => 'UPDATE',
        audit_trail => DBMS_FGA.DB + DBMS_FGA.EXTENDED);
end;
/
-- test
SELECT DBUID, LSQLTEXT, NTIMESTAMP# FROM SYS.FGA_LOG$ order by NTIMESTAMP# desc;
/
-- d. Ki?m tra nh?t ký h? th?ng
alter system set audit_trail = DB,EXTENDED scope = spfile;
shutdown immediate;
startup;
/
-- Theo doi hanh vi cua cac user tren tat ca cac table
AUDIT ALL ON ad.DEAN BY ACCESS;
AUDIT ALL ON ad.NHANVIEN BY ACCESS;
AUDIT ALL ON ad.PHANCONG BY ACCESS;
AUDIT ALL ON ad.PHONGBAN BY ACCESS;
AUDIT ALL ON ad.THONGBAO BY ACCESS;
-- Theo doi cac hanh vi thanh cong
AUDIT ALL WHENEVER SUCCESSFUL;
-- Theo doi cac hanh vi khong thanh cong
AUDIT ALL WHENEVER NOT SUCCESSFUL;
/
-- test
select username, EXTENDED_TIMESTAMP ,obj_name, action_name, sql_text from dba_audit_trail order by EXTENDED_TIMESTAMP desc;

/


--TRUNCATE TABLE aud$;
--TRUNCATE TABLE fga_log$;
