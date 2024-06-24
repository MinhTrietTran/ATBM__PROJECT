
CREATE ROLE GIANGVIEN;
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

CREATE OR REPLACE FUNCTION policy_func (schema_name IN VARCHAR2, table_name IN VARCHAR2)
RETURN VARCHAR2 IS
  v_predicate VARCHAR2(4000);
BEGIN
  v_predicate := 'VAITRO = ''Trưởng khoa''';
  RETURN v_predicate;
END;

-- Thêm chính sách RLS cho bảng PHANCONG cho vai trò TRUONGKHOA
BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'TRUONG_KHOA',  -- Schema của bảng PHANCONG
    object_name     => 'PHANCONG',    -- Tên của bảng
    policy_name     => 'phancong_policy',
    function_schema => 'TRUONG_KHOA',  -- Schema của hàm chính sách
    policy_function => 'policy_func',
    statement_types => 'SELECT, INSERT, UPDATE, DELETE'  -- Các loại câu lệnh áp dụng chính sách
  );
END;
/

SELECT table_name, owner
FROM all_tables
WHERE table_name = 'PHANCONG';


-- Kiểm tra quyền xem trên bảng NHANSU
SELECT * FROM NHANSU;

-- Kiểm tra quyền thêm, xóa, cập nhật trên bảng PHANCONG
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES ('NV04', 'HP06', 1, 2023, 'CT06');
DELETE FROM PHANCONG WHERE MAHP = 'HP06';
UPDATE PHANCONG SET HK = 2 WHERE MAHP = 'HP01';

-- Kiểm tra quyền xem toàn bộ lược đồ
SELECT * FROM SINHVIEN;
SELECT * FROM HOCPHAN;

