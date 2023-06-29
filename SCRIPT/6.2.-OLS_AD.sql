
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao1', sysdate, 'GiamDoc', 'MuaBan', 'MienBac');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao2', sysdate, 'TruongPhong', 'MuaBan', 'MienBac');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao3', sysdate, 'TruongPhong', 'SanXuat', 'MienBac');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao4', sysdate, 'TruongPhong', 'GiaCong', 'MienBac');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao5', sysdate, 'TruongPhong', 'MuaBan', 'MienTrung');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao6', sysdate, 'TruongPhong', 'SanXuat', 'MienTrung');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao7', sysdate, 'TruongPhong', 'GiaCong', 'MienTrung');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao8', sysdate, 'TruongPhong', 'MuaBan', 'MienNam');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao9', sysdate, 'TruongPhong', 'SanXuat', 'MienNam');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao10', sysdate, 'TruongPhong', 'GiaCong', 'MienNam');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao10', sysdate, 'NhanVien', 'MuaBan', 'MienBac');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao11', sysdate, 'NhanVien', 'SanXuat', 'MienBac');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao12', sysdate, 'NhanVien', 'GiaCong', 'MienBac');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao13', sysdate, 'NhanVien', 'MuaBan', 'MienTrung');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao14', sysdate, 'NhanVien', 'SanXuat', 'MienTrung');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao15', sysdate, 'NhanVien', 'GiaCong', 'MienTrung');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao16', sysdate, 'NhanVien', 'MuaBan', 'MienNam');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao17', sysdate, 'NhanVien', 'SanXuat', 'MienNam');
INSERT INTO THONGBAO (NOIDUNG,THOIGIAN,VAITRO,LINHVUC,CHINHANH) VALUES ('thongbao18', sysdate, 'NhanVien', 'GiaCong', 'MienNam');
/

UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'GD:MB,SX,GC:TCT') WHERE CHINHANH = 'TongCongTy';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'GD:SX,MB,GC:MBac') WHERE VAITRO = 'GiamDoc' AND CHINHANH = 'MienBac';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'GD:SX,MB,GC:MTrung') WHERE VAITRO = 'GiamDoc' AND CHINHANH = 'MienTrung';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'GD:SX,MB,GC:MNam') WHERE VAITRO = 'GiamDoc' AND CHINHANH = 'MienNam';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'TP:MB:MBac') WHERE VAITRO = 'TruongPhong' AND LINHVUC = 'MuaBan' AND CHINHANH = 'MienBac';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'TP:SX:MBac') WHERE VAITRO = 'TruongPhong' AND LINHVUC = 'SanXuat' AND CHINHANH = 'MienBac';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'TP:GC:MBac') WHERE VAITRO = 'TruongPhong' AND LINHVUC = 'GiaCong' AND CHINHANH = 'MienBac';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'TP:MB:MTrung') WHERE VAITRO = 'TruongPhong' AND LINHVUC = 'MuaBan' AND CHINHANH = 'MienTrung';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'TP:SX:MTrung') WHERE VAITRO = 'TruongPhong' AND LINHVUC = 'SanXuat' AND CHINHANH = 'MienTrung';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'TP:GC:MTrung') WHERE VAITRO = 'TruongPhong' AND LINHVUC = 'GiaCong' AND CHINHANH = 'MienTrung';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'TP:MB:MNam') WHERE VAITRO = 'TruongPhong' AND LINHVUC = 'MuaBan' AND CHINHANH = 'MienNam';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'TP:SX:MNam') WHERE VAITRO = 'TruongPhong' AND LINHVUC = 'SanXuat' AND CHINHANH = 'MienNam';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'TP:GC:MNam') WHERE VAITRO = 'TruongPhong' AND LINHVUC = 'GiaCong' AND CHINHANH = 'MienNam';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'NV:MB:MBac') WHERE VAITRO = 'NhanVien' AND LINHVUC = 'MuaBan' AND CHINHANH = 'MienBac';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'NV:SX:MBac') WHERE VAITRO = 'NhanVien' AND LINHVUC = 'SanXuat' AND CHINHANH = 'MienBac';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'NV:GC:MBac') WHERE VAITRO = 'NhanVien' AND LINHVUC = 'GiaCong' AND CHINHANH = 'MienBac';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'NV:MB:MTrung') WHERE VAITRO = 'NhanVien' AND LINHVUC = 'MuaBan' AND CHINHANH = 'MienTrung';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'NV:SX:MTrung') WHERE VAITRO = 'NhanVien' AND LINHVUC = 'SanXuat' AND CHINHANH = 'MienTrung';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'NV:GC:MTrung') WHERE VAITRO = 'NhanVien' AND LINHVUC = 'GiaCong' AND CHINHANH = 'MienTrung';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'NV:MB:MNam') WHERE VAITRO = 'NhanVien' AND LINHVUC = 'MuaBan' AND CHINHANH = 'MienNam';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'NV:SX:MNam') WHERE VAITRO = 'NhanVien' AND LINHVUC = 'SanXuat' AND CHINHANH = 'MienNam';
UPDATE AD.THONGBAO SET OLS_COLUMN = char_to_label('THONGBAO_OLS_POL', 'NV:GC:MNam') WHERE VAITRO = 'NhanVien' AND LINHVUC = 'GiaCong' AND CHINHANH = 'MienNam';

