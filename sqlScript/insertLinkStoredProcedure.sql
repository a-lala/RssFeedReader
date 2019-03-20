use dbRss
Go

CREATE PROCEDURE [dbo].[insertRssLink]
	@link nvarchar(MAX)
AS
if not exists(SELECT COUNT(*)
				FROM links
				WHERE link = @link)
begin
	insert into links (link) values( @link)  
end
RETURN 0
