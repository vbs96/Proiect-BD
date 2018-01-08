create  procedure UpdateBlocat  @Email nvarchar(50) 
As
  BEGIN
    UPDATE Utilizatori
	    SET Blocat='true'
    WHERE Email = @Email
end


  