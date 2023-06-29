--------------------
--Tao data

--4.1. Tao data

-- Phong ban
INSERT INTO PHONGBAN (TENPB,TRPHG)
VALUES ('phong ke toan',null);
INSERT INTO PHONGBAN (TENPB,TRPHG)
VALUES ('phong nhan su',null);
INSERT INTO PHONGBAN (TENPB,TRPHG)
VALUES ('phong dau tu',null);
INSERT INTO PHONGBAN (TENPB,TRPHG)
VALUES ('phong tai chinh',null);
INSERT INTO PHONGBAN (TENPB,TRPHG)
VALUES ('phong moi truong',null);
INSERT INTO PHONGBAN (TENPB,TRPHG)
VALUES ('phong doi song',null);
INSERT INTO PHONGBAN (TENPB,TRPHG)
VALUES ('phong hon nhan',null);
INSERT INTO PHONGBAN (TENPB,TRPHG)
VALUES ('phong tinh yeu',null);

--De an
INSERT INTO DEAN (TENDA,NGAYBD,PHONG)
VALUES ('nc dollars',to_date('01/06/2023', 'DD/MM/YYYY'),1);
INSERT INTO DEAN (TENDA,NGAYBD,PHONG)
VALUES ('nc ngan hang',to_date('01/06/2023', 'DD/MM/YYYY'),2);
INSERT INTO DEAN (TENDA,NGAYBD,PHONG)
VALUES ('nc khi',to_date('11/06/2022', 'DD/MM/YYYY'),3);

