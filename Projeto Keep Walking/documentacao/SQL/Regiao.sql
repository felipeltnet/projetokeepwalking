USE [ProjetoKeepWalking]
GO

/****** Object:  Table [dbo].[Regiao]    Script Date: 17/12/2015 14:54:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Regiao](
	[idRegiao] [int] IDENTITY(1,1) NOT NULL,
	[nomeRegiao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Regiao] PRIMARY KEY CLUSTERED 
(
	[idRegiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

