BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.[User]
	(
	id int NOT NULL IDENTITY (1, 1),
	firstName nchar(50) NOT NULL,
	Name nchar(50) NOT NULL,
	pseudo nchar(50) NULL,
	pwd varchar(MAX) NULL,
	street nchar(50) NULL,
	number int NULL,
	postalCode int NULL,
	town int NULL,
	isPlayer tinyint NULL,
	isResponsableOrganisation tinyint NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
DECLARE @v sql_variant 
SET @v = N'id d''identification unique'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'User', N'COLUMN', N'id'
GO
DECLARE @v sql_variant 
SET @v = N'0 = non / 1 = oui'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'User', N'COLUMN', N'isPlayer'
GO
DECLARE @v sql_variant 
SET @v = N'0 = non / 1 = oui'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'User', N'COLUMN', N'isResponsableOrganisation'
GO
ALTER TABLE dbo.[User] ADD CONSTRAINT
	PK_User PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.[User] SET (LOCK_ESCALATION = TABLE)
GO
COMMIT