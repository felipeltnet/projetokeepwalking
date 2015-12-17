USE [ProjetoKeepWalking]
GO

/****** Object:  Table [dbo].[Mensagem]    Script Date: 17/12/2015 14:53:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Mensagem](
	[idFale] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[assunto] [varchar](50) NOT NULL,
	[mensagem] [varchar](300) NOT NULL,
 CONSTRAINT [PK_Mensagem] PRIMARY KEY CLUSTERED 
(
	[idFale] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Mensagem]  WITH CHECK ADD  CONSTRAINT [FK_Mensagem_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO

ALTER TABLE [dbo].[Mensagem] CHECK CONSTRAINT [FK_Mensagem_Usuarios]
GO

