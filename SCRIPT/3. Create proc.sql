CREATE OR REPLACE PROCEDURE sp_Create_Role(role_name IN VARCHAR2) 
IS
BEGIN
    EXECUTE IMMEDIATE 'alter session set "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE 'CREATE ROLE ' || role_name;
    DBMS_OUTPUT.PUT_LINE('Role ' || role_name || ' tao thanh cong');
    EXCEPTION
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('Loi: ' || SQLERRM);
END;
/

CREATE OR REPLACE PROCEDURE sp_Drop_Role(role_name IN VARCHAR2) 
IS
BEGIN
    EXECUTE IMMEDIATE 'alter session set "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE 'DROP ROLE ' || role_name;
    DBMS_OUTPUT.PUT_LINE('Role ' || role_name || ' xoa thanh cong');
    EXCEPTION
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('Loi: ' || SQLERRM);
END;
/
CREATE OR REPLACE PROCEDURE sp_Grant_Role_TO_User
(
username in varchar2,
rolename in varchar2
)is
 begin
    EXECUTE IMMEDIATE 'alter session set "_ORACLE_SCRIPT" = TRUE';
    execute immediate 'grant ' || rolename || ' to ' || username;
    
    EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Xay ra loi' || ': ' || SQLERRM);
 end;

/
-- Cap quyen cho user, role

CREATE OR REPLACE PROCEDURE sp_Grant_Permission_User_Role(
  p_permission IN VARCHAR2,
  p_object IN VARCHAR2,
  p_grantee IN VARCHAR2,
  p_with_grant_option IN BOOLEAN DEFAULT FALSE
) AS
BEGIN
  EXECUTE IMMEDIATE 'alter session set "_ORACLE_SCRIPT" = TRUE';
  IF (p_permission IN ('SELECT', 'UPDATE', 'INSERT', 'DELETE')) THEN
    IF (p_with_grant_option =TRUE)  THEN
        EXECUTE IMMEDIATE 'GRANT ' || p_permission || ' ON ' || p_object || ' TO ' || p_grantee || ' WITH GRANT OPTION';
        DBMS_OUTPUT.PUT_LINE('Cap quyen thanh cong' );
    ELSE
        EXECUTE IMMEDIATE 'GRANT ' || p_permission || ' ON ' || p_object || ' TO ' || p_grantee;
        DBMS_OUTPUT.PUT_LINE('Cap quyen thanh cong' );
    END IF;
  END IF;
  EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Xay ra loi' || ': ' || SQLERRM);
END;
/

--thu h?i quy?n c?a user,role

CREATE OR REPLACE PROCEDURE sp_Revoke_Permission_User_Role(
  p_permission IN VARCHAR2,
  p_object IN VARCHAR2,
  p_grantee IN VARCHAR2
) AS
BEGIN
  EXECUTE IMMEDIATE 'alter session set "_ORACLE_SCRIPT" = TRUE';
  IF p_permission IN ('SELECT', 'UPDATE', 'INSERT', 'DELETE') THEN
    EXECUTE IMMEDIATE 'REVOKE ' || p_permission || ' ON ' || p_object || ' FROM ' || p_grantee;
    DBMS_OUTPUT.PUT_LINE('Thu hoi quyen thanh cong' );
  END IF;
END;
/

---
CREATE OR REPLACE PROCEDURE sp_Revoke_Role_from_User(
  rolename in varchar,
  username in varchar
) AS
BEGIN
    EXECUTE IMMEDIATE 'alter session set "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE 'REVOKE '|| rolename || ' FROM ' || username;
    
    EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Xay ra loi' || ': ' || SQLERRM);
END;

/
-- update my infor
CREATE OR REPLACE PROCEDURE proc_update_NhanVien (   
p_manv IN NHANVIEN.MANV%TYPE,  
p_ngaysinh IN NHANVIEN.NGAYSINH%TYPE,  
p_diachi IN NHANVIEN.DIACHI%TYPE,  
p_sodt IN NHANVIEN.SODT%TYPE)  
IS  
BEGIN  
    UPDATE AD.NHANVIEN 
    SET NGAYSINH = to_date(p_ngaysinh, 'DD/MM/YYYY'),
        DIACHI = p_diachi,
        SODT = p_sodt
    WHERE MANV=p_manv;  
    COMMIT;
	EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Xay ra loi' || ': ' || SQLERRM);
END;  

/
grant execute on ad.proc_update_NhanVien to role_BanGiamDoc,role_TruongDeAn,role_NhanSu,role_TaiChinh,role_TruongPhong,role_QLTrucTiep,role_NhanVien; 

