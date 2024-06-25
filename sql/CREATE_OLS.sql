ALTER SESSION SET CONTAINER = CAMPUSPDB;
ALTER PLUGGABLE DATABASE CAMPUSPDB OPEN;

SELECT VALUE FROM v$option WHERE parameter = 'Oracle Label Security';
SELECT status FROM dba_ols_status WHERE name = 'OLS_CONFIGURE_STATUS';

EXEC LBACSYS.CONFIGURE_OLS; 
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS; 

SHUTDOWN IMMEDIATE;
STARTUP; 

select * from v$services; 

---> CHUY?N QUA PDB
ALTER SESSION SET CONTAINER= CAMPUSPDB;
SHOW CON_NAME; 

CREATE USER ADMIN_OLS IDENTIFIED BY 123 CONTAINER = CURRENT;
GRANT CONNECT,RESOURCE TO ADMIN_OLS; --C?P QUY?N CONNECT VÀ RESOURCE
GRANT UNLIMITED TABLESPACE TO ADMIN_OLS; --C?P QUOTA CHO ADMIN_OLS
GRANT SELECT ANY DICTIONARY TO ADMIN_OLS; --C?P QUY?N ??C DICTIONARY
---> C?P QUY?N EXECUTE CHO ADMIN_OLS
GRANT EXECUTE ON LBACSYS.SA_COMPONENTS TO ADMIN_OLS WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.sa_user_admin TO ADMIN_OLS WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.sa_label_admin TO ADMIN_OLS WITH GRANT OPTION;
GRANT EXECUTE ON sa_policy_admin TO ADMIN_OLS WITH GRANT OPTION;
GRANT EXECUTE ON char_to_label TO ADMIN_OLS WITH GRANT OPTION; 

---> ADD ADMIN_OLS VÀO LBAC_DBA
GRANT LBAC_DBA TO ADMIN_OLS;
GRANT EXECUTE ON sa_sysdba TO ADMIN_OLS;
GRANT EXECUTE ON TO_LBAC_DATA_LABEL TO ADMIN_OLS; 

-- Tao user va gan quyen can thiet trong PDB 
CREATE USER TKH001 IDENTIFIED BY TKH001; --Truong khoa
CREATE USER TBM001 IDENTIFIED BY TBM001; --Truong bo mon co 2
CREATE USER TBM002 IDENTIFIED BY TBM002; --Truong bo mon HTTT co so 1
CREATE USER TBM003 IDENTIFIED BY TBM003; --Truong bo mon HTTT co so 2
CREATE USER TBM004 IDENTIFIED BY TBM004; --Truong bo mon KHMT co so 1 
CREATE USER TBM005 IDENTIFIED BY TBM005; --Truong bo mon KHMT co so 2 
CREATE USER GVU001 IDENTIFIED BY GVU001; --Giao vu co so 2
CREATE USER SVI001 IDENTIFIED BY SVI001; --Sinh vien HTTT Co so 1

CREATE USER NV106 IDENTIFIED BY NV106;    -- Truong khoa
CREATE USER NV100 IDENTIFIED BY NV100;    -- Truong bo mon co 2
CREATE USER NV101 IDENTIFIED BY NV101;    -- Truong bo mon HTTT co so 1
CREATE USER NV102 IDENTIFIED BY NV102;    -- Truong bo mon HTTT co so 2
CREATE USER NV103 IDENTIFIED BY NV103;    -- Truong bo mon KHMT co so 1
CREATE USER NV104 IDENTIFIED BY NV104;    -- Truong bo mon KHMT co so 2
CREATE USER NV091 IDENTIFIED BY NV091;    -- GIAO VU CS2
CREATE USER SV001 IDENTIFIED BY SV001;  -- Sinh vien HTTT co so 1

GRANT CONNECT TO TKH001, TBM001, TBM002, TBM003, TBM004, TBM005, GVU001, SVI001, NV106, NV100, NV101, NV102, NV103, NV104, NV091, SV001;


GRANT INHERIT PRIVILEGES ON USER ADMIN_OLS TO LBACSYS;
GRANT INHERIT PRIVILEGES ON USER SYS TO LBACSYS;


--------------------------------------------------------------------------------------------------------
-- KET NOI VOI ADMIN OLS
BEGIN
 SA_SYSDBA.CREATE_POLICY(
 policy_name => 'region_policy',
 column_name => 'region_label'
);
END;
/

