------------------------
--TAO ADMIN
------------------------
--TAO VA PHAN QUYEN ADMIN

--1.1. Xoa user neu ton tai
CREATE OR REPLACE PROCEDURE SYS.SP_DROP_USER_EXIST (user_name VARCHAR2)
AS n NUMBER;
BEGIN
    n := 0;
    SELECT COUNT(*) INTO n FROM dba_users WHERE USERNAME = UPPER(user_name);
    IF (n != 0) THEN
        DBMS_OUTPUT.PUT_LINE('Xoa user_name: ' || user_name || ' thanh cong!');
        EXECUTE IMMEDIATE ('alter session set "_ORACLE_SCRIPT"=true');
        EXECUTE IMMEDIATE ('DROP USER '|| user_name || ' CASCADE');
        EXECUTE IMMEDIATE ('alter session set "_ORACLE_SCRIPT"=false');
    END IF;
END;
/

--1.2. Thuc hien tao va cap quyen 
exec SYS.SP_DROP_USER_EXIST('ad');
/
alter session set "_ORACLE_SCRIPT"=true; 
CREATE USER ad IDENTIFIED BY 123 container = ALL;
GRANT ALL PRIVILEGES TO ad with ADMIN OPTION;
GRANT SELECT ON DBA_TAB_PRIVS TO ad WITH GRANT OPTION;
GRANT SELECT ON ROLE_TAB_PRIVS TO ad WITH GRANT OPTION;
GRANT SELECT ON dba_tables to ad WITH GRANT OPTION;
GRANT SELECT ON dba_users to ad WITH GRANT OPTION;
GRANT SELECT ON USER_ROLE_PRIVS to ad WITH GRANT OPTION;
GRANT SELECT ON DBA_ROLES to ad WITH GRANT OPTION;
GRANT execute on DBMS_RLS to ad WITH GRANT OPTION;
GRANT CREATE ANY CONTEXT, CREATE PROCEDURE, CREATE TRIGGER, ADMINISTER DATABASE TRIGGER TO ad;
GRANT EXECUTE ON DBMS_SESSION TO ad;
GRANT EXECUTE ON DBMS_RLS to ad;
ALTER USER ad quota 20M ON USERS;
GRANT CREATE TABLE TO ad;
GRANT SELECT ANY DICTIONARY TO ad;
GRANT EXECUTE ON DBMS_CRYPTO to ad;


--grant connect to ad;
--GRANT ALL PRIVILEGES TO ad with ADMIN OPTION;
--GRANT SELECT ON DBA_TAB_PRIVS TO ad WITH GRANT OPTION;
--GRANT SELECT ON ROLE_TAB_PRIVS TO ad WITH GRANT OPTION;
--GRANT SELECT ON dba_tables to ad WITH GRANT OPTION;
--GRANT SELECT ON dba_users to ad WITH GRANT OPTION;
--GRANT SELECT ON USER_ROLE_PRIVS to ad WITH GRANT OPTION;
--GRANT SELECT ON DBA_ROLES to ad WITH GRANT OPTION;
--GRANT EXECUTE ON DBMS_RLS TO ad;


--Tao cac proc cho admin



--Chay voi sys
--cac quyen cho admin

--Nho them exception

--1.1. Tao role, phan role cho user
--1.2. Xoa role
--1.3. Tao user, phan user vao role --La ad thuc hien hay admin thuc hien
--1.4. Xoa user, cascade --La ad thuc hien hay admin thuc hien
--1.5. Thu hoi quyen cua user tren mot role/table?
--1.6. Tao view select cac thuoc tinh tren table
--1.7. Thu hoi view select (xoa view) tren mot table
--1.8. Xoa view 
--1.9. Thu hoi quyen

alter session set "_oracle_script" = true;

--CuaSon
--alter pluggable database qlnvpdb open;
--CuaTan
alter pluggable database QLDTPDB open;

alter system set audit_trail = DB,EXTENDED scope = spfile;
shutdown immediate;
startup;

show parameter audit_trail;