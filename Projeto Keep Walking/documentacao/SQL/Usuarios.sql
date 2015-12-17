USE [ProjetoKeepWalking]
GO

/****** Object:  Table [dbo].[Usuarios]    Script Date: 17/12/2015 14:54:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[senha] [int] NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [int] NOT NULL,
	[sexo] [varchar](50) NOT NULL,
	[dataNascimento] [datetime] NOT NULL,
	[telefone] [int] NOT NULL,
	[cidade] [varchar](50) NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[endereco] [varchar](50) NOT NULL,
	[complemento] [varchar](50) NOT NULL,
	[cep] [int] NOT NULL,
	[ddd] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

