CREATE DATABASE LexFacturation

use  [C:\USERS\DELL\DOWNLOADS\FACTURATION\DATABASEF.MDF]
use master


delete from login





DROP TABLE [dbo].[detail]
go
DROP TABLE [dbo].[totale]
go
DROP TABLE [dbo].[factureDevis]
go
DROP TABLE [dbo].[societe]

use master
create table login (
id int primary key ,
userName nvarchar(50),
password nvarchar(50),
)

insert into login values(1,'admin','admin')
use LexFacturation
 use master
 delete from societe
 INSERT INTO societe VALUES (1,'STE LEX CONNECT SARL','LEX','refAbv','109133','47250620','002648282000033','AV MOULAY ISMAIL RES MOULAY ISMAIL N°22 5éme ETG N°19  TANGER','06 61 11 64 17', NULL  )
create table societe (
idS int primary key  ,
societeName nvarchar(50),
AbrvName nvarchar(50),
REF_syntax nvarchar(50),
RC nvarchar(50),
i_F nvarchar(50),
ICE nvarchar(50),
SiegeSocial nvarchar(max),
Telephone nvarchar(50),
brand  varbinary(max)
)

INSERT INTO societe (idS,Telephone,brand) values (1,'0618482799', (SELECT * FROM OPENROWSET(BULK N'C:\Plan-de-travail-2.png', SINGLE_BLOB) as T1))

select * from societe


Reference Date_facture Destinateur


create table factureDevis (
idF int primary key identity ,
Reference nvarchar(50),
Type nvarchar(50),
Date_facture nvarchar(50), --date facture
Destinateur nvarchar(50),
ICE_Destinateur nvarchar(50),
idS int foreign key references  societe(idS),
)
select SUM(Total_ligne) as sous_total    FROM detail where IDF_fk =3

create table detail (
idd int primary key identity ,
Quantite float,
prix_unitaire float,
Total_ligne AS Quantite * prix_unitaire ,
description nvarchar(200),
IDF_fk int foreign key references factureDevis(idF),
idT int foreign key references totale(idT),
)
insert into factureDevis (Reference)  values('dfdf')
insert into detail (Quantite,prix_unitaire,IDF_fk)  values(5,9850,1)

create table totale (
idT int primary key identity ,
sous_total float,
TVA AS (sous_total*0.2),
TOTALE  AS (sous_total + (sous_total*0.2)) ,
IDF_fk int foreign key references factureDevis(idF),
)
insert into totale (sous_total) values(30.5)

select max(idT) from totale
create table t_function (
idF int primary key   ,
column1 nvarchar(50) ,
column2 nvarchar(50) ,

)

delete from login
delete from t_function




update  totale set  sous_total=22 where IDF_fk=1




 
