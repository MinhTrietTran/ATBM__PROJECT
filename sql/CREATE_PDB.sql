ALTER SYSTEM SET DB_CREATE_FILE_DEST = '/opt/oracle/product/21c/dbhome_1/oradata';
ALTER SYSTEM SET DB_RECOVERY_FILE_DEST = '/opt/oracle/product/21c/dbhome_1/flash_recovery_area';
ALTER SYSTEM SET DB_RECOVERY_FILE_DEST_SIZE = 100;
ALTER SYSTEM SET DB_CREATE_ONLINE_LOG_DEST_1 = '/opt/oracle/product/21c/dbhome_1/oradata';
    

CREATE PLUGGABLE DATABASE CAMPUSPDB ADMIN USER admin IDENTIFIED BY admin ROLES=(DBA);
ALTER PLUGGABLE DATABASE CAMPUSPDB OPEN READ WRITE FORCE;
 
-- grant privileges
ALTER SESSION SET CONTAINER = CAMPUSPDB;
GRANT CREATE SESSION TO ADMIN CONTAINER=CURRENT;
GRANT SYSDBA TO ADMIN CONTAINER=CURRENT;

CREATE USER CAMPUSPDB IDENTIFIED BY 123;
GRANT CONNECT TO CAMPUSPDB;





