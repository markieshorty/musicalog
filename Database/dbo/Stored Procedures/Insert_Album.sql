CREATE PROCEDURE Insert_Album
	@albumName varchar(255),
    @artist varchar(255),
	@physicalType varchar(10),
	@stock int, 
	@recordLabel varchar(255)
AS
	INSERT INTO Albums
	VALUES (@albumName, @artist, @physicalType, @stock, @recordLabel);
