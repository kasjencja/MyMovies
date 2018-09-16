CREATE TABLE [dbo].[Table] (
    [movieID]      INT           IDENTITY (1, 1) NOT NULL,
    [name]         VARCHAR (200) NOT NULL,
    [director]     VARCHAR (200) NULL,
    [seen]         BIT           DEFAULT ((0)) NULL,
    [rating]       TINYINT       NULL,
    [poster]       VARCHAR (300) NULL,
    [watchingDate] DATE          NULL,
	[localization] VARCHAR(100)	 NOT NULL,
	[genre]		   VARCHAR(100)  NULL,
    PRIMARY KEY CLUSTERED ([movieID] ASC)
);