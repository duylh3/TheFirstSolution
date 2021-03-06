USE [Bidding2nd]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 2021-03-31 3:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Address] [nvarchar](500) NULL,
	[CompanyName] [nvarchar](300) NULL,
	[ShortName] [nvarchar](200) NULL,
	[Description] [nvarchar](50) NULL,
	[CreatedDate] [nvarchar](50) NULL,
	[DeletedDate] [nvarchar](50) NULL,
	[ModifyDate] [nvarchar](50) NULL,
	[IsDeleted] [int] NULL CONSTRAINT [DF_UserInfo_IsDeleted]  DEFAULT ((0)),
	[Role] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'address of company' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo'
GO