/
CREATE OR REPLACE FUNCTION GET_THONGBAO_LABEL (
  VAITRO  IN  VARCHAR2,
  LINHVUC     IN  VARCHAR2,
  CHINHANH     IN  VARCHAR2)
RETURN LBACSYS.LBAC_LABEL AS
  v_label  VARCHAR2(80);
BEGIN
  IF VAITRO = 'TruongPhong' THEN
     v_label := 'TP:';
  ELSIF VAITRO = 'NhanVien' THEN
     v_label := 'NV:';
  ELSIF VAITRO = 'TongGiamDoc' OR VAITRO = 'GiamDoc' THEN
     v_label := 'GD:MB,SX,GC:';
  END IF;

  IF LINHVUC = 'MuaBan' AND VAITRO != 'TongGiamDoc' AND VAITRO != 'GiamDoc' THEN
     v_label := v_label || 'MB:';
  ELSIF LINHVUC = 'SanXuat' AND VAITRO != 'TongGiamDoc' AND VAITRO != 'GiamDoc' THEN
     v_label := v_label || 'SX:';
  ELSIF LINHVUC = 'GiaCong' AND VAITRO != 'TongGiamDoc' AND VAITRO != 'GiamDoc' THEN
     v_label := v_label || 'GC:';
  END IF;

  IF CHINHANH = 'MienBac' AND VAITRO != 'TongGiamDoc' THEN
    v_label := v_label || 'MBac';
  ELSIF CHINHANH = 'MienTrung' AND VAITRO != 'TongGiamDoc' THEN
    v_label := v_label || 'MTrung';
  ELSIF CHINHANH = 'MienNam' AND VAITRO != 'TongGiamDoc' THEN
    v_label := v_label || 'MNam';
  ELSIF VAITRO = 'TongGiamDoc' THEN
    v_label := v_label || 'TCT';
  END IF;
  
  RETURN TO_LBAC_DATA_LABEL('THONGBAO_OLS_POL',v_label);
END;
/
GRANT EXECUTE ON GET_THONGBAO_LABEL TO LBACSYS;
/
CREATE OR REPLACE FUNCTION GET_NHANIEN_LABEL (
  VAITRO  IN  VARCHAR2,
  LINHVUC     IN  VARCHAR2,
  CHINHANH     IN  VARCHAR2)
RETURN VARCHAR2 AS
  v_label  VARCHAR2(80);
BEGIN
  IF VAITRO = 'TruongPhong' THEN
     v_label := 'TP:';
  ELSIF VAITRO = 'TongGiamDoc' OR VAITRO = 'GiamDoc' THEN
     v_label := 'GD:MB,SX,GC:';
  ELSE
     v_label := 'NV:';
  END IF;

  IF LINHVUC = 'MuaBan' AND VAITRO != 'TongGiamDoc' AND VAITRO != 'GiamDoc' THEN
     v_label := v_label || 'MB:';
  ELSIF LINHVUC = 'SanXuat' AND VAITRO != 'TongGiamDoc' AND VAITRO != 'GiamDoc' THEN
     v_label := v_label || 'SX:';
  ELSIF LINHVUC = 'GiaCong' AND VAITRO != 'TongGiamDoc' AND VAITRO != 'GiamDoc' THEN
     v_label := v_label || 'GC:';
  END IF;

  IF CHINHANH = 'MienBac' AND VAITRO != 'TongGiamDoc' THEN
    v_label := v_label || 'MBac';
  ELSIF CHINHANH = 'MienTrung' AND VAITRO != 'TongGiamDoc' THEN
    v_label := v_label || 'MTrung';
  ELSIF CHINHANH = 'MienNam' AND VAITRO != 'TongGiamDoc' THEN
    v_label := v_label || 'MNam';
  ELSIF VAITRO = 'TongGiamDoc' THEN
    v_label := v_label || 'TCT';
  END IF;
  
  RETURN v_label;
END GET_NHANIEN_LABEL;
/
GRANT EXECUTE ON AD.GET_NHANIEN_LABEL TO LBACSYS;

/
CREATE OR REPLACE PROCEDURE SET_NHANVIEN_LABEL AS
  CURSOR cur IS select USERNAME, AD.GET_NHANIEN_LABEL(VAITRO,LINHVUC,CHINHANH) from ad.nhanvien;
  username VARCHAR2(50);
  userlabel VARCHAR2(50);
  policyname VARCHAR2(20);
BEGIN
  policyname := 'THONGBAO_OLS_POL';
  OPEN cur;
  LOOP
    FETCH cur INTO username, userlabel;
    EXIT WHEN cur%NOTFOUND;
    EXECUTE IMMEDIATE 'alter session set "_ORACLE_SCRIPT"=true';
    EXECUTE IMMEDIATE 'EXECUTE SA_USER_ADMIN.SET_USER_LABELS('''||policyname||''','''||username||''','''||userlabel||''')';
  END LOOP;
  CLOSE cur;
END SET_NHANVIEN_LABEL;
/
GRANT EXECUTE ON SET_NHANVIEN_LABEL TO LBACSYS;
