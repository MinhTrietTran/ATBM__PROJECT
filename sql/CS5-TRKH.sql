

-- Cấp quyền xem cho vai trò giảng viên trên các bảng cần thiết (ví dụ)
GRANT SELECT ON SINHVIEN TO GIANGVIEN;
GRANT SELECT ON HOCPHAN TO GIANGVIEN;
-- Các quyền khác nếu cần
CREATE ROLE TRUONGKHOA;
GRANT GIANGVIEN TO TRUONGKHOA;


-- Thêm quyền thêm, xóa, cập nhật trên bảng PHANCONG
GRANT SELECT, INSERT, UPDATE, DELETE ON PHANCONG TO TRUONGKHOA;

-- Thêm quyền xem, thêm, xóa, cập nhật trên bảng NHANSU
GRANT SELECT, INSERT, UPDATE, DELETE ON NHANSU TO TRUONGKHOA;

-- Thêm quyền xem toàn bộ lược đồ
GRANT SELECT ANY TABLE TO TRUONGKHOA;

-- Tạo người dùng TRUONG_KHOA với mật khẩu là '1'
CREATE USER TRUONG_KHOA IDENTIFIED BY 1;

-- Cấp vai trò TRUONGKHOA cho người dùng TRUONG_KHOA
GRANT TRUONGKHOA TO TRUONG_KHOA;

-- Cấp quyền CREATE SESSION cho người dùng TRUONG_KHOA để có thể đăng nhập
GRANT CREATE SESSION TO TRUONG_KHOA;

CREATE OR REPLACE FUNCTION policy_func_rls_truongkhoa (schema_name IN VARCHAR2, table_name IN VARCHAR2)
RETURN VARCHAR2 IS
  v_predicate VARCHAR2(4000);
BEGIN
  v_predicate := 'VAITRO = ''Trưởng khoa'' OR 
                 (VAITRO = ''Giảng viên'' AND 
                  EXISTS (SELECT 1 FROM DONVI D 
                          WHERE D.MAĐV = ''Văn phòng khoa'' AND 
                                D.TRGĐV = (SELECT MAGV FROM PHANCONG P 
                                           WHERE P.MAHP = HOCPHAN.MAHP AND 
                                                 P.MAGV = D.TRGĐV)))';
  RETURN v_predicate;
END;

-- Thêm chính sách RLS cho bảng PHANCONG cho vai trò TRUONGKHOA
BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'CAMPUSADMIN',  -- Schema của bảng PHANCONG
    object_name     => 'PHANCONG',    -- Tên của bảng
    policy_name     => 'phancong_rls_truongkhoa',
    function_schema => 'TRUONG_KHOA',  -- Schema của hàm chính sách
    policy_function => 'policy_func_rls_truongkhoa',
    statement_types => 'SELECT,INSERT, DELETE, UPDATE', -- Các loại câu lệnh áp dụng chính sách
    update_check => TRUE
  );
END;
/
-- test xóa policy
BEGIN
  DBMS_RLS.DROP_POLICY (
    object_schema   => 'CAMPUSADMIN',  -- Schema của bảng
    object_name     => 'PHANCONG',     -- Tên của bảng
    policy_name     => 'phancong_rls_truongkhoa'  -- Tên của chính sách cần xóa
  );
END;
/

SELECT table_name, owner
FROM all_tables
WHERE table_name = 'PHANCONG';


-- Kiểm tra quyền xem trên bảng NHANSU
SELECT * FROM CAMPUSADMIN.NHANSU;

-- Kiểm tra quyền thêm, xóa, cập nhật trên bảng PHANCONG
INSERT INTO CAMPUSADMIN.PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES ('NV04', 'HP06', 1, 2023, 'CT06');
DELETE FROM CAMPUSADMIN.PHANCONG WHERE MAHP = 'HP06';
UPDATE CAMPUSADMIN.PHANCONG SET HK = 2 WHERE MAHP = 'HP01';

-- Kiểm tra quyền xem toàn bộ lược đồ
SELECT * FROM CAMPUSADMIN.SINHVIEN;
SELECT * FROM CAMPUSADMIN.HOCPHAN;

