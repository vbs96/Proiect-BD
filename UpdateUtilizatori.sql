create  procedure UpdateUtilizatori
 
@Email varchar(50),
@Nume varchar(50),
@Prenume varchar(50),
@Sex varchar(50),
@Telefon varchar(10),
@DataNastere datetime,
@Parola varchar(50),
@Blocat bit 
As
  BEGIN
    UPDATE Utilizatori
	    SET Nume=@Nume,Prenume=@Prenume,Sex=@Sex,Telefon=@Telefon,DataNastere=@DataNastere,Parola=@Parola,Blocat=@Blocat
		    WHERE Email = @Email
end


  