USE master ;  
GO  
BEGIN
IF EXISTS(select * from sys.databases where name='dbRss')
begin
	alter database [dbRss] set single_user with rollback immediate
	DROP DATABASE [dbRss]
end


CREATE DATABASE dbRss  
ON   
( NAME = dbRss_dat,  
    FILENAME = 'E:\databases\dbRss.mdf',  
    SIZE = 10,  
    MAXSIZE = 50,  
    FILEGROWTH = 5 )  
LOG ON  
( NAME = dbRss_log,  
    FILENAME = 'E:\databases\dbRss_log.ldf',  
    SIZE = 5MB,  
    MAXSIZE = 25MB,  
    FILEGROWTH = 5MB ) ;  
END
GO

use dbRss
Go
BEGIN
CREATE TABLE [dbo].[ItemsNews] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [title]   NVARCHAR (MAX) NULL,
    [content] NVARCHAR (MAX) NULL,
    [date]    DATETIME       NULL,
    [linkId]  INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[links] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [link] NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
END

use dbRss
Go

CREATE PROCEDURE [dbo].[insertRssLink]
	@link nvarchar(MAX)
AS
if not exists(SELECT id
				FROM links
				WHERE link = @link)
begin
	insert into links (link) values( @link)  
end
RETURN 0

GO
use dbRss
Go

CREATE PROCEDURE [dbo].[insertRssItem]
	@title nvarchar(MAX),
	@content nvarchar(MAX),
	@link nvarchar(MAX)
AS
	DECLARE @ReturnValue int
	SELECT @ReturnValue=id FROM links WHERE link = @link
	IF not EXISTS(SELECT id FROM dbo.ItemsNews WHERE title = @title)
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

