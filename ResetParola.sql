create  procedure ResetParola
 
@Email varchar(50),
@Parola varchar(50)

As
  BEGIN
    UPDATE Utilizatori
	    SET Parola=@Parola
		    WHERE Email = @Email
end


  