/  
-- insert assignment
CREATE OR REPLACE PROCEDURE proc_insert_PhanCong (  
p_manv PHANCONG.MANV%TYPE,  
p_mada PHANCONG.MADA%TYPE,  
p_thoigian PHANCONG.THOIGIAN%TYPE)    
IS  
BEGIN  
    INSERT INTO PHANCONG (MANV, MADA, THOIGIAN)  
    VALUES (p_manv, p_mada, p_thoigian);  
    COMMIT;  
	EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Xay ra loi' || ': ' || SQLERRM);
END;  
/ 
-- update assignment
CREATE OR REPLACE PROCEDURE proc_update_PhanCong (   
p_manv PHANCONG.MANV%TYPE,  
p_mada PHANCONG.MADA%TYPE,  
p_thoigian PHANCONG.THOIGIAN%TYPE)  
IS  
BEGIN  
    UPDATE AD.PHANCONG 
    SET THOIGIAN = to_date(p_thoigian, 'DD/MM/YYYY'),
        MADA = p_mada
    WHERE MANV=p_manv;  
    COMMIT;
	EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Xay ra loi' || ': ' || SQLERRM);
END;
/
-- delete phancong 
CREATE OR REPLACE PROCEDURE proc_delete_PhanCong (   
p_manv PHANCONG.MANV%TYPE,  
p_mada PHANCONG.MADA%TYPE)  
IS  
BEGIN  
    DELETE FROM AD.PHANCONG WHERE MANV=p_manv and MADA=p_mada;  
	EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Xay ra loi' || ': ' || SQLERRM);
END;  
/ 


-------------------------------------------------------------
--NHANSU - them user
CREATE OR REPLACE PROCEDURE sp_ThemNhanVien_NhanSu(
    P_TENNV     IN  VARCHAR2,
    P_PHAI      IN  VARCHAR2,
    P_NGAYSINH  IN  DATE,
    P_DIACHI    IN  VARCHAR2,
    P_SODT      IN  VARCHAR2,
    P_VAITRO    IN  VARCHAR2,
    P_PHG       IN  NUMBER,
    P_LINHVUC   IN  VARCHAR2,
    P_CHINHANH  IN  VARCHAR2
)
AS
    v_count NUMBER;
    V_MANV NUMBER;
    V_USERNAME NVARCHAR2(100);
    V_MANQL NUMBER;
    V_LUONG  NVARCHAR2(100);
    V_PHUCAP  NVARCHAR2(100);
    V_MAX NUMBER;
    V_ID RAW(2000);
BEGIN 
    SELECT COUNT(*) INTO v_count FROM NHANVIEN WHERE TENNV = P_TENNV AND SODT = P_SODT AND LINHVUC = P_LINHVUC;
    IF (v_count < 1) THEN 
        select max (manv) into V_MAX from NHANVIEN;
        if (V_MAX is null)then V_MAX :=0; end if;
        begin SP_XEPHANGNHANVIEN(V_MAX+1 , V_MAX, V_ID); end;
        V_LUONG := fun_TAOKETQUA('0',V_ID);
        V_PHUCAP := fun_TAOKETQUA('0',V_ID);
        INSERT INTO NHANVIEN(TENNV, PHAI, NGAYSINH, DIACHI, SODT,LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME, LINHVUC, CHINHANH)
        VALUES (P_TENNV, P_PHAI, P_NGAYSINH, P_DIACHI, P_SODT, V_LUONG, V_PHUCAP, P_VAITRO, NULL, P_PHG, NULL, P_LINHVUC, P_CHINHANH);
        
        SELECT MANV INTO V_MANV FROM NHANVIEN WHERE TENNV = P_TENNV AND SODT = P_SODT;
        SELECT TRPHG INTO V_MANQL FROM PHONGBAN WHERE MAPB = P_PHG;
        
        -- Update MANQL
        UPDATE NHANVIEN 
        SET MANQL = V_MANQL
        WHERE MANV = V_MANV;
        
        -- Update USERNAME
        IF P_VAITRO = 'NhanVien' THEN
            V_USERNAME := 'nv' || V_MANV;
        ELSIF P_VAITRO = 'TruongDeAn' THEN
            V_USERNAME := 'tda' || V_MANV;
        ELSIF P_VAITRO = 'NhanSu' THEN
            V_USERNAME := 'ns' || V_MANV;
        ELSIF P_VAITRO = 'TruongPhong' THEN
            V_USERNAME := 'tp' || V_MANV;
        ELSIF P_VAITRO = 'BanGiamDoc' THEN
            V_USERNAME := 'bgd' || V_MANV;
        ELSIF P_VAITRO = 'QLTrucTiep' THEN
            V_USERNAME := 'qltt' || V_MANV;
        ELSIF P_VAITRO = 'TaiChinh' THEN
            V_USERNAME := 'tc' || V_MANV;
        END IF;
        
        UPDATE NHANVIEN
        SET USERNAME = V_USERNAME 
        WHERE MANV = V_MANV;
        --Tao user
        EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=true';
        EXECUTE IMMEDIATE 'CREATE USER ' || V_USERNAME || ' IDENTIFIED BY 123';
        EXECUTE IMMEDIATE 'GRANT role_' || P_VAITRO ||' TO '|| V_USERNAME;
        EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || V_USERNAME;
    END IF;
