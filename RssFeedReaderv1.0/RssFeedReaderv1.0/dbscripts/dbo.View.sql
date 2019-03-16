CREATE VIEW [dbo].[ItemsWithRssLink]
	AS 
		SELECT
			p.Id,
            b.rssLink,
            p.Itemtitle,
            p.Itemcontent
		FROM
			dbo.Items p
		INNER JOIN dbo.rsslinks b 
				ON b.Id = p.Idrsslinks;
