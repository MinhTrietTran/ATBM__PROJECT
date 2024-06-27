CREATE ROLE SINHVIEN;
-- Cấp quyền xem danh sách học phần và kế hoạch mở môn cho vai trò sinh viên
GRANT SELECT ON CAMPUSADMIN.HOCPHAN TO SINHVIEN;
GRANT SELECT ON CAMPUSADMIN.KHMO TO SINHVIEN;
GRANT SELECT ON CAMPUSADMIN.SINHVIEN TO SINHVIEN;
GRANT UPDATE(DCHI,DT) TO SINHVIEN;

-- Cấp quyền thêm và xóa dữ liệu đăng ký học phần cho vai trò sinh viên
GRANT INSERT, DELETE ON DANGKY TO SINHVIEN;

CREATE USER sinh_vien IDENTIFIED BY 1;
GRANT SINHVIEN TO sinh_vien;

CREATE OR REPLACE FUNCTION sinhvien_policy_func (schema_name IN VARCHAR2, table_name IN VARCHAR2)
RETURN VARCHAR2 IS
  v_predicate VARCHAR2(4000);
BEGIN
  -- Sinh viên chỉ được xem thông tin của chính mình
  v_predicate := 'MASV = SYS_CONTEXT(''USERENV'', ''SESSION_USER'')';
  RETURN v_predicate;
END;
/

BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'CAMPUSADMIN',
    object_name     => 'SINHVIEN',
    policy_name     => 'sinhvien_policy',
    function_schema => 'sinh_vien',
    policy_function => 'sinhvien_policy_func',
    statement_types => 'SELECT, UPDATE'
  );
END;
/


CREATE OR REPLACE FUNCTION dangky_policy_func (schema_name IN VARCHAR2, table_name IN VARCHAR2)
RETURN VARCHAR2 IS
  v_predicate VARCHAR2(4000);
BEGIN
  -- Sinh viên chỉ được thêm, xóa dữ liệu đăng ký học phần liên quan đến chính mình và không được chỉnh sửa điểm
  v_predicate := 'MASV = SYS_CONTEXT(''USERENV'', ''SESSION_USER'') AND ' ||
                 'NOT EXISTS (SELECT 1 FROM KHMO WHERE DANGKY.MAHP = KHMO.MAHP 
                 AND DANGKY.HK = KHMO.HK AND DANGKY.NAM = KHMO.NAM AND KHMO.MACT = DANGKY.MACT)';
  RETURN v_predicate;
END;
/

BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'CAMPUSADMIN',
    object_name     => 'DANGKY',
    policy_name     => 'dangky_policy',
    function_schema => 'sinh_vien',
    policy_function => 'dangky_policy_func',
    statement_types => 'INSERT, DELETE'
  );
END;
/

CREATE OR REPLACE TRIGGER trg_dangky_update
BEFORE UPDATE ON DANGKY
FOR EACH ROW
BEGIN
  IF UPDATING('DIEMTH') OR UPDATING('DIEMQT') OR UPDATING('DIEMCK') OR UPDATING('DIEMTK') THEN
    RAISE_APPLICATION_ERROR(-20003, 'Bạn không được phép chỉnh sửa các trường liên quan đến điểm.');
  END IF;
END;
/

CREATE OR REPLACE TRIGGER trg_dangky_insert_delete
BEFORE INSERT OR DELETE ON DANGKY
FOR EACH ROW
DECLARE
  v_start_date DATE;
BEGIN
  IF :NEW.MASV != SYS_CONTEXT('USERENV', 'SESSION_USER') THEN
    RAISE_APPLICATION_ERROR(-20004, 'Bạn chỉ được phép thêm hoặc xóa dữ liệu đăng ký của chính mình.');
  END IF;

  -- Kiểm tra thời gian hiệu chỉnh đăng ký học phần
  SELECT MIN(KHMO.HK_START_DATE)
  INTO v_start_date
  FROM KHMO
  WHERE KHMO.MAHP = :NEW.MAHP
    AND KHMO.HK = :NEW.HK
    AND KHMO.NAM = :NEW.NAM;

  IF SYSDATE > v_start_date + 14 THEN
    RAISE_APPLICATION_ERROR(-20005, 'Thời gian hiệu chỉnh đăng ký đã hết.');
  END IF;
END;
/

-- Kiểm tra quyền xem thông tin của chính mình
SELECT * FROM CAMPUSADMIN.SINHVIEN WHERE MASV = 'SV01';

-- Kiểm tra quyền chỉnh sửa thông tin địa chỉ và số điện thoại
UPDATE CAMPUSADMIN.SINHVIEN SET DCHI = 'New Address', DT = '0123456789' WHERE MASV = 'SV01';

-- Kiểm tra quyền xem danh sách học phần và kế hoạch mở môn
SELECT * FROM CAMPUSADMIN.HOCPHAN;
SELECT * FROM CAMPUSADMIN.KHMO;

-- Kiểm tra quyền thêm, xóa dữ liệu đăng ký học phần
INSERT INTO CAMPUSADMIN.DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT) VALUES ('SV01', 'NV01', 'HP01', 1, 2023, 'CT01');
DELETE FROM CAMPUSADMIN.DANGKY WHERE MASV = 'SV01' AND MAHP = 'HP01';
