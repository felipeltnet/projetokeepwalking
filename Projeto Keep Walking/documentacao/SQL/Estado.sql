USE [ProjetoKeepWalking]
GO

/****** Object:  Table [dbo].[Estado]    Script Date: 17/12/2015 14:53:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Estado](
	[idEstado] [int] IDENTITY(1,1) NOT NULL,
	[idRegiao] [int] NOT NULL,
	[nomeEstado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Estado]  WITH CHECK ADD  CONSTRAINT [FK_Estado_Regiao] FOREIGN KEY([idRegiao])
REFERENCES [dbo].[Regiao] ([idRegiao])
GO

ALTER TABLE [dbo].[Estado] CHECK CONSTRAINT [FK_Estado_Regiao]
GO