EXEC SA_SYSDBA.ENABLE_POLICY ('region_policy'); 

----------------------------------------------------------------------------------------------------------
-- KHOI DONG LAI SQLDEV --> KET NOI VOI ADMIN_OLS

--level: Tr??ng khoa > Tr??ng ??n v? > Gi?ng viên > Giáo v? > Nhân viên > Sinh viên.
--compartment: HTTT, CNPM, KHMT, CNTT, TGMT, MMT.
--Group: CS1, CS2

--->T?O LEVEL 
EXECUTE SA_COMPONENTS.CREATE_LEVEL('region_policy',9000,'TRGK','TRUONG KHOA');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('region_policy',8000,'TRGDV','TRUONG DON VI');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('region_policy',7000,'GVIEN','GIANG VIEN');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('region_policy',6000,'GVU','GIAO VU');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('region_policy',5000,'NV','NHAN VIEN');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('region_policy',4000,'SV','SINH VIEN');

-- T?O COMPARTMENT 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('region_policy',100,'HTTT','HE THONG THONG TIN');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('region_policy',110,'CNPM','CONG NGHE PHAN MEM'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('region_policy',120,'KHMT','KHOA HOC MAY TINH');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('region_policy',130,'CNTT','CONG NGHE THONG TIN');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('region_policy',140,'TGMT','THI GIAC MAY TINH');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('region_policy',150,'MMT','MANG MAY TINH');

--->T?O GROUP
EXECUTE SA_COMPONENTS.CREATE_GROUP('region_policy',20,'CS1','CO SO 1');
EXECUTE SA_COMPONENTS.CREATE_GROUP('region_policy',40,'CS2','CO SO 2'); 


/
CREATE TABLE THONGBAO(
    MATB NUMBER,
    NOIDUNG VARCHAR2(2000),
    DIADIEM VARCHAR2(100),
    CONSTRAINT PK_TB PRIMARY KEY (MATB)
);
/
INSERT INTO THONGBAO (MATB, NOIDUNG, DIADIEM) VALUES (1, N'Day la thong bao cho truong bo mon httt co so 1', N'Co so 1');
INSERT INTO THONGBAO (MATB, NOIDUNG, DIADIEM) VALUES (2, N'Day la thong bao den truong bo mon httt co so 2 ', N'Co so 2');
INSERT INTO THONGBAO (MATB, NOIDUNG, DIADIEM) VALUES (3, N'Day la thong bao cho giao vu co so 2', N'Co so 2');
INSERT INTO THONGBAO (MATB, NOIDUNG, DIADIEM) VALUES (4, N'Day la thong bao cho toan bo truong don vi', N'');
INSERT INTO THONGBAO (MATB, NOIDUNG, DIADIEM) VALUES (5, N'Day la thong bao cho sinh vien nganh HTTT co so 1', N'Co so 1');
INSERT INTO THONGBAO (MATB, NOIDUNG, DIADIEM) VALUES (6, N'Day la thong bao den cho truong bo mon KHMT co so 1', N'Co so 1');
INSERT INTO THONGBAO (MATB, NOIDUNG, DIADIEM) VALUES (7, N'Day la thong bao den cho truong bo mon KHMT co so 1 va co so 2', N'Co so 1 va Co so 2');
INSERT INTO THONGBAO (MATB, NOIDUNG, DIADIEM) VALUES (8, N'Day la thong bao cho giao vu co so 1', N'Co so 1');
/

-- Truong khoa doc duoc toan bo thong bao
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('region_policy', 1000, 'TRGK'); 
-- Truong bo mon doc thong bao cho truong bo mon HTTT CS1
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('region_policy', 900, 'TRGDV:HTTT:CS1'); 
-- Truong bo mon doc thong bao cho truong bo mon HTTT CS2
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('region_policy', 890, 'TRGDV:HTTT:CS2'); 
-- Truong bo mon doc thong bao cho truong bo mon KHMT CS1
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('region_policy', 880, 'TRGDV:KHMT:CS1'); 
-- Truong bo mon doc thong bao cho truong bo mon KHMT CS1 va CS2
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('region_policy', 870, 'TRGDV:KHMT:'); 
-- Truong bo mon doc toan bo thong bao cho truong bo mon
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('region_policy', 860, 'TRGDV'); 
-- Giao vu doc toan bo thong bao cho giao vu
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('region_policy', 700, 'GVU'); 
-- Giao vu doc thong bao cho giao vu co so 2
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('region_policy', 710, 'GVU::CS2'); 
-- Sinh vien CS1
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('region_policy', 600, 'SV::CS1'); 
-- Sinh vien CS2
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('region_policy', 590, 'SV::CS2'); 
-- Sinh vien
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('region_policy', 580, 'SV'); 
/
BEGIN
    SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
    POLICY_NAME => 'REGION_POLICY',
    SCHEMA_NAME => 'ADMIN_OLS',
    TABLE_NAME => 'THONGBAO',
    TABLE_OPTIONS => 'NO_CONTROL'
    );
