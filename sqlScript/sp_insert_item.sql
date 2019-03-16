CREATE PROCEDURE [dbo].[insertRssItem]
	@title nvarchar(MAX),
	@content nvarchar(MAX),
	@date datetime,
	@link nvarchar(MAX)
AS
	DECLARE @ReturnValue int
	SELECT @ReturnValue=id FROM links WHERE link = @link
	IF EXISTS(SELECT * FROM dbo.ItemsNews WHERE title = @title)
	BEGIN
		INSERT INTO dbo.ItemsNews
		(
		    title,
		    content,
			date,
		    linkId
		)
		VALUES
		(   @title, -- title - nvarchar(max)
		    @content, -- content - nvarchar(max)
		    GETDATE(), -- date - datetime
		    @ReturnValue          -- linkId - int
		    )
	end
RETURN 0
