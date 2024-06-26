-- ==============AUDIT==============

-- Kích ho?t vi?c ghi nh?t ký h? th?ng
ALTER SYSTEM SET audit_trail = db, EXTENDED SCOPE = SPFILE;

-- Kh?i ??ng l?i c? s? d? li?u ?? thay ??i có hi?u l?c
SHUTDOWN IMMEDIATE;
STARTUP;