--Nhan vien
--Giam doc
EXECUTE sp_ThemNhanVien_AD ('hà','N?',to_date('07/06/2013','DD/MM/YYYY'),'Pontianak','07624 061546','2728219','102201','BanGiamDoc',null,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('vinh','N?',to_date('07/06/2013','DD/MM/YYYY'),'Dehradun','070 9313 5647','4109008','116452','TruongDeAn',1,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('tấn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Bremerhaven','0800 658557','2924335','720582','TruongDeAn',2,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('mít','N?',to_date('07/06/2013','DD/MM/YYYY'),'Jeju','(016977) 7225','2540622','339125','TruongDeAn',3,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('tuyến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Kungälv','07624 725742','1131245','921119','NhanSu',1,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('đại','N?',to_date('07/06/2013','DD/MM/YYYY'),'Forgaria nel Friuli','0895 124 7786','8038056','593548','NhanSu',2,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('hải','N?',to_date('07/06/2013','DD/MM/YYYY'),'Icheon','0845 46 49','9134414','433812','NhanSu',3,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tiến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Juliaca','(0115) 710 1686','8096649','929115','NhanSu',4,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('kết','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Mabalacat','(016977) 4203','7805387','460651','NhanSu',5,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('thảo','N?',to_date('07/06/2013','DD/MM/YYYY'),'Guápiles','(01027) 660357','9662412','753956','TaiChinh',1,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('như','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Villers-la-Bonne-Eau','076 4620 8137','8231339','898283','TaiChinh',2,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thảo','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Berlin','056 5125 3400','8305365','111999','TaiChinh',3,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('quyết','N?',to_date('07/06/2013','DD/MM/YYYY'),'Adelaide','(01575) 17842','2215239','673688','TaiChinh',4,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('xoài','N?',to_date('07/06/2013','DD/MM/YYYY'),'Keith','0800 726224','1376696','89510','TaiChinh',5,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('toàn','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Dole','(0112) 916 2318','2364852','448457','TruongPhong',1,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('trâm','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Secunda','(016977) 6446','7887593','314233','TruongPhong',2,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mận','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Quesada','0800 554377','7257512','445194','TruongPhong',3,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('quân','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Phan Thiết','07624 275943','2796193','425309','TruongPhong',4,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('như','N?',to_date('07/06/2013','DD/MM/YYYY'),'Serang','(027) 9416 5418','6902671','150155','TruongPhong',5,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('chi','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Kalgoorlie-Boulder','(0131) 779 6443','5163362','526913','TruongPhong',6,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('trâm','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Bargagli','(023) 6755 6407','3910576','681746','TruongPhong',7,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('xoài','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Rustenburg','0800 870 6525','343990','379344','TruongPhong',8,'SanXuat','MienNam');

--update
update PHONGBAN
set TRPHG = 15
where MAPB = 1;
update PHONGBAN
set TRPHG = 16
where MAPB = 2;
update PHONGBAN
set TRPHG = 17
where MAPB = 3;
update PHONGBAN
set TRPHG = 18
where MAPB = 4;
update PHONGBAN
set TRPHG = 19
where MAPB = 5;
update PHONGBAN
set TRPHG = 20
where MAPB = 6;
update PHONGBAN
set TRPHG = 21
where MAPB = 7;
update PHONGBAN
set TRPHG = 22
where MAPB = 8;

EXECUTE sp_ThemNhanVien_AD ('hải','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Lozova','0800 1111','5245234','305326','QLTrucTiep',2,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('kết','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Palma de Mallorca','0329 317 6328','3767237','143367','QLTrucTiep',7,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('sơn','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Picton','055 5444 7715','2664654','592217','QLTrucTiep',1,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mít','N?',to_date('07/06/2013','DD/MM/YYYY'),'�?ódź','0500 356752','2034717','365249','QLTrucTiep',5,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hà','N?',to_date('07/06/2013','DD/MM/YYYY'),'Porto Alegre','(0112) 988 1848','9390218','721593','QLTrucTiep',4,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('câm','N?',to_date('07/06/2013','DD/MM/YYYY'),'Dublin','(011575) 57787','9977442','844163','QLTrucTiep',8,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hải','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Lambayeque','07229 548334','4382102','544827','QLTrucTiep',5,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('trâm','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Bergen','07624 351529','3730839','208782','QLTrucTiep',4,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('sơn','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Belfast','0500 748360','2002419','163241','QLTrucTiep',2,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('tuyến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Galway','0500 525458','4574299','340305','QLTrucTiep',3,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tiên','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Pachuca','(01828) 686163','2563095','54540','QLTrucTiep',5,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('bằng','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Devizes','0800 242 3211','2932656','261034','QLTrucTiep',6,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tuyét','N?',to_date('07/06/2013','DD/MM/YYYY'),'Escalante','(024) 6605 4881','9631431','943615','QLTrucTiep',7,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hông','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Çermik','0800 658 6440','8060541','284841','QLTrucTiep',5,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('quân','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Pretoria','055 3450 8117','8317963','61775','QLTrucTiep',5,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('chi','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Western Islands','07624 973369','1078966','5246','QLTrucTiep',2,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('toàn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Xinjiang','(01325) 331301','9745304','392413','QLTrucTiep',3,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('quyết','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Kaliningrad','07624 141477','2753449','340634','QLTrucTiep',5,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('quân','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Linköping','070 5642 5901','629114','60933','QLTrucTiep',7,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mai','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Yogyakarta','(0117) 654 3832','6724329','182210','QLTrucTiep',8,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('hà','N?',to_date('07/06/2013','DD/MM/YYYY'),'Pontianak','07624 061546','2423','102201','TongGiamDoc',null,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('hà','N?',to_date('07/06/2013','DD/MM/YYYY'),'Pontianak','07624 061546','424','323','GiamDoc',null,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hà','N?',to_date('07/06/2013','DD/MM/YYYY'),'Pontianak','07624 061546','75757','545','GiamDoc',null,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('hà','N?',to_date('07/06/2013','DD/MM/YYYY'),'Pontianak','07624 061546','53','545','GiamDoc',null,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hà','N?',to_date('07/06/2013','DD/MM/YYYY'),'Pontianak','07624 061546','23','456','GiamDoc',null,'GiaCong','MienNam');

EXECUTE sp_ThemNhanVien_AD ('thảo','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Rzeszów','0334 821 7686','2776710','182853','NhanVien',4,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hùng','N?',to_date('07/06/2013','DD/MM/YYYY'),'Arequipa','(016977) 2819','7483613','215840','NhanVien',5,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('tấn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Aserrí','076 5732 8005','4451216','694488','NhanVien',6,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('đạt','N?',to_date('07/06/2013','DD/MM/YYYY'),'Bregenz','07631 336580','7447628','855333','NhanVien',4,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('minh','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Tarragona','(016977) 1944','4078203','148444','NhanVien',4,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mận','N?',to_date('07/06/2013','DD/MM/YYYY'),'Graz','070 9686 3454','9848075','432818','NhanVien',6,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('ý','N?',to_date('07/06/2013','DD/MM/YYYY'),'Sankt Johann im Pongau','055 1670 5194','1377228','241305','NhanVien',8,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('như','N?',to_date('07/06/2013','DD/MM/YYYY'),'Rahim Yar Khan','0800 871 7622','3717898','438156','NhanVien',4,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('đào\','N?',to_date('07/06/2013','DD/MM/YYYY'),'Oberpullendorf','0800 1111','5046981','573175','NhanVien',6,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('hông','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Lelystad','076 2583 5084','9389868','94406','NhanVien',4,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hải','N?',to_date('07/06/2013','DD/MM/YYYY'),'Anseong','076 0010 8306','9145051','366853','NhanVien',6,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('tấn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Castel Giorgio','07358 563103','9621000','664918','NhanVien',4,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tấn','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Jauchelette','0891 269 5786','2634194','961539','NhanVien',4,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('vinh','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Chuncheon','070 4441 1836','1483454','502052','NhanVien',5,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('thảo','N?',to_date('07/06/2013','DD/MM/YYYY'),'Knittelfeld','055 4662 1656','2854447','52257','NhanVien',5,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('kết','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Siegendorf','(0116) 142 5082','817924','500750','NhanVien',1,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('dưa','N?',to_date('07/06/2013','DD/MM/YYYY'),'Lublin','0906 258 9513','868910','979281','NhanVien',1,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hùng','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Sicuani','(0171) 833 0255','1741215','400797','NhanVien',6,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('út','N?',to_date('07/06/2013','DD/MM/YYYY'),'Lerum','07624 485688','8910430','449328','NhanVien',6,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('trâm','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Torghar','(026) 1847 5158','4406666','223726','NhanVien',6,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('mít','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Vienna','(025) 7518 5333','5050868','511311','NhanVien',8,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('ân','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Sembawang','0500 671624','7055344','799190','NhanVien',8,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('phong','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Banjarmasin','076 6155 6639','684407','897881','NhanVien',8,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tuyét','N?',to_date('07/06/2013','DD/MM/YYYY'),'Móstoles','0360 852 2405','9031973','892680','NhanVien',6,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('phong','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Mount Gambier','0864 341 8770','1860267','525397','NhanVien',8,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('vinh','N?',to_date('07/06/2013','DD/MM/YYYY'),'Jiangsu','055 6447 5345','9956613','4429','NhanVien',4,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('như','N?',to_date('07/06/2013','DD/MM/YYYY'),'Lagos','07624 756937','8534307','845906','NhanVien',6,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('hà','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Cereté','0818 501 5634','9600755','939147','NhanVien',7,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('quyết','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Fürstenwalde','(01277) 043941','4045006','348307','NhanVien',4,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('lý','N?',to_date('07/06/2013','DD/MM/YYYY'),'Kallang','056 1077 1765','163213','291935','NhanVien',1,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hùng','N?',to_date('07/06/2013','DD/MM/YYYY'),'Ayr','(01511) 14243','4646762','353485','NhanVien',5,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('út','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Vienna','055 7883 6446','5795047','665023','NhanVien',7,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('sơn','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Katsina','056 3617 8711','6456437','381614','NhanVien',1,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('phước','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Renfrew','(022) 4824 6170','7291918','86395','NhanVien',4,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('hùng','N?',to_date('07/06/2013','DD/MM/YYYY'),'San Gregorio','070 6913 7424','1308439','48176','NhanVien',6,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tiến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Vadodara','076 2646 8068','2425727','763174','NhanVien',6,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('cận\','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Kaneohe','(01945) 65544','5793597','493496','NhanVien',7,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('hùng','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Chungju','(01653) 713927','2387368','194419','NhanVien',3,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('thảo','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Galway','0845 46 45','5183387','463591','NhanVien',7,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('út','N?',to_date('07/06/2013','DD/MM/YYYY'),'Vadsø','0500 898577','3122276','400759','NhanVien',8,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('mai','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Heilongjiang','(0181) 621 3198','5404863','544052','NhanVien',2,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('sơn','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Mati','(0131) 292 8640','5109647','669033','NhanVien',2,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('sơn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Hoogeveen','0500 130963','4454540','743302','NhanVien',6,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('huy�?n','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Meycauayan','0500 999371','8322526','213017','NhanVien',6,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('thảo','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Dublin','(01541) 42313','1530972','41765','NhanVien',4,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('câm','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Balikpapan','0814 456 1269','9260105','845734','NhanVien',2,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tuyét','Nam',to_date('07/06/2013','DD/MM/YYYY'),'�?ông Hà','076 0944 1718','6787365','518284','NhanVien',7,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('phong','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Sokoto','(017248) 66254','8833790','628909','NhanVien',4,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('xoài','N?',to_date('07/06/2013','DD/MM/YYYY'),'Alexandra','0849 086 9833','9339732','880925','NhanVien',6,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('sơn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Volda','056 1834 4108','4691170','243717','NhanVien',8,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('hà','N?',to_date('07/06/2013','DD/MM/YYYY'),'Ełk','0800 816 7363','5977260','472511','NhanVien',1,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('đào\','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Bima','(0113) 825 4647','1414105','111882','NhanVien',8,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('vinh','N?',to_date('07/06/2013','DD/MM/YYYY'),'Voitsberg','076 7432 1514','4936027','220423','NhanVien',5,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('tuyét','Nam',to_date('07/06/2013','DD/MM/YYYY'),'San Juan de Girón','(01313) 28284','7286046','737771','NhanVien',6,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tuyến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Tuxtla Gutiérrez','(01433) 56464','6773567','366884','NhanVien',6,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('cận\','N?',to_date('07/06/2013','DD/MM/YYYY'),'Heredia','0340 996 6662','9141696','201990','NhanVien',6,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('hà','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Hải Phòng','(015688) 98245','9426227','565841','NhanVien',1,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('bằng','N?',to_date('07/06/2013','DD/MM/YYYY'),'Villahermosa','07834 707956','7778638','355822','NhanVien',1,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('út','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Galway','056 8468 1069','9435865','77702','NhanVien',3,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('đại','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Sapele','056 1579 7038','1384101','85815','NhanVien',6,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('cận\','N?',to_date('07/06/2013','DD/MM/YYYY'),'Juárez','0886 376 2475','8947780','32302','NhanVien',5,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('yến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Kerikeri','0845 46 42','6217230','722668','NhanVien',7,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('câm','N?',to_date('07/06/2013','DD/MM/YYYY'),'Aurillac','(0114) 518 7862','5638414','495455','NhanVien',4,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('mận','N?',to_date('07/06/2013','DD/MM/YYYY'),'Uyo','(0114) 281 1316','3859098','29471','NhanVien',2,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('đào\','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Molde','07338 971221','5886692','734579','NhanVien',6,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('hùng','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Legnica','07980 388875','370813','215936','NhanVien',2,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('mận','N?',to_date('07/06/2013','DD/MM/YYYY'),'Bear','0800 1111','6542658','991474','NhanVien',7,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('thảo','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Sahagún','0800 1111','7630179','491573','NhanVien',1,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('đào\','N?',to_date('07/06/2013','DD/MM/YYYY'),'Mojokerto','0828 538 1692','220572','6683','NhanVien',6,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('chi','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Diadema','(016977) 8249','226038','29142','NhanVien',3,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('cận\','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Palmerston','0800 547225','3578056','584636','NhanVien',6,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('hùng','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Cumnock','055 1254 4134','2136702','942036','NhanVien',1,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mai','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Gasteiz','0356 266 0170','3464241','507848','NhanVien',1,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('đào\','N?',to_date('07/06/2013','DD/MM/YYYY'),'Rezé','076 0737 6733','1007126','369627','NhanVien',6,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('hà','N?',to_date('07/06/2013','DD/MM/YYYY'),'Vöcklabruck','070 3326 4472','5922271','912849','NhanVien',3,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('bằng','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Booischot','0950 044 5178','203989','457440','NhanVien',4,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('mai','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Juliaca','0341 120 4661','9627646','995081','NhanVien',4,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hùng','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Tuluá','0800 138 3186','5516448','359574','NhanVien',6,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('huy�?n','N?',to_date('07/06/2013','DD/MM/YYYY'),'Jaén','0934 127 3185','2045336','514923','NhanVien',7,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('thảo','N?',to_date('07/06/2013','DD/MM/YYYY'),'Opole','070 7228 3703','9442666','553986','NhanVien',8,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tấn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Egersund','0800 275811','1300629','917375','NhanVien',5,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('đạt','N?',to_date('07/06/2013','DD/MM/YYYY'),'Suwałki','0389 758 5604','8865196','474293','NhanVien',4,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hùng','N?',to_date('07/06/2013','DD/MM/YYYY'),'Gouda','0845 46 45','9352303','716831','NhanVien',4,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('hà','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Dublin','0374 728 8143','9726492','197606','NhanVien',4,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('tấn','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Paiguano','0367 188 2323','5484421','822182','NhanVien',3,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('ân','N?',to_date('07/06/2013','DD/MM/YYYY'),'Cartago','(01886) 51642','4538743','908510','NhanVien',3,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('phong','N?',to_date('07/06/2013','DD/MM/YYYY'),'Fredericton','0951 358 5874','3473585','613334','NhanVien',1,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mai','N?',to_date('07/06/2013','DD/MM/YYYY'),'Granada','(01121) 29122','5707452','417649','NhanVien',4,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('đào\','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Gojal Upper Hunza','0500 081104','343668','251244','NhanVien',4,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mận','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Orhangazi','(027) 4377 8373','6662841','557127','NhanVien',5,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('chi','N?',to_date('07/06/2013','DD/MM/YYYY'),'Putre','0389 929 1516','3249945','756104','NhanVien',3,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mận','N?',to_date('07/06/2013','DD/MM/YYYY'),'Colobraro','(0115) 852 5312','6107441','839215','NhanVien',1,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('huy�?n','N?',to_date('07/06/2013','DD/MM/YYYY'),'Calamar','0845 46 43','7631550','890836','NhanVien',8,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('hông','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Killa Abdullah','0800 1111','1547882','54564','NhanVien',1,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('tiến','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Galway','0800 333637','4826756','397409','NhanVien',2,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('kết','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Kawerau','(0111) 618 3485','259661','553138','NhanVien',1,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('bằng','N?',to_date('07/06/2013','DD/MM/YYYY'),'Paita','(016977) 8133','6413382','373758','NhanVien',4,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('dưa','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Navojoa','070 4460 6020','1626734','177805','NhanVien',5,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('kết','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Oaxaca','(0141) 430 2319','5291109','784055','NhanVien',4,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('xoài','N?',to_date('07/06/2013','DD/MM/YYYY'),'Kech','076 2151 5857','5779881','681508','NhanVien',6,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tấn','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Lahore','0845 46 45','1619456','489352','NhanVien',8,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('phước','N?',to_date('07/06/2013','DD/MM/YYYY'),'Quintero','(024) 7242 5390','6498358','55450','NhanVien',4,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hải','N?',to_date('07/06/2013','DD/MM/YYYY'),'Cisnes','076 1565 2832','6621584','642284','NhanVien',2,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('xoài','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Odessa','07420 007281','3410596','191264','NhanVien',4,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('như','N?',to_date('07/06/2013','DD/MM/YYYY'),'Mosquera','(017622) 72773','9784802','666862','NhanVien',6,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('chi','N?',to_date('07/06/2013','DD/MM/YYYY'),'�?ódź','0800 741176','9103260','670439','NhanVien',5,'GiaCong','MienTrung');

EXECUTE sp_ThemNhanVien_AD ('xoài','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Vĩnh Long','(0114) 209 7887','3546724','857319','NhanVien',4,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mít','Nam',to_date('07/06/2013','DD/MM/YYYY'),'İskenderun','070 9386 4845','4961213','304953','NhanVien',6,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('yến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Kingussie','0875 844 4657','6474890','443902','NhanVien',4,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thành','N?',to_date('07/06/2013','DD/MM/YYYY'),'Gia Nghĩa','(0115) 002 2227','2346906','426577','NhanVien',8,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('mai','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Carluke','070 6112 6071','7222885','163679','NhanVien',1,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('tiên','N?',to_date('07/06/2013','DD/MM/YYYY'),'Central Water Catchment','(01508) 442277','7938664','183314','NhanVien',3,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('phước','N?',to_date('07/06/2013','DD/MM/YYYY'),'Stonewall','0800 1111','5721335','591195','NhanVien',1,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('vinh','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Oaxaca','(01558) 790455','9839946','699147','NhanVien',6,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('lý','N?',to_date('07/06/2013','DD/MM/YYYY'),'Meppel','056 2213 6265','1908496','142768','NhanVien',4,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('mai','N?',to_date('07/06/2013','DD/MM/YYYY'),'Puno','070 4418 9063','875890','184945','NhanVien',8,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tiến','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Corte Brugnatella','0800 753 6518','9677610','318250','NhanVien',2,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('út','N?',to_date('07/06/2013','DD/MM/YYYY'),'Saint Louis','0813 492 4935','9493497','932788','NhanVien',4,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('dưa','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Evere','0989 566 5821','8777035','624780','NhanVien',3,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('mận','N?',to_date('07/06/2013','DD/MM/YYYY'),'Paulista','07482 474384','7671264','673456','NhanVien',8,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mận','N?',to_date('07/06/2013','DD/MM/YYYY'),'Timaru','0398 860 4520','4262181','873671','NhanVien',4,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('vinh','N?',to_date('07/06/2013','DD/MM/YYYY'),'Sacheon','0800 621828','8869210','456037','NhanVien',2,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('thành','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Matamoros','070 0522 6656','4229688','235129','NhanVien',8,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('thảo','N?',to_date('07/06/2013','DD/MM/YYYY'),'Shreveport','07624 045056','5845455','362705','NhanVien',8,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('quân','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Invercargill','07797 485676','8808289','402782','NhanVien',1,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('mai','N?',to_date('07/06/2013','DD/MM/YYYY'),'Seogwipo','07624 214393','4308366','54853','NhanVien',4,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('dưa','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Ternate','0800 645 8661','2178355','590280','NhanVien',4,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('mít','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Springdale','0800 645 1682','612679','337273','NhanVien',7,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('vinh','N?',to_date('07/06/2013','DD/MM/YYYY'),'Vienna','(016977) 5682','428658','739195','NhanVien',3,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('tuyến','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Erciş','0800 1111','5140535','36656','NhanVien',8,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('sơn','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Sembawang','070 4750 4930','9080982','407613','NhanVien',6,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('đại','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Bellville','0385 962 1154','9257942','977905','NhanVien',2,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('mận','N?',to_date('07/06/2013','DD/MM/YYYY'),'Harstad','(017214) 28623','5423322','85079','NhanVien',7,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('yến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Oslo','056 0105 0551','2294372','897374','NhanVien',2,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thảo','N?',to_date('07/06/2013','DD/MM/YYYY'),'Macau','070 1519 2020','5958226','782692','NhanVien',4,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('phước','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Stratford','(028) 9816 1011','956491','750115','NhanVien',6,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('đạt','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Smolensk','(0131) 324 1304','989452','60321','NhanVien',6,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('câm','N?',to_date('07/06/2013','DD/MM/YYYY'),'Kaduna','(01267) 97677','4492537','153894','NhanVien',1,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('mít','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Okene','(023) 9521 5331','669750','539303','NhanVien',7,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('thảo','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Navojoa','(01864) 770292','603193','427901','NhanVien',7,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('tuyét','N?',to_date('07/06/2013','DD/MM/YYYY'),'Le Puy-en-Velay','(0118) 956 5041','6192319','452404','NhanVien',5,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mận','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Ulloa (Barrial]','07624 671563','6220506','417957','NhanVien',6,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('hà','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Palmerston','055 1544 7349','9578153','673934','NhanVien',6,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('phong','Nam',to_date('07/06/2013','DD/MM/YYYY'),'�?ồng Hới','(0112) 008 5388','7747980','485042','NhanVien',3,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('tiến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Warszawa','056 5371 1209','1386105','827040','NhanVien',5,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('tuyến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Quảng Ngãi','(0119) 347 7482','8555666','863999','NhanVien',8,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('mận','N?',to_date('07/06/2013','DD/MM/YYYY'),'San Cristóbal de las Casas','07878 643573','61890','782745','NhanVien',7,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tiên','N?',to_date('07/06/2013','DD/MM/YYYY'),'Port Lincoln','056 3138 7163','6615496','291692','NhanVien',4,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('ý','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Graz','055 1632 2875','4290193','405057','NhanVien',4,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('xoài','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Nuremberg','(022) 7224 8579','3769547','174614','NhanVien',2,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('tiên','N?',to_date('07/06/2013','DD/MM/YYYY'),'Tarbes','0800 682657','1892598','372403','NhanVien',1,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('hà','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Khmelnytskyi','0845 46 49','2603171','18680','NhanVien',2,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('ý','N?',to_date('07/06/2013','DD/MM/YYYY'),'Marano Lagunare','0883 804 2124','8200324','872499','NhanVien',4,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('tuyét','N?',to_date('07/06/2013','DD/MM/YYYY'),'Cáceres','(0114) 478 8758','910938','215472','NhanVien',6,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('mận','N?',to_date('07/06/2013','DD/MM/YYYY'),'Bida','0800 270 4643','8598743','895211','NhanVien',5,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('thảo','N?',to_date('07/06/2013','DD/MM/YYYY'),'Zoetermeer','(016977) 6528','8387238','647285','NhanVien',1,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hải','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Dapitan','0314 429 5735','8202155','562097','NhanVien',4,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('phong','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Kermt','0878 169 1806','6042760','769116','NhanVien',4,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('trâm','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Hohenems','0845 46 44','4233500','239321','NhanVien',3,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('đại','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Lysychansk','070 2472 1794','6754057','184083','NhanVien',5,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('quân','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Viranşehir','0845 46 48','2549009','463422','NhanVien',4,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('như','N?',to_date('07/06/2013','DD/MM/YYYY'),'Stockton-on-Tees','056 2626 5486','7300832','478015','NhanVien',5,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('như','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Galway','0855 280 7947','3508784','152030','NhanVien',1,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('quyết','N?',to_date('07/06/2013','DD/MM/YYYY'),'Noorderwijk','(011349) 45167','2663074','173705','NhanVien',3,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('phong','N?',to_date('07/06/2013','DD/MM/YYYY'),'Bremerhaven','(018054) 98359','6554152','239098','NhanVien',8,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thành','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Suncheon','0800 1111','7762530','295181','NhanVien',2,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hải','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Dallas','0500 550914','8188302','462353','NhanVien',6,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('bằng','N?',to_date('07/06/2013','DD/MM/YYYY'),'Long Xuyên','(011234) 45566','616564','248061','NhanVien',1,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('cận\','N?',to_date('07/06/2013','DD/MM/YYYY'),'San Isidro','(01675) 55622','2168580','639080','NhanVien',6,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('sơn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Zutphen','(016977) 8190','4151506','782097','NhanVien',4,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('phước','N?',to_date('07/06/2013','DD/MM/YYYY'),'�?ông Hà','07624 633623','8889086','338803','NhanVien',5,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('toàn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Wolfurt','0358 874 4713','5201034','304466','NhanVien',6,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('đào\','N?',to_date('07/06/2013','DD/MM/YYYY'),'Darwin','0800 214 7270','760784','552068','NhanVien',5,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('sơn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Inner Mongolia','0800 330274','6365759','918651','NhanVien',4,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thảo','N?',to_date('07/06/2013','DD/MM/YYYY'),'Vallentuna','(024) 9267 2221','6930606','907885','NhanVien',7,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('quyết','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Toruń','(01444) 94187','5224493','148261','NhanVien',2,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('ý','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Hollabrunn','0355 942 6131','883441','295140','NhanVien',4,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('ân','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Rattray','0500 231435','3258061','701063','NhanVien',1,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('út','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Chandigarh','0800 1111','2227067','984312','NhanVien',4,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('ý','N?',to_date('07/06/2013','DD/MM/YYYY'),'Bima','(01731) 744014','1439585','869167','NhanVien',5,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('kết','N?',to_date('07/06/2013','DD/MM/YYYY'),'Weesp','0500 536767','4119348','581737','NhanVien',8,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('trâm','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Leirvik','(016137) 59417','3074064','129730','NhanVien',5,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thành','N?',to_date('07/06/2013','DD/MM/YYYY'),'Vichy','0926 336 3165','318366','903288','NhanVien',8,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('xoài','N?',to_date('07/06/2013','DD/MM/YYYY'),'Zaltbommel','(013786) 54442','8623789','187545','NhanVien',2,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('kết','N?',to_date('07/06/2013','DD/MM/YYYY'),'Guihulngan','(020) 4555 6587','8514026','9447','NhanVien',6,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('sơn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Stjørdalshalsen','(022) 5138 3413','687423','282393','NhanVien',5,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mai','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Ladysmith','(016977) 8955','533592','418792','NhanVien',2,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('minh','N?',to_date('07/06/2013','DD/MM/YYYY'),'Uyo','0331 186 7793','5148509','501821','NhanVien',1,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('quyết','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Seoul','(017848) 40321','4835206','413222','NhanVien',4,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('câm','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Uddevalla','076 4625 3675','4287839','853232','NhanVien',4,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hà','Nam',to_date('07/06/2013','DD/MM/YYYY'),'George','(01982) 24843','9843276','716233','NhanVien',1,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('thành','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Veenendaal','(016977) 8589','4917118','234347','NhanVien',1,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('yến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Durban','(028) 6667 6383','4695381','78858','NhanVien',8,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('ý','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Ashburton','0845 46 43','8506443','751134','NhanVien',6,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('quân','N?',to_date('07/06/2013','DD/MM/YYYY'),'Enschede','0326 687 6561','7279219','849769','NhanVien',6,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('yến','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Colchester','0800 932 1382','5437142','567194','NhanVien',4,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('câm','N?',to_date('07/06/2013','DD/MM/YYYY'),'Opole','(016977) 3657','3795929','221122','NhanVien',6,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('tuyét','Nam',to_date('07/06/2013','DD/MM/YYYY'),'San Felipe','076 1534 2085','955704','606935','NhanVien',2,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('hông','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Jecheon','0500 082045','1090646','920347','NhanVien',4,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thảo','N?',to_date('07/06/2013','DD/MM/YYYY'),'Iqaluit','(026) 5827 2777','3091183','627055','NhanVien',2,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thành','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Volda','07624 821278','3128757','924982','NhanVien',8,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('bằng','N?',to_date('07/06/2013','DD/MM/YYYY'),'Penzance','(01211) 12994','7045255','437974','NhanVien',6,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('đào\','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Cao Bằng','070 8755 6647','444712','386307','NhanVien',4,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('thảo','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Parchim	City','0972 761 4598','1487726','987871','NhanVien',1,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('tiến','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Tianjin','056 2932 1134','6421954','691876','NhanVien',1,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thảo','N?',to_date('07/06/2013','DD/MM/YYYY'),'Eschwege','0933 033 4685','6587106','482220','NhanVien',3,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('tấn','N?',to_date('07/06/2013','DD/MM/YYYY'),'Cork','(01654) 616495','1979871','688690','NhanVien',6,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('ân','N?',to_date('07/06/2013','DD/MM/YYYY'),'Rechnitz','0335 546 7279','3405163','968656','NhanVien',8,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('đạt','N?',to_date('07/06/2013','DD/MM/YYYY'),'Palembang','0500 243512','539680','370699','NhanVien',3,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thảo','N?',to_date('07/06/2013','DD/MM/YYYY'),'Toa Payoh','056 9536 7517','708016','927657','NhanVien',8,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('hùng','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Irkutsk','(011193) 02788','933325','394978','NhanVien',5,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('mít','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Sandnessjøen','(0111) 215 4278','9027327','878915','NhanVien',4,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('tiến','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Belfast','0800 1111','8780672','311265','NhanVien',6,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('như','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Oslo','(0117) 384 5045','2293600','57727','NhanVien',4,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('mận','N?',to_date('07/06/2013','DD/MM/YYYY'),'Franeker','(010772) 68736','1652360','916699','NhanVien',3,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('như','N?',to_date('07/06/2013','DD/MM/YYYY'),'Retford','0845 46 48','9351740','909838','NhanVien',3,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('sơn','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Lerum','(027) 2356 4862','6168514','155478','NhanVien',4,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('yến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Pretoria','076 8387 4740','8301051','550009','NhanVien',5,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thành','Nam',to_date('07/06/2013','DD/MM/YYYY'),'İslahiye','(024) 7167 0546','5422991','835961','NhanVien',6,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('sơn','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Ghotki','0975 507 8816','688485','895654','NhanVien',4,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('út','N?',to_date('07/06/2013','DD/MM/YYYY'),'Kimberley','0800 215 7980','3599162','885261','NhanVien',2,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('thành','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Nicoya','076 7293 5414','1804272','852135','NhanVien',6,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('chi','N?',to_date('07/06/2013','DD/MM/YYYY'),'Blue Mountains','07729 473587','1154675','504101','NhanVien',6,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('hải','N?',to_date('07/06/2013','DD/MM/YYYY'),'Tianjin','0316 135 2274','4442772','623625','NhanVien',6,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('yến','N?',to_date('07/06/2013','DD/MM/YYYY'),'Sargodha','0982 582 7274','5527026','782275','NhanVien',6,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thành','Nam',to_date('07/06/2013','DD/MM/YYYY'),'San Jose','(01541) 758478','9269317','726072','NhanVien',4,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('kết','N?',to_date('07/06/2013','DD/MM/YYYY'),'Brakpan','0800 1111','8802319','871480','NhanVien',5,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('chi','N?',to_date('07/06/2013','DD/MM/YYYY'),'Jaén','070 2747 9493','8992016','32002','NhanVien',3,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mai','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Ghizer','070 0685 0466','5991093','651313','NhanVien',5,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hải','N?',to_date('07/06/2013','DD/MM/YYYY'),'Saintes','0377 856 3413','1455084','960195','NhanVien',2,'MuaBan','MienBac');
EXECUTE sp_ThemNhanVien_AD ('mít','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Bicester','0800 1111','7882709','730289','NhanVien',7,'SanXuat','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('quyết','N?',to_date('07/06/2013','DD/MM/YYYY'),'Manukau','055 4410 9228','8111363','778787','NhanVien',5,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('yến','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Tebing Tinggi','07355 615144','5835016','160712','NhanVien',8,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hà','N?',to_date('07/06/2013','DD/MM/YYYY'),'Queenstown','0800 823 5842','9630085','923821','NhanVien',7,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('mai','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Sousa','(0161) 937 6751','6675551','6454','NhanVien',4,'GiaCong','MienBac');
EXECUTE sp_ThemNhanVien_AD ('dưa','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Thames','07624 688039','1353393','548868','NhanVien',4,'MuaBan','MienNam');
EXECUTE sp_ThemNhanVien_AD ('phong','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Juárez','0385 227 3778','4365119','588519','NhanVien',4,'SanXuat','MienBac');
EXECUTE sp_ThemNhanVien_AD ('cận\','N?',to_date('07/06/2013','DD/MM/YYYY'),'Bollnäs','07624 425777','5660781','878401','NhanVien',4,'GiaCong','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('tiến','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Laoag','070 3878 1875','8387434','374085','NhanVien',7,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('thảo','N?',to_date('07/06/2013','DD/MM/YYYY'),'Gifhorn','0800 234 5258','9639572','842403','NhanVien',4,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('minh','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Dillingen','(0171) 102 4821','8486597','304237','NhanVien',4,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('ý','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Mjölby','(011166) 13266','8793578','504328','NhanVien',8,'GiaCong','MienNam');
EXECUTE sp_ThemNhanVien_AD ('phước','N?',to_date('07/06/2013','DD/MM/YYYY'),'San José','070 8472 1851','2048141','159541','NhanVien',8,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hông','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Kimberley','0898 928 5018','8816856','898794','NhanVien',5,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('thành','N?',to_date('07/06/2013','DD/MM/YYYY'),'Iguala','0800 1111','7494612','7725','NhanVien',7,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('hải','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Caucaia','0392 607 3382','3158322','574613','NhanVien',1,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('xoài','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Seydişehir','(01868) 795025','5672728','590716','NhanVien',6,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('mít','N?',to_date('07/06/2013','DD/MM/YYYY'),'Neustadt','(01613) 39727','5517492','692296','NhanVien',6,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('thảo','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Cunco','(0118) 348 7110','64222','269540','NhanVien',3,'MuaBan','MienTrung');
EXECUTE sp_ThemNhanVien_AD ('xoài','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Melilla','(028) 6814 8056','5424626','668986','NhanVien',8,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('như','N?',to_date('07/06/2013','DD/MM/YYYY'),'�?ódź','056 0571 5426','107583','173915','NhanVien',7,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('đạt','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Quesada','(016977) 4968','1583724','496055','NhanVien',4,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('hùng','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Santu Lussurgiu','(016977) 6036','7557176','646447','NhanVien',7,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('huy�?n','N?',to_date('07/06/2013','DD/MM/YYYY'),'Szczecin','(016977) 4233','3173849','849524','NhanVien',3,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('minh','N?',to_date('07/06/2013','DD/MM/YYYY'),'Dosquebradas','070 4982 2534','5085288','168589','NhanVien',6,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('mít','Nam',to_date('07/06/2013','DD/MM/YYYY'),'Mora','0500 197337','9715527','90761','NhanVien',6,'SanXuat','MienNam');
EXECUTE sp_ThemNhanVien_AD ('út','N?',to_date('07/06/2013','DD/MM/YYYY'),'Traun','(016977) 7717','5890871','248996','NhanVien',5,'SanXuat','MienNam');


INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (284,2,to_date('04/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (33,1,to_date('02/06/2023', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (230,2,to_date('11/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (131,3,to_date('02/06/2023', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (197,2,to_date('02/06/2023', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (38,1,to_date('09/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (224,2,to_date('12/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (277,1,to_date('06/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (287,3,to_date('02/06/2023', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (3,1,to_date('04/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (175,2,to_date('12/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (293,3,to_date('05/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (275,1,to_date('07/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (163,1,to_date('11/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (298,1,to_date('08/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (18,2,to_date('11/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (283,2,to_date('09/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (186,2,to_date('07/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (56,1,to_date('05/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (37,3,to_date('08/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (235,3,to_date('07/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (171,3,to_date('05/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (77,3,to_date('02/06/2023', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (228,3,to_date('02/06/2023', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (107,2,to_date('02/06/2023', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (247,1,to_date('06/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (127,2,to_date('02/06/2023', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (31,2,to_date('12/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (12,1,to_date('05/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (243,3,to_date('06/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (32,2,to_date('06/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (50,1,to_date('01/06/2023', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (36,2,to_date('07/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (207,3,to_date('07/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (168,1,to_date('02/06/2023', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (73,1,to_date('11/06/2022', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (78,1,to_date('02/06/2023', 'DD/MM/YYYY'));
INSERT INTO PHANCONG (MANV,MADA,THOIGIAN)
VALUES (95,3,to_date('11/06/2022', 'DD/MM/YYYY'));