EXCEPTION 
    WHEN OTHERS THEN 
        DBMS_OUTPUT.PUT_LINE('L?i thêm nhân viên: ' || SQLERRM);
END;
/


-----------------------------------------------
--AD them user
--DROP 

CREATE OR REPLACE PROCEDURE sp_ThemNhanVien_AD(
    P_TENNV     IN  VARCHAR2,
    P_PHAI      IN  VARCHAR2,
    P_NGAYSINH  IN  DATE,
    P_DIACHI    IN  VARCHAR2,
    P_SODT      IN  VARCHAR2,
    P_LUONG      IN  VARCHAR2,
    P_PHUCAP      IN  VARCHAR2,
    P_VAITRO    IN  VARCHAR2,
    P_PHG       IN  NUMBER,
    P_LINHVUC   IN  VARCHAR2,
    P_CHINHANH  IN  VARCHAR2
)
AS
    v_count NUMBER;
    V_MANV NUMBER;
    V_USERNAME NVARCHAR2(100);
    V_MANQL NUMBER;
    V_LUONG  NVARCHAR2(100);
    V_PHUCAP  NVARCHAR2(100);
    V_MAX NUMBER;
    V_ID RAW(2000);
BEGIN 
    SELECT COUNT(*) INTO v_count FROM NHANVIEN WHERE TENNV = P_TENNV AND SODT = P_SODT AND LINHVUC = P_LINHVUC;
    IF (v_count < 1) THEN 
        select max (manv) into V_MAX from NHANVIEN;
        if (V_MAX is null) then V_MAX := 0; end if;
        begin SP_XEPHANGNHANVIEN(V_MAX+1 , V_MAX, V_ID); end;
        V_LUONG := fun_TAOKETQUA(P_LUONG, V_ID);
        V_PHUCAP := fun_TAOKETQUA(P_PHUCAP, V_ID);
        INSERT INTO NHANVIEN(TENNV, PHAI, NGAYSINH, DIACHI, SODT,LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME, LINHVUC, CHINHANH)
        VALUES (P_TENNV, P_PHAI, P_NGAYSINH, P_DIACHI, P_SODT, V_LUONG, V_PHUCAP, P_VAITRO, NULL, P_PHG, NULL, P_LINHVUC, P_CHINHANH);
        
        SELECT MANV INTO V_MANV FROM NHANVIEN WHERE TENNV = P_TENNV AND SODT = P_SODT AND LINHVUC = P_LINHVUC;
        SELECT TRPHG INTO V_MANQL FROM PHONGBAN WHERE MAPB = P_PHG;
        -- Update MANQL
        UPDATE NHANVIEN 
        SET MANQL = V_MANQL
        WHERE MANV = V_MANV;
        
        -- Update USERNAME
        IF P_VAITRO = 'NhanVien' THEN
            V_USERNAME := 'nv' || V_MANV;
        ELSIF P_VAITRO = 'TruongDeAn' THEN
            V_USERNAME := 'tda' || V_MANV;
        ELSIF P_VAITRO = 'NhanSu' THEN
            V_USERNAME := 'ns' || V_MANV;
        ELSIF P_VAITRO = 'TruongPhong' THEN
            V_USERNAME := 'tp' || V_MANV;
        ELSIF P_VAITRO = 'BanGiamDoc' THEN
            V_USERNAME := 'bgd' || V_MANV;
        ELSIF P_VAITRO = 'QLTrucTiep' THEN
            V_USERNAME := 'qltt' || V_MANV;
        ELSIF P_VAITRO = 'TaiChinh' THEN
            V_USERNAME := 'tc' || V_MANV;
        END IF;
        
        UPDATE NHANVIEN
        SET USERNAME = V_USERNAME 
        WHERE MANV = V_MANV;
        --Tao user
        EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=true';
        EXECUTE IMMEDIATE 'CREATE USER ' || V_USERNAME || ' IDENTIFIED BY 123';
        EXECUTE IMMEDIATE 'GRANT role_' || P_VAITRO ||' TO '|| V_USERNAME;
        EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || V_USERNAME;
    END IF;
