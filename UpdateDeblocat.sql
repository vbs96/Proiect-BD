create  procedure UpdateDeblocat  @Email nvarchar(50) 
As
  BEGIN
    UPDATE Utilizatori
	    SET Blocat='false'
    WHERE Email = @Email
end



  