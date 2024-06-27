
-- Bật chế độ nhật ký (Archive Log Mode):
SHUTDOWN IMMEDIATE;
STARTUP MOUNT;
ALTER DATABASE ARCHIVELOG;
ALTER DATABASE OPEN;

--Khởi động RMAN:
rman target /
--Cấu hình vị trí sao lưu:
CONFIGURE DEFAULT DEVICE TYPE TO DISK;
CONFIGURE DEVICE TYPE DISK PARALLELISM 2 BACKUP TYPE TO BACKUPSET;
CONFIGURE CHANNEL DEVICE TYPE DISK FORMAT '/backup/%U';

--Sao lưu toàn bộ cơ sở dữ liệu:
BACKUP DATABASE PLUS ARCHIVELOG;
--Sao lưu gia tăng:
BACKUP INCREMENTAL LEVEL 1 DATABASE;

--Sao lưu bằng Data Pump:
expdp sys/123456@orcl schemas=your_schema directory=dpump_dir dumpfile=full_%U.dmp logfile=expdp.log

--Phục hồi toàn bộ cơ sở dữ liệu:
SHUTDOWN IMMEDIATE;
STARTUP MOUNT;
RESTORE DATABASE;
RECOVER DATABASE;
ALTER DATABASE OPEN;

--Phục hồi theo thời gian:
RUN {
  SET UNTIL TIME 'YYYY-MM-DD HH24:MI:SS';
  RESTORE DATABASE;
  RECOVER DATABASE;
  ALTER DATABASE OPEN RESETLOGS;
}

--Phục hồi bằng Data Pump:
impdp system/password@orcl schemas=your_schema directory=dpump_dir dumpfile=full_%U.dmp logfile=impdp.log
