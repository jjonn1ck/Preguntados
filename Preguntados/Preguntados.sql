
CREATE DATABASE Preguntados

USE [Preguntados]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 18/10/2018 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Denuncia]    Script Date: 18/10/2018 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Denuncia](
	[idDenuncia] [int] IDENTITY(1,1) NOT NULL,
	[motivo] [nvarchar](200) NOT NULL,
	[nomUsuario] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Denuncia] PRIMARY KEY CLUSTERED 
(
	[idDenuncia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partida]    Script Date: 18/10/2018 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partida](
	[idPartida] [int] IDENTITY(1,1) NOT NULL,
	[puntaje] [int] NULL,
	[nomUsuario] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Partida] PRIMARY KEY CLUSTERED 
(
	[idPartida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pregunta]    Script Date: 18/10/2018 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pregunta](
	[idPregunta] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](max) NOT NULL,
	[idCategoria] [int] NOT NULL,
 CONSTRAINT [PK_Pregunta] PRIMARY KEY CLUSTERED 
(
	[idPregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreguntaPorPartida]    Script Date: 18/10/2018 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreguntaPorPartida](
	[idPregPorPartida] [int] NOT NULL,
	[idPartida] [int] NOT NULL,
	[idPregunta] [int] NOT NULL,
 CONSTRAINT [PK_PreguntaxPartida] PRIMARY KEY CLUSTERED 
(
	[idPregPorPartida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Respuesta]    Script Date: 18/10/2018 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Respuesta](
	[idRespuesta] [int] NOT NULL,
	[descripcion] [nvarchar](max) NOT NULL,
	[correcto] [bit] NOT NULL,
	[idPregunta] [int] NOT NULL,
 CONSTRAINT [PK_Respuesta] PRIMARY KEY CLUSTERED 
(
	[idRespuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 18/10/2018 11:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[nomUsuario] [nvarchar](20) NOT NULL,
	[contraseña] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[nomUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Denuncia]  WITH CHECK ADD  CONSTRAINT [FK_Denuncia_Usuario] FOREIGN KEY([nomUsuario])
REFERENCES [dbo].[Usuario] ([nomUsuario])
GO
ALTER TABLE [dbo].[Denuncia] CHECK CONSTRAINT [FK_Denuncia_Usuario]
GO
ALTER TABLE [dbo].[Partida]  WITH CHECK ADD  CONSTRAINT [FK_Partida_Usuario] FOREIGN KEY([nomUsuario])
REFERENCES [dbo].[Usuario] ([nomUsuario])
GO
ALTER TABLE [dbo].[Partida] CHECK CONSTRAINT [FK_Partida_Usuario]
GO
ALTER TABLE [dbo].[Pregunta]  WITH CHECK ADD  CONSTRAINT [FK_Pregunta_Categoria] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categoria] ([idCategoria])
GO
ALTER TABLE [dbo].[Pregunta] CHECK CONSTRAINT [FK_Pregunta_Categoria]
GO
ALTER TABLE [dbo].[PreguntaPorPartida]  WITH CHECK ADD  CONSTRAINT [FK_PreguntaPorPartida_Partida] FOREIGN KEY([idPartida])
REFERENCES [dbo].[Partida] ([idPartida])
GO
ALTER TABLE [dbo].[PreguntaPorPartida] CHECK CONSTRAINT [FK_PreguntaPorPartida_Partida]
GO
ALTER TABLE [dbo].[PreguntaPorPartida]  WITH CHECK ADD  CONSTRAINT [FK_PreguntaPorPartida_Pregunta] FOREIGN KEY([idPregunta])
REFERENCES [dbo].[Pregunta] ([idPregunta])
GO
ALTER TABLE [dbo].[PreguntaPorPartida] CHECK CONSTRAINT [FK_PreguntaPorPartida_Pregunta]
GO
ALTER TABLE [dbo].[Respuesta]  WITH CHECK ADD  CONSTRAINT [FK_Respuesta_Pregunta] FOREIGN KEY([idPregunta])
REFERENCES [dbo].[Pregunta] ([idPregunta])
GO
ALTER TABLE [dbo].[Respuesta] CHECK CONSTRAINT [FK_Respuesta_Pregunta]
GO
