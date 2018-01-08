create procedure AddUtilizatori

@Nume varchar(50),
@Prenume varchar(50),
@Sex varchar(50),
@Telefon varchar(10),
@DataNastere datetime,
@Email varchar(50),
@Parola varchar(50),
@Blocat bit,
@Interogare varchar(50)

as

insert into dbo.Utilizatori ( Nume,Prenume,Sex,Telefon,DataNastere,Email,Parola,Blocat,Interogare) 
	values(@Nume,@Prenume,@Sex,@Telefon,@DataNastere,@Email,@Parola,@Blocat,@Interogare)
