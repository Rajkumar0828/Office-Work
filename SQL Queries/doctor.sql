Create database HospitalManagementDB;
SET SQL_SAFE_UPDATES = 0;
create table patient(
Patient_ID int primary key auto_increment  Not Null,
Patient_Name Varchar(30),
Age  int ,
Patient_case varchar(30)
);
select * from patient;

