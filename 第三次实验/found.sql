USE [found]
GO
/****** Object:  Table [dbo].[t_user]    Script Date: 11/09/2020 18:43:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_user](
	[name] [char](10) NOT NULL,
	[nikename] [varchar](100) NULL,
	[pwd] [varchar](50) NULL,
 CONSTRAINT [PK_t_user] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_user', @level2type=N'COLUMN',@level2name=N'name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'昵称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_user', @level2type=N'COLUMN',@level2name=N'nikename'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_user', @level2type=N'COLUMN',@level2name=N'pwd'
GO
/****** Object:  Table [dbo].[t_lostgoods]    Script Date: 11/09/2020 18:43:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_lostgoods](
	[id] [bigint] NOT NULL,
	[goods] [varchar](100) NULL,
	[describe] [varchar](500) NULL,
	[collect_date] [datetime] NULL,
	[collect_addr] [varchar](500) NULL,
	[contact_man] [varchar](50) NULL,
	[contact_phone] [varchar](20) NULL,
	[contact_email] [varchar](50) NULL,
 CONSTRAINT [PK_t_lostgoods] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_lostgoods', @level2type=N'COLUMN',@level2name=N'id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'物品名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_lostgoods', @level2type=N'COLUMN',@level2name=N'goods'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'物品描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_lostgoods', @level2type=N'COLUMN',@level2name=N'describe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'拾获日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_lostgoods', @level2type=N'COLUMN',@level2name=N'collect_date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'拾获地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_lostgoods', @level2type=N'COLUMN',@level2name=N'collect_addr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_lostgoods', @level2type=N'COLUMN',@level2name=N'contact_man'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_lostgoods', @level2type=N'COLUMN',@level2name=N'contact_phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_lostgoods', @level2type=N'COLUMN',@level2name=N'contact_email'
GO
