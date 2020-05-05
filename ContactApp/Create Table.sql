USE [Contacts]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 1/29/2017 11:54:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[ContactName] [nvarchar](50) NOT NULL,
	[ContactEmail] [nvarchar](50) NULL,
	[ContactPhoneType] [nvarchar](50) NULL,
	[ContactPhoneNumber] [nvarchar](50) NULL,
	[ContactAge] [int] NOT NULL,
	[ContactNotes] [nvarchar](1000) NULL,
    [ContactCreatedDate] [datetime] NOT NULL CONSTRAINT [DF_Contact_ContactCreatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, 
IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO