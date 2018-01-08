
CREATE procedure AddAdmini
@Username nvarchar(50),
@Parola nvarchar(50)
as
insert
into dbo.Administratori(Username,Parola) values (@Username,@Parola)