END; 
/

UPDATE THONGBAO
SET region_label = CHAR_TO_LABEL('REGION_POLICY','TRGDV:HTTT:CS1')
WHERE MATB = 1;

UPDATE THONGBAO
SET region_label = CHAR_TO_LABEL('REGION_POLICY','TRGDV:HTTT:CS2')
WHERE MATB = 2;

UPDATE THONGBAO
SET region_label = CHAR_TO_LABEL('REGION_POLICY','GVU::CS2')
WHERE MATB = 3;

UPDATE THONGBAO
SET region_label = CHAR_TO_LABEL('REGION_POLICY','TRGDV')
WHERE MATB = 4;

UPDATE THONGBAO
SET region_label = CHAR_TO_LABEL('REGION_POLICY','SV:HTTT:CS1') 
WHERE MATB = 5;

UPDATE THONGBAO
SET region_label = CHAR_TO_LABEL('REGION_POLICY','TRGDV:KHMT:CS1') 
WHERE MATB = 6;

UPDATE THONGBAO
SET region_label = CHAR_TO_LABEL('REGION_POLICY','TRGDV:KHMT') 
WHERE MATB = 7;

UPDATE THONGBAO
SET region_label = CHAR_TO_LABEL('REGION_POLICY','GVU::CS1') 
WHERE MATB = 8;

COMMIT;
/
BEGIN
    SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('REGION_POLICY','ADMIN_OLS','THONGBAO');
    SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
    policy_name => 'REGION_POLICY',
    schema_name => 'ADMIN_OLS',
    table_name => 'THONGBAO',
    table_options => 'READ_CONTROL',
    predicate => NULL
);
END;
--select name, status, description from dba_ols_status;

CONNECT ADMIN_OLS/123;
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','TKH001','TRGK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');            -- Truong khoa
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','TBM001','TRGDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');           -- Truong don vi co so 2
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','TBM002','TRGDV:HTTT:CS1');                                       -- Truong don vi HTTT co so 1
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','TBM003','TRGDV:HTTT:CS2');                                       -- Truong don vi HTTT co so 2
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','TBM004','TRGDV:KHMT:CS1');                                       -- Truong don vi KHMT co so 1
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','TBM005','TRGDV:KHMT:CS2');                                       -- Truong don vi KHMT co so 2
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','GVU001','GVU:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');             -- Giao vu co so 2
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','SVI001','SV:HTTT:CS1');                                          -- Sinh vien HTTT Co so 1
    
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','NV106','TRGK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');              -- Truong khoa doc toan bo thong bao
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','NV100','TRGDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');             -- Truong don vi doc duoc toan bo thong bao
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','NV101','TRGDV:HTTT:CS1');                                         -- Truong don vi doc duoc thong bao cho HTTT CS1 
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','NV102','TRGDV:HTTT:CS2');                                         -- Truong don vi HTTT co so 2
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','NV103','TRGDV:KHMT:CS1');                                         -- Truong don vi KHMT co so 1
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','NV104','TRGDV:KHMT:CS2');                                         -- Truong don vi KHMT co so 2
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','NV091','GVU:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');               -- Giao vu doc toan bo thong bao danh cho giao vu
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','SV001','SV:HTTT:CS1');                                           -- Sinh vien HTTT Co so 1
    
END; 
COMMIT;
CONNECT SYS/sys123 AS SYSDBA;
ALTER SESSION SET CONTAINER = CAMPUSPDB;
GRANT SELECT ON ADMIN_OLS.THONGBAO TO TKH001, TBM001, TBM002, TBM003, TBM004, TBM005, GVU001, SVI001, NV106, NV100, NV101, NV102, NV103, NV104, NV091, SV001;
---------------------------------------------------------------------------------

























