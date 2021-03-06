CREATE DATABASE [Libreria]
USE [Libreria]
GO
/****** Object:  Table [dbo].[Autor]    Script Date: 20/01/2022 12:16:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Ciudad] [varchar](250) NOT NULL,
	[Email] [varchar](120) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Editorial]    Script Date: 20/01/2022 12:16:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Editorial](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[Direccion] [varchar](250) NOT NULL,
	[Telefono] [varchar](10) NULL,
	[Email] [varchar](120) NOT NULL,
	[MaximoLibros] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libro]    Script Date: 20/01/2022 12:16:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](250) NOT NULL,
	[Anio] [varchar](4) NOT NULL,
	[Genero] [varchar](50) NOT NULL,
	[NumPaginas] [int] NOT NULL,
	[IdEditorial] [int] NULL,
	[IdAutor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Autor] ON 

INSERT [dbo].[Autor] ([Id], [Nombre], [FechaNacimiento], [Ciudad], [Email]) VALUES (1, N'Gabriel Garcia Marquez', CAST(N'1927-03-06' AS Date), N'Aracataca - Magdalena', N'gabo@gmail.com')
INSERT [dbo].[Autor] ([Id], [Nombre], [FechaNacimiento], [Ciudad], [Email]) VALUES (2, N'Gabriel Garcia Marquez', CAST(N'1927-03-06' AS Date), N'Aracataca - Magdalena', N'gabo@gmail.com')
INSERT [dbo].[Autor] ([Id], [Nombre], [FechaNacimiento], [Ciudad], [Email]) VALUES (3, N'Juan Gonzalo Callejas Ramírez', CAST(N'2022-01-20' AS Date), N'Bogotá', N'juan@gmail.com')
INSERT [dbo].[Autor] ([Id], [Nombre], [FechaNacimiento], [Ciudad], [Email]) VALUES (4, N'Juan Gonzalo Callejas Ramírez', CAST(N'0001-01-01' AS Date), N'Bogotá', N'juan@gmail.com')
SET IDENTITY_INSERT [dbo].[Autor] OFF
GO
SET IDENTITY_INSERT [dbo].[Editorial] ON 

INSERT [dbo].[Editorial] ([Id], [Nombre], [Direccion], [Telefono], [Email], [MaximoLibros]) VALUES (1, N'Editorial Sudamericana', N'Humberto Primo 555, Capital Federal', N'52354400', N'recepcion@penguinrandomhouse.com', 3)
INSERT [dbo].[Editorial] ([Id], [Nombre], [Direccion], [Telefono], [Email], [MaximoLibros]) VALUES (2, N'Círculo de Lectores', N'Bogotá', N'3558694', N'circulolectores@gmail.com', 10)
SET IDENTITY_INSERT [dbo].[Editorial] OFF
GO
SET IDENTITY_INSERT [dbo].[Libro] ON 

INSERT [dbo].[Libro] ([Id], [Titulo], [Anio], [Genero], [NumPaginas], [IdEditorial], [IdAutor]) VALUES (1, N'Las oraciones mas poderosas del mundo', N'2017', N'Novela', 300, 2, 3)
INSERT [dbo].[Libro] ([Id], [Titulo], [Anio], [Genero], [NumPaginas], [IdEditorial], [IdAutor]) VALUES (2, N'Cien años de soledad', N'1967', N'Novela', 471, 1, 1)
SET IDENTITY_INSERT [dbo].[Libro] OFF
GO
ALTER TABLE [dbo].[Libro]  WITH CHECK ADD  CONSTRAINT [FK_Libreria_Autor] FOREIGN KEY([IdAutor])
REFERENCES [dbo].[Autor] ([Id])
GO
ALTER TABLE [dbo].[Libro] CHECK CONSTRAINT [FK_Libreria_Autor]
GO
ALTER TABLE [dbo].[Libro]  WITH CHECK ADD  CONSTRAINT [FK_Libreria_Editorial] FOREIGN KEY([IdEditorial])
REFERENCES [dbo].[Editorial] ([Id])
GO
ALTER TABLE [dbo].[Libro] CHECK CONSTRAINT [FK_Libreria_Editorial]
GO
