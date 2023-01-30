ALTER PROCEDURE dbo.ReturnTableEdit
	@Id nvarchar(10),
	@HomeTeam nvarchar(20),
	@AwayTeam nvarchar(20),
	@Score nvarchar(10),
AS
	
	IF @Id="Add"
	BEGIN
	INSERT INTO tbl_Table
	(HomeTeam,
	AwayTeam,
	Score)
	VALUES
	(@HomeTeam,
	@AwayTeam,
	@Score)

END	
