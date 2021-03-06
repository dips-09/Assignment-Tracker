USE [DBHomework5]
GO
/****** Object:  Table [dbo].[Assignments]    Script Date: 11/20/2020 6:12:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assignments](
	[AssignmentId] [int] IDENTITY(1,1) NOT NULL,
	[Priority] [int] NOT NULL,
	[DueDate] [datetime2](7) NOT NULL,
	[CourseName] [nvarchar](max) NOT NULL,
	[AssignmentTitle] [nvarchar](max) NOT NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_Assignments] PRIMARY KEY CLUSTERED 
(
	[AssignmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
