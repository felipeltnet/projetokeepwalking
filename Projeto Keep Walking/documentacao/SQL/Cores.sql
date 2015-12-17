USE [ProjetoKeepWalking]
GO

/****** Object:  Table [dbo].[Cores]    Script Date: 17/12/2015 14:52:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Cores](
	[idCor] [int] IDENTITY(1,1) NOT NULL,
	[nomeCor] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cores] PRIMARY KEY CLUSTERED 
(
	[idCor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

