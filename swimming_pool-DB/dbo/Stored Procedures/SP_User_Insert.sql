CREATE PROCEDURE [dbo].[SP_User_Insert]
	 @firstName NVARCHAR (50), 
     @lastName  NVARCHAR (50),
     @telephone NCHAR (12),
     @email     NVARCHAR (323),
     @password NVARCHAR(MAX), 
     @userName NCHAR(10)
AS
    DECLARE @salt CHAR(8)
    SET @salt = [dbo].SF_GenerateSalt()
	INSERT INTO [User] ([FirstName],[LastName], [Telephone], [Email], [Password], [Salt], [Username]) 
    OUTPUT inserted.IdUser
    VALUES (@firstName, @lastName, @telephone ,@email ,dbo.SF_EncryptedPassword(@password, @salt), @salt, @userName)