EXCEPTION 
    WHEN OTHERS THEN 
        DBMS_OUTPUT.PUT_LINE('L?i thêm nhân viên: ' || SQLERRM);
END;
/
----------------------------------------------------
--TAICHINH - cap nhat luong, phu cap
--drop procedure TG_CAPNHATXEPHANG;

create or replace procedure TG_CAPNHATXEPHANG (
    manvv number,
    dauvaoLUONG VARCHAR2,
    dauvaoPC VARCHAR2)
is
    ID raw(2000);
    V_LUONG VARCHAR2(255);
    V_PHUCAP VARCHAR2(255);
begin
    select DIEM into ID from XEPHANG where MA = manvv;
    V_LUONG := fun_TAOKETQUA(dauvaoLUONG, ID);
    V_PHUCAP := fun_TAOKETQUA(dauvaoPC, ID);
    update NHANVIEN
    set LUONG = V_LUONG, PHUCAP = V_PHUCAP
    where MANV = manvv;
end;
/
grant execute on ad.TG_CAPNHATXEPHANG to role_TaiChinh;
/
-- gui thong bao
CREATE OR REPLACE PROCEDURE proc_send_notification(   
p_noidung THONGBAO.NOIDUNG%TYPE,  
p_vaitro THONGBAO.VAITRO%TYPE,
p_linhvuc THONGBAO.LINHVUC%TYPE,
p_chinhanh THONGBAO.CHINHANH%TYPE)  
IS  
BEGIN  
    INSERT INTO AD.THONGBAO(NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES (p_noidung,sysdate,p_vaitro,p_linhvuc,p_chinhanh);
    commit;
	EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Xay ra loi' || ': ' || SQLERRM);
END;  
/
grant execute on proc_send_notification to role_BanGiamDoc, role_TruongPhong;
/ 


-- TRUONG PHONG 
-- grant proc to role truong phong
grant execute on proc_update_NhanVien to role_TruongPhong, role_NhanSu, role_NhanVien, role_TruongDeAn, role_QLTrucTiep, role_TaiChinh, role_BanGiamDoc;
grant execute on proc_insert_PhanCong to role_TruongPhong;
grant execute on proc_update_PhanCong to role_TruongPhong;
grant execute on proc_delete_PhanCong to role_TruongPhong;

grant execute on proc_update_NhanVien to role_NhanVien;
--select * from phongban;
/
-- update Phong Ban
CREATE OR REPLACE PROCEDURE proc_update_PhongBan (   
p_mapb PhongBan.MAPB%TYPE,  
p_tenpb PhongBan.TENPB%TYPE,  
p_matrphg PhongBan.TRPHG%TYPE)  
IS  
BEGIN  
    UPDATE AD.PhongBan 
    SET TENPB = p_tenpb,
        TRPHG = p_matrphg
    WHERE MAPB=p_mapb;  
    COMMIT;
	EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Xay ra loi' || ': ' || SQLERRM);
END;
/
-- Truong De An
CREATE OR REPLACE PROCEDURE proc_update_DeAn (   
p_mada DEAN.MADA%TYPE,  
p_tenda DEAN.TENDA%TYPE,  
p_ngaybd DEAN.NGAYBD%TYPE,
p_phong DEAN.PHONG%TYPE)  
IS  
BEGIN  
    UPDATE AD.DEAN 
    SET TENDA = p_tenda,
        NGAYBD = p_ngaybd,
        PHONG = p_phong
    WHERE MADA = p_mada;  
    COMMIT;
	EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Xay ra loi' || ': ' || SQLERRM);
END;
/
CREATE OR REPLACE PROCEDURE proc_insert_DeAn (   
p_mada DEAN.MADA%TYPE,  
p_tenda DEAN.TENDA%TYPE,  
p_ngaybd DEAN.NGAYBD%TYPE,
p_phong DEAN.PHONG%TYPE)  
IS  
BEGIN  
    INSERT INTO AD.DEAN(MADA,TENDA,NGAYBD,PHONG)
    VALUES ( p_mada, p_tenda, p_ngaybd, p_phong);
    COMMIT;
	EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Xay ra loi' || ': ' || SQLERRM);
END; 
/
GRANT EXECUTE ON proc_update_PhongBan TO role_NhanSu;
GRANT EXECUTE ON proc_update_DeAn TO role_TruongDeAn;
GRANT EXECUTE ON proc_insert_DeAn TO role_TruongDeAn;