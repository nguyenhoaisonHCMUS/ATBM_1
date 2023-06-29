
--conn lbacsys/123;
EXECUTE sa_sysdba.drop_policy('THONGBAO_OLS_POL');

EXECUTE sa_sysdba.create_policy(policy_name => 'THONGBAO_OLS_POL', column_name => 'OLS_COLUMN');

EXECUTE sa_sysdba.disable_policy('THONGBAO_OLS_POL');
EXECUTE sa_sysdba.enable_policy('THONGBAO_OLS_POL');


-- tao level
--Tao level

begin 
 SA_COMPONENTS.CREATE_LEVEL (policy_name => 'THONGBAO_OLS_POL',level_num => 10,short_name => 'NV',long_name => 'NhanVien');
 SA_COMPONENTS.CREATE_LEVEL (policy_name => 'THONGBAO_OLS_POL',level_num => 20,short_name => 'TP',long_name => 'TruongPhong');
 SA_COMPONENTS.CREATE_LEVEL (policy_name => 'THONGBAO_OLS_POL',level_num => 30,short_name => 'GD',long_name => 'GiamDoc');
end;
/

begin
 SA_COMPONENTS.CREATE_COMPARTMENT (policy_name => 'THONGBAO_OLS_POL',comp_num => 45,short_name => 'MB',long_name => 'MuaBan');
 SA_COMPONENTS.CREATE_COMPARTMENT (policy_name => 'THONGBAO_OLS_POL',comp_num => 65,short_name => 'SX',long_name => 'SanXuat');
 SA_COMPONENTS.CREATE_COMPARTMENT (policy_name => 'THONGBAO_OLS_POL',comp_num => 85,short_name => 'GC',long_name => 'GiaCong');
end;

/
EXECUTE SA_COMPONENTS.CREATE_GROUP (policy_name => 'THONGBAO_OLS_POL',group_num => 200,short_name => 'TCT',long_name => 'TongCongTy');
EXECUTE SA_COMPONENTS.CREATE_GROUP (policy_name => 'THONGBAO_OLS_POL',group_num => 210,short_name => 'MBac',long_name => 'MienBac', parent_name => 'TCT');
EXECUTE SA_COMPONENTS.CREATE_GROUP (policy_name => 'THONGBAO_OLS_POL',group_num => 220,short_name => 'MTrung',long_name => 'MienTrung', parent_name => 'TCT');
EXECUTE SA_COMPONENTS.CREATE_GROUP (policy_name => 'THONGBAO_OLS_POL',group_num => 230,short_name => 'MNam',long_name => 'MienNam', parent_name => 'TCT');
/

EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '100', label_value => 'GD:MB,SX,GC:TCT');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '110', label_value => 'GD:MB,SX,GC:MBac');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '120', label_value => 'GD:MB,SX,GC:MTrung');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '130', label_value => 'GD:MB,SX,GC:MNam');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '140', label_value => 'TP:MB:MBac'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '150', label_value => 'TP:SX:MBac'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '160', label_value => 'TP:GC:MBac');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '170', label_value => 'TP:MB:MTrung'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '180', label_value => 'TP:SX:MTrung'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '190', label_value => 'TP:GC:MTrung'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '200', label_value => 'TP:MB:MNam'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '210', label_value => 'TP:SX:MNam'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '220', label_value => 'TP:GC:MNam'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '230', label_value => 'NV:MB:MBac'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '240', label_value => 'NV:SX:MBac'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '250', label_value => 'NV:GC:MBac');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '260', label_value => 'NV:MB:MTrung'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '270', label_value => 'NV:SX:MTrung'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '280', label_value => 'NV:GC:MTrung'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '290', label_value => 'NV:MB:MNam'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '300', label_value => 'NV:SX:MNam'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_OLS_POL', label_tag => '310', label_value => 'NV:GC:MNam'); 
--
/
--select * from ad.thongbao;
EXECUTE SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('THONGBAO_OLS_POL','AD','THONGBAO');

--ch?y proc get label truoc file6.2

EXECUTE SA_POLICY_ADMIN.APPLY_TABLE_POLICY(policy_name => 'THONGBAO_OLS_POL',schema_name => 'AD',table_name  => 'THONGBAO',table_options => 'NO_CONTROL',label_function => 'AD.GET_THONGBAO_LABEL(:new.VAITRO,:new.LINHVUC,:new.CHINHANH)',predicate => NULL);
/
GRANT SELECT,UPDATE,INSERT,DELETE ON AD.THONGBAO TO role_GiamDoc;
GRANT SELECT,UPDATE,INSERT,DELETE ON AD.THONGBAO TO role_TruongPhong;
GRANT SELECT ON AD.THONGBAO TO role_NhanVien;




 