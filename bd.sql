USE [Vand]
GO
/****** Object:  Table [dbo].[etiquetas]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[etiquetas](
	[id_etiqueta] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_etiqueta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GRUPO]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GRUPO](
	[ID_GRUPO] [int] NOT NULL,
	[ID_HIJO] [int] NOT NULL,
 CONSTRAINT [PK_GRUPO] PRIMARY KEY CLUSTERED 
(
	[ID_GRUPO] ASC,
	[ID_HIJO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[idiomas]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[idiomas](
	[id_idioma] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[idioma_default] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERMISO]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISO](
	[ID_PERMISO] [int] NOT NULL,
	[PERMISO] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PERMISO] PRIMARY KEY CLUSTERED 
(
	[ID_PERMISO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tBanda]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tBanda](
	[Id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[fundacion] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tComision]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tComision](
	[IdCompra] [int] NOT NULL,
	[Porcentaje] [decimal](18, 0) NOT NULL,
	[Ganancia] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tCompraVenta]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCompraVenta](
	[Id] [int] NOT NULL,
	[IdCopia] [int] NOT NULL,
	[NombreCliente] [varchar](50) NOT NULL,
	[NombreVendedor] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tCopia]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCopia](
	[Id] [int] NOT NULL,
	[Precio] [decimal](18, 0) NOT NULL,
	[NombreCopia] [varchar](50) NOT NULL,
	[NombrePropietario] [varchar](50) NOT NULL,
	[vendido] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tDisco]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tDisco](
	[nombre] [varchar](50) NOT NULL,
	[year] [date] NULL,
	[urlPortada] [varchar](255) NULL,
	[idBanda] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tEnvio]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tEnvio](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[Despachado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tInversion]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tInversion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[fecInicio] [date] NOT NULL,
	[fecFin] [date] NOT NULL,
	[MontoInicio] [decimal](18, 0) NOT NULL,
	[MontoFin] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tInversionHistorial]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tInversionHistorial](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[fecInicio] [date] NOT NULL,
	[fecFin] [date] NOT NULL,
	[MontoInicio] [decimal](18, 0) NOT NULL,
	[MontoFin] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tLogs]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tLogs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[fecIngreso] [datetime] NULL,
	[fecEgreso] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tOperacion]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tOperacion](
	[Id] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[traducciones]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[traducciones](
	[id_idioma] [int] NOT NULL,
	[id_etiqueta] [int] NOT NULL,
	[traduccion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_idioma] ASC,
	[id_etiqueta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tUsuario]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tUsuario](
	[nombre] [varchar](50) NOT NULL,
	[pwd] [varchar](50) NOT NULL,
	[Direccion] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tVandCoin]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tVandCoin](
	[Id] [int] NOT NULL,
	[Valor] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tWallet]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tWallet](
	[nombre] [varchar](50) NOT NULL,
	[Cantidad] [decimal](18, 0) NOT NULL,
	[IdValor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO_PERMISO]    Script Date: 15/01/2022 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO_PERMISO](
	[ID_USUARIO] [varchar](50) NOT NULL,
	[ID_PERMISO] [int] NOT NULL,
 CONSTRAINT [PK_USUARIO_PERMISO] PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] ASC,
	[ID_PERMISO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (1, N'Detail')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (2, N'Login')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (3, N'Register')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (4, N'SelectIdiom')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (5, N'Test123')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (6, N'Gallery')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (7, N'Idiom')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (8, N'Add')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (9, N'Remove')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (10, N'Modify')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (11, N'UserPermission')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (12, N'Permission')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (13, N'Rols')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (14, N'RolPermission')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (15, N'Users')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (16, N'UserAuhorization')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (17, N'Buy')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (18, N'Disc')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (19, N'Group')
INSERT [dbo].[etiquetas] ([id_etiqueta], [nombre]) VALUES (20, N'Battaglia')
GO
INSERT [dbo].[GRUPO] ([ID_GRUPO], [ID_HIJO]) VALUES (101, 1)
INSERT [dbo].[GRUPO] ([ID_GRUPO], [ID_HIJO]) VALUES (101, 2)
INSERT [dbo].[GRUPO] ([ID_GRUPO], [ID_HIJO]) VALUES (101, 3)
INSERT [dbo].[GRUPO] ([ID_GRUPO], [ID_HIJO]) VALUES (102, 3)
INSERT [dbo].[GRUPO] ([ID_GRUPO], [ID_HIJO]) VALUES (102, 5)
INSERT [dbo].[GRUPO] ([ID_GRUPO], [ID_HIJO]) VALUES (103, 1)
INSERT [dbo].[GRUPO] ([ID_GRUPO], [ID_HIJO]) VALUES (103, 6)
GO
INSERT [dbo].[idiomas] ([id_idioma], [nombre], [idioma_default]) VALUES (1, N'spanish', 1)
INSERT [dbo].[idiomas] ([id_idioma], [nombre], [idioma_default]) VALUES (2, N'english', 0)
INSERT [dbo].[idiomas] ([id_idioma], [nombre], [idioma_default]) VALUES (3, N'Italian', 0)
INSERT [dbo].[idiomas] ([id_idioma], [nombre], [idioma_default]) VALUES (4, N'German', 0)
GO
INSERT [dbo].[PERMISO] ([ID_PERMISO], [PERMISO]) VALUES (1, N'Ver')
INSERT [dbo].[PERMISO] ([ID_PERMISO], [PERMISO]) VALUES (2, N'Compra')
INSERT [dbo].[PERMISO] ([ID_PERMISO], [PERMISO]) VALUES (3, N'Publicar')
INSERT [dbo].[PERMISO] ([ID_PERMISO], [PERMISO]) VALUES (4, N'PublicarComoEmpresa')
INSERT [dbo].[PERMISO] ([ID_PERMISO], [PERMISO]) VALUES (5, N'AdministrarVandCoin')
INSERT [dbo].[PERMISO] ([ID_PERMISO], [PERMISO]) VALUES (6, N'Test')
INSERT [dbo].[PERMISO] ([ID_PERMISO], [PERMISO]) VALUES (100, N'Admin')
INSERT [dbo].[PERMISO] ([ID_PERMISO], [PERMISO]) VALUES (101, N'Cliente')
INSERT [dbo].[PERMISO] ([ID_PERMISO], [PERMISO]) VALUES (102, N'Empresa')
INSERT [dbo].[PERMISO] ([ID_PERMISO], [PERMISO]) VALUES (103, N'Logistica')
GO
INSERT [dbo].[tBanda] ([Id], [nombre], [fundacion]) VALUES (1, N'Pescado Rabioso', CAST(N'1973-10-01' AS Date))
INSERT [dbo].[tBanda] ([Id], [nombre], [fundacion]) VALUES (2, N'AC/DC', CAST(N'1973-10-01' AS Date))
INSERT [dbo].[tBanda] ([Id], [nombre], [fundacion]) VALUES (3, N'Yes', CAST(N'1973-10-01' AS Date))
INSERT [dbo].[tBanda] ([Id], [nombre], [fundacion]) VALUES (4, N'Slipknot', CAST(N'1973-10-01' AS Date))
INSERT [dbo].[tBanda] ([Id], [nombre], [fundacion]) VALUES (5, N'Iron Maiden', CAST(N'1973-10-01' AS Date))
INSERT [dbo].[tBanda] ([Id], [nombre], [fundacion]) VALUES (6, N'Helloween', CAST(N'1973-10-01' AS Date))
GO
INSERT [dbo].[tComision] ([IdCompra], [Porcentaje], [Ganancia]) VALUES (1, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[tComision] ([IdCompra], [Porcentaje], [Ganancia]) VALUES (2, CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[tComision] ([IdCompra], [Porcentaje], [Ganancia]) VALUES (3, CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[tComision] ([IdCompra], [Porcentaje], [Ganancia]) VALUES (4, CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[tComision] ([IdCompra], [Porcentaje], [Ganancia]) VALUES (5, CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[tComision] ([IdCompra], [Porcentaje], [Ganancia]) VALUES (6, CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)))
GO
INSERT [dbo].[tCompraVenta] ([Id], [IdCopia], [NombreCliente], [NombreVendedor]) VALUES (1, 2, N'Fede', N'Data')
INSERT [dbo].[tCompraVenta] ([Id], [IdCopia], [NombreCliente], [NombreVendedor]) VALUES (2, 3, N'Fede', N'Data')
INSERT [dbo].[tCompraVenta] ([Id], [IdCopia], [NombreCliente], [NombreVendedor]) VALUES (3, 4, N'Fede', N'Data')
INSERT [dbo].[tCompraVenta] ([Id], [IdCopia], [NombreCliente], [NombreVendedor]) VALUES (4, 5, N'Fede', N'Data')
INSERT [dbo].[tCompraVenta] ([Id], [IdCopia], [NombreCliente], [NombreVendedor]) VALUES (5, 6, N'Fede', N'Data')
INSERT [dbo].[tCompraVenta] ([Id], [IdCopia], [NombreCliente], [NombreVendedor]) VALUES (6, 7, N'Fede', N'Data')
GO
INSERT [dbo].[tCopia] ([Id], [Precio], [NombreCopia], [NombrePropietario], [vendido]) VALUES (1, CAST(10 AS Decimal(18, 0)), N'Artaud', N'Fede', 0)
INSERT [dbo].[tCopia] ([Id], [Precio], [NombreCopia], [NombrePropietario], [vendido]) VALUES (2, CAST(10 AS Decimal(18, 0)), N'Back in Black', N'Data', 1)
INSERT [dbo].[tCopia] ([Id], [Precio], [NombreCopia], [NombrePropietario], [vendido]) VALUES (3, CAST(10 AS Decimal(18, 0)), N'Close to the Edge', N'Data', 1)
INSERT [dbo].[tCopia] ([Id], [Precio], [NombreCopia], [NombrePropietario], [vendido]) VALUES (4, CAST(10 AS Decimal(18, 0)), N'The Number of the Beast', N'Data', 1)
INSERT [dbo].[tCopia] ([Id], [Precio], [NombreCopia], [NombrePropietario], [vendido]) VALUES (5, CAST(10 AS Decimal(18, 0)), N'Walls of Jericho', N'Data', 1)
INSERT [dbo].[tCopia] ([Id], [Precio], [NombreCopia], [NombrePropietario], [vendido]) VALUES (6, CAST(10 AS Decimal(18, 0)), N'Iowa', N'Data', 1)
INSERT [dbo].[tCopia] ([Id], [Precio], [NombreCopia], [NombrePropietario], [vendido]) VALUES (7, CAST(10 AS Decimal(18, 0)), N'Artaud', N'Data', 1)
INSERT [dbo].[tCopia] ([Id], [Precio], [NombreCopia], [NombrePropietario], [vendido]) VALUES (8, CAST(10 AS Decimal(18, 0)), N'Iowa', N'Data', 0)
INSERT [dbo].[tCopia] ([Id], [Precio], [NombreCopia], [NombrePropietario], [vendido]) VALUES (9, CAST(10 AS Decimal(18, 0)), N'Walls of Jericho', N'Data', 0)
GO
INSERT [dbo].[tDisco] ([nombre], [year], [urlPortada], [idBanda]) VALUES (N'Artaud', CAST(N'1973-10-01' AS Date), N'https://cdn-d15c.kxcdn.com/fotos/discos/000/001/074/original/foto.jpg', 1)
INSERT [dbo].[tDisco] ([nombre], [year], [urlPortada], [idBanda]) VALUES (N'Back in Black', CAST(N'1980-10-01' AS Date), N'https://upload.wikimedia.org/wikipedia/commons/9/92/ACDC_Back_in_Black.png', 2)
INSERT [dbo].[tDisco] ([nombre], [year], [urlPortada], [idBanda]) VALUES (N'Close to the Edge', CAST(N'1972-06-01' AS Date), N'https://upload.wikimedia.org/wikipedia/en/0/09/Yes-close.jpg', 3)
INSERT [dbo].[tDisco] ([nombre], [year], [urlPortada], [idBanda]) VALUES (N'Iowa', CAST(N'2001-06-01' AS Date), N'https://img.discogs.com/5vjIAYo2W4v5d3rvBsPDVTCsEO0=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-2972380-1554827065-9578.jpeg.jpg', 4)
INSERT [dbo].[tDisco] ([nombre], [year], [urlPortada], [idBanda]) VALUES (N'The Number of the Beast', CAST(N'1982-03-22' AS Date), N'https://www.nacionrock.com/wp-content/uploads/iron-maiden-number-web.jpg', 5)
INSERT [dbo].[tDisco] ([nombre], [year], [urlPortada], [idBanda]) VALUES (N'Walls of Jericho', CAST(N'1985-01-01' AS Date), N'https://anhelarium.files.wordpress.com/2018/08/r-581933-1369547539-2718-jpeg.jpg', 6)
GO
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 1, N'Detalle')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 2, N'Logueo')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 3, N'Registro')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 4, N'Seleccionar Idioma')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 6, N'Galeria')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 7, N'Idioma')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 8, N'Agregar')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 9, N'Sacar')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 10, N'Modificar')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 11, N'Permiso de usuario')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 12, N'Permisos')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 13, N'Roles')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 14, N'Permisos del Rol')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 15, N'Usuario')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 16, N'Autorización de Usuario')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 17, N'Comprar')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 18, N'Disco')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 19, N'Grupo')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (1, 20, N'Nicolas')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 1, N'Detail')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 2, N'Login')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 3, N'Register')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 4, N'Select Languaje')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 6, N'Gallery')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 7, N'Idiom')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 8, N'Add')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 9, N'Remove')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 10, N'Modify')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 11, N'User permission')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 12, N'Permission')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 14, N'Rol Permission')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 15, N'User')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 16, N'User Authorization')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 17, N'Buy')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 18, N'Disc')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 19, N'Group')
INSERT [dbo].[traducciones] ([id_idioma], [id_etiqueta], [traduccion]) VALUES (2, 20, N'Nicholas')
GO
INSERT [dbo].[tUsuario] ([nombre], [pwd], [Direccion]) VALUES (N'Data', N'F6068DAA29DBB05A7EAD1E3B5A48BBEE', NULL)
INSERT [dbo].[tUsuario] ([nombre], [pwd], [Direccion]) VALUES (N'EmpresaPepe', N'C9A4A8084777023354D3360EFF8595C2', NULL)
INSERT [dbo].[tUsuario] ([nombre], [pwd], [Direccion]) VALUES (N'Fede', N'9D04B6572E137EB28B2C444C1C7D3FAF', NULL)
INSERT [dbo].[tUsuario] ([nombre], [pwd], [Direccion]) VALUES (N'Test', N'0CBC6611F5540BD0809A388DC95A615B', NULL)
GO
INSERT [dbo].[tVandCoin] ([Id], [Valor]) VALUES (1, CAST(10 AS Decimal(18, 0)))
GO
INSERT [dbo].[tWallet] ([nombre], [Cantidad], [IdValor]) VALUES (N'Data', CAST(0 AS Decimal(18, 0)), 1)
INSERT [dbo].[tWallet] ([nombre], [Cantidad], [IdValor]) VALUES (N'EmpresaPepe', CAST(0 AS Decimal(18, 0)), 1)
INSERT [dbo].[tWallet] ([nombre], [Cantidad], [IdValor]) VALUES (N'Fede', CAST(920 AS Decimal(18, 0)), 1)
INSERT [dbo].[tWallet] ([nombre], [Cantidad], [IdValor]) VALUES (N'Test', CAST(0 AS Decimal(18, 0)), 1)
GO
INSERT [dbo].[USUARIO_PERMISO] ([ID_USUARIO], [ID_PERMISO]) VALUES (N'Data', 101)
INSERT [dbo].[USUARIO_PERMISO] ([ID_USUARIO], [ID_PERMISO]) VALUES (N'EmpresaPepe', 102)
INSERT [dbo].[USUARIO_PERMISO] ([ID_USUARIO], [ID_PERMISO]) VALUES (N'Fede', 101)
INSERT [dbo].[USUARIO_PERMISO] ([ID_USUARIO], [ID_PERMISO]) VALUES (N'Test', 101)
GO
ALTER TABLE [dbo].[GRUPO]  WITH CHECK ADD  CONSTRAINT [FK_GRUPO_PERMISO] FOREIGN KEY([ID_GRUPO])
REFERENCES [dbo].[PERMISO] ([ID_PERMISO])
GO
ALTER TABLE [dbo].[GRUPO] CHECK CONSTRAINT [FK_GRUPO_PERMISO]
GO
ALTER TABLE [dbo].[GRUPO]  WITH CHECK ADD  CONSTRAINT [FK_GRUPO_PERMISO1] FOREIGN KEY([ID_HIJO])
REFERENCES [dbo].[PERMISO] ([ID_PERMISO])
GO
ALTER TABLE [dbo].[GRUPO] CHECK CONSTRAINT [FK_GRUPO_PERMISO1]
GO
ALTER TABLE [dbo].[tComision]  WITH CHECK ADD FOREIGN KEY([IdCompra])
REFERENCES [dbo].[tCompraVenta] ([Id])
GO
ALTER TABLE [dbo].[tCompraVenta]  WITH CHECK ADD FOREIGN KEY([IdCopia])
REFERENCES [dbo].[tCopia] ([Id])
GO
ALTER TABLE [dbo].[tCompraVenta]  WITH CHECK ADD FOREIGN KEY([NombreCliente])
REFERENCES [dbo].[tUsuario] ([nombre])
GO
ALTER TABLE [dbo].[tCompraVenta]  WITH CHECK ADD FOREIGN KEY([NombreVendedor])
REFERENCES [dbo].[tUsuario] ([nombre])
GO
ALTER TABLE [dbo].[tCopia]  WITH CHECK ADD FOREIGN KEY([NombreCopia])
REFERENCES [dbo].[tDisco] ([nombre])
GO
ALTER TABLE [dbo].[tCopia]  WITH CHECK ADD FOREIGN KEY([NombrePropietario])
REFERENCES [dbo].[tUsuario] ([nombre])
GO
ALTER TABLE [dbo].[tDisco]  WITH CHECK ADD  CONSTRAINT [FK_IdBanda] FOREIGN KEY([idBanda])
REFERENCES [dbo].[tBanda] ([Id])
GO
ALTER TABLE [dbo].[tDisco] CHECK CONSTRAINT [FK_IdBanda]
GO
ALTER TABLE [dbo].[tEnvio]  WITH CHECK ADD FOREIGN KEY([IdCompra])
REFERENCES [dbo].[tCompraVenta] ([Id])
GO
ALTER TABLE [dbo].[tInversion]  WITH CHECK ADD FOREIGN KEY([NombreUsuario])
REFERENCES [dbo].[tUsuario] ([nombre])
GO
ALTER TABLE [dbo].[tInversionHistorial]  WITH CHECK ADD FOREIGN KEY([NombreUsuario])
REFERENCES [dbo].[tUsuario] ([nombre])
GO
ALTER TABLE [dbo].[tLogs]  WITH CHECK ADD  CONSTRAINT [FK_UserLog] FOREIGN KEY([usuario])
REFERENCES [dbo].[tUsuario] ([nombre])
GO
ALTER TABLE [dbo].[tLogs] CHECK CONSTRAINT [FK_UserLog]
GO
ALTER TABLE [dbo].[traducciones]  WITH CHECK ADD FOREIGN KEY([id_etiqueta])
REFERENCES [dbo].[etiquetas] ([id_etiqueta])
GO
ALTER TABLE [dbo].[traducciones]  WITH CHECK ADD FOREIGN KEY([id_idioma])
REFERENCES [dbo].[idiomas] ([id_idioma])
GO
ALTER TABLE [dbo].[tWallet]  WITH CHECK ADD FOREIGN KEY([IdValor])
REFERENCES [dbo].[tVandCoin] ([Id])
GO
ALTER TABLE [dbo].[USUARIO_PERMISO]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_PERMISO_PERMISO] FOREIGN KEY([ID_PERMISO])
REFERENCES [dbo].[PERMISO] ([ID_PERMISO])
GO
ALTER TABLE [dbo].[USUARIO_PERMISO] CHECK CONSTRAINT [FK_USUARIO_PERMISO_PERMISO]
GO
ALTER TABLE [dbo].[USUARIO_PERMISO]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_PERMISO_USUARIO] FOREIGN KEY([ID_USUARIO])
REFERENCES [dbo].[tUsuario] ([nombre])
GO
ALTER TABLE [dbo].[USUARIO_PERMISO] CHECK CONSTRAINT [FK_USUARIO_PERMISO_USUARIO]
GO
/****** Object:  StoredProcedure [dbo].[GRUPO_LISTAR]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GRUPO_LISTAR]
as
begin
select G.ID_GRUPO, P.ID_PERMISO, P.PERMISO  from GRUPO G
Inner join PERMISO p on G.ID_HIJO = p.ID_PERMISO
end

GO
/****** Object:  StoredProcedure [dbo].[PERMISO_LISTAR]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PERMISO_LISTAR]
as 
BEGIN
SELECT Distinct p.ID_PERMISO, p.PERMISO, 
'TIPO' =  case when G.ID_GRUPO is null Then 'P' else 'G' end
from PERMISO p
LEFT JOIN GRUPO G on p.ID_PERMISO = g.ID_GRUPO

END

GO
/****** Object:  StoredProcedure [dbo].[spAgregarPermiso]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[spAgregarPermiso]
@IdPadre int,
@IdHijo int
as
	BEGIN TRANSACTION;

	BEGIN TRY
		
	insert into grupo values (@IdPadre, @IdHijo)
	

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spAutorizarEnvio]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[spAutorizarEnvio] 
@IdCompra int
AS

	BEGIN TRANSACTION;

	BEGIN TRY

	update tEnvio set Despachado = 1 where IdCompra = @IdCompra

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spBorrarIdioma]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[spBorrarIdioma] 

@Idioma varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY
		

		select * from idiomas
		--borro las traducciones del idioma
		DELETE t
		FROM traducciones t
		INNER JOIN idiomas i
		  ON t.id_idioma=i.id_idioma
		WHERE i.nombre = @Idioma
		--borro la traduccion del idioma

		delete from idiomas where nombre = @Idioma

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spCargarCompra]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCargarCompra] 

@NombreComprador varchar(50),
@NombreVendedor varchar(50),
@NombreCopia varchar(50),
@PrecioCopia decimal,
@Porcentaje decimal,
@Ganancia decimal
AS

	BEGIN TRANSACTION;

	BEGIN TRY
		
		declare @idAux int
		IF ((select count(*) from tCompraVenta)= 0)
		BEGIN
			Set @idAux =   1

		END
		ELSE
		BEGIN
			Set @idAux = (SELECT top 1 Id from tCompraVenta order by Id DESC)
			Set @idAux = @idAux + 1
		END



		INSERT INTO tCompraVenta (Id, NombreCliente, NombreVendedor, IdCopia)
		VALUES (@idAux, @NombreComprador, @NombreVendedor, 
		(select top 1 Id from tcopia 
		where NombrePropietario = @NombreVendedor and NombreCopia = @NombreCopia));

		insert into tComision values(@idAux, @Porcentaje, @Ganancia)

		update tWallet set Cantidad = 
		(select Cantidad from tWallet where nombre = @NombreComprador) -
		(select Precio from tcopia where NombrePropietario = @NombreVendedor and NombreCopia = @NombreCopia)
		where nombre = @NombreComprador

		update tCopia set  vendido = 1 where NombrePropietario = @NombreVendedor and NombreCopia = @NombreCopia and Precio = @PrecioCopia
		--delete from tcopia where NombrePropietario = @NombreVendedor and NombreCopia = @NombreCopia




		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spCrearCopia]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCrearCopia] 

@Nombre varchar(50),
@Precio decimal,
@Propietario varchar(50)
AS

	--BEGIN TRANSACTION;

	--BEGIN TRY

		declare @idAux int
		IF ((select count(*) from tCopia)= 0)
		BEGIN
			Set @idAux =   1

		END
		ELSE
		BEGIN
			Set @idAux = (SELECT top 1 Id from tCopia order by Id DESC)
			Set @idAux = @idAux + 1
		END


		INSERT INTO tCopia(Id, NombreCopia, NombrePropietario, Precio, vendido) values (@idAux, @Nombre, @Propietario, @Precio, 0)


	--	COMMIT TRANSACTION;
	--END TRY
	--BEGIN CATCH

	--	ROLLBACK TRANSACTION;
	--END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spCrearEtiqueta]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spCrearEtiqueta] 
@Etiqueta varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY
		
		declare @idAux int
		IF ((select count(*) from etiquetas)= 0)
		BEGIN
			Set @idAux =   1

		END
		ELSE
		BEGIN
			Set @idAux = (SELECT top 1 id_etiqueta from etiquetas order by id_etiqueta DESC)
			Set @idAux = @idAux + 1
		END

		insert into etiquetas values (@idAux, @Etiqueta)


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spCrearIdioma]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spCrearIdioma] 

@Idioma varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY
		
		declare @idAux int
		IF ((select count(*) from idiomas)= 0)
		BEGIN
			Set @idAux =   1

		END
		ELSE
		BEGIN
			Set @idAux = (SELECT top 1 id_idioma from idiomas order by id_idioma DESC)
			Set @idAux = @idAux + 1
		END

		insert into idiomas values (@idAux, @Idioma, 0)


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spCrearInversion]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spCrearInversion] 
@Nombre varchar(50),
@MontoInicial decimal,
@MontoFinal decimal,
@FecInicial date,
@FecFinal date
AS

	BEGIN TRANSACTION;

	BEGIN TRY

		insert into tInversion (NombreUsuario, fecInicio, fecFin, MontoInicio, MontoFin) values(@Nombre, @FecInicial, @FecFinal, @MontoInicial, @MontoFinal)

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spCrearLog]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCrearLog] 

@Nombre varchar(50),
@FecIngreso dateTime
AS

	BEGIN TRANSACTION;

	BEGIN TRY

		--declare @idAux int
		--IF ((select count(*) from tCopia)= 0)
		--BEGIN
		--	Set @idAux =   1

		--END
		--ELSE
		--BEGIN
		--	Set @idAux = (SELECT top 1 Id from tCopia order by Id DESC)
		--	Set @idAux = @idAux + 1
		--END

		INSERT INTO tLogs(usuario, fecIngreso) values (@Nombre, @FecIngreso)

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spCrearPermisoHijo]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCrearPermisoHijo] 
@Permiso varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY

		declare @idAux int
		declare @count int
		set @count = (select  count(*)Id_permiso  from PERMISO where Id_permiso < 100) -- order by Id_permiso DESC
		select @count
		IF (@count = 0)
		BEGIN
			Set @idAux =   1
		END
		ELSE
		BEGIN
			Set @idAux = (select top 1 Id_permiso  from PERMISO 
							where Id_permiso < 100
							order by Id_permiso DESC)
			Set @idAux = @idAux + 1
		END

		insert into PERMISO values (@idAux, @Permiso)


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spCrearPermisoPadre]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCrearPermisoPadre] 
@Permiso varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY

		declare @idAux int
		declare @count int
		set @count = (select  count(*)Id_permiso  from PERMISO where Id_permiso > 100) -- order by Id_permiso DESC
		select @count
		IF (@count = 0)
		BEGIN
			Set @idAux =   1
		END
		ELSE
		BEGIN
			Set @idAux = (select top 1 Id_permiso  from PERMISO 
							where Id_permiso > 100
							order by Id_permiso DESC)
			Set @idAux = @idAux + 1
		END

		insert into PERMISO values (@idAux, @Permiso)


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spCrearTraduccion]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[spCrearTraduccion] 
@Idioma varchar(50),
@Etiqueta varchar(50),
@Traduccion varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY
		
		declare @idAux int
		IF ((select count(*) from etiquetas)= 0)
		BEGIN
			Set @idAux =   1

		END
		ELSE
		BEGIN
			Set @idAux = (SELECT top 1 id_etiqueta from etiquetas order by id_etiqueta DESC)
			Set @idAux = @idAux + 1
		END


		insert into traducciones values((select id_idioma from idiomas where nombre = @Idioma), (select id_etiqueta from etiquetas where nombre = @Etiqueta), @Traduccion) 
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spCrearUsuario]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spCrearUsuario] 

@Nombre varchar(50),
@Clave varchar(50),
@Rol int
AS

	BEGIN TRANSACTION;

	BEGIN TRY


		INSERT INTO tUsuario (nombre, pwd) values (@Nombre, @Clave)
		INSERT INTO tWallet values (@Nombre, 0, 1)
		INSERT into USUARIO_PERMISO values(@Nombre, @Rol) 

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spEliminarEtiqueta]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[spEliminarEtiqueta] 
@Etiqueta varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY
		select * from etiquetas
		select * from traducciones

		delete from traducciones where id_etiqueta = (select top 1 id_etiqueta from etiquetas where nombre = @Etiqueta)

		delete from etiquetas where nombre = @Etiqueta



		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spEliminarTraduccion]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[spEliminarTraduccion] 
@Traduccion varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY
		
		delete from traducciones where traduccion = @Traduccion



		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spListarBandas]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[spListarBandas] 

AS

	BEGIN TRANSACTION;

	BEGIN TRY


		select Id, nombre, fundacion from tBanda


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spListarCopias]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spListarCopias] 
@NombreUsuario varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY


		select top 10 NombreCopia, Precio, Year, NombrePropietario, urlPortada from tCopia
		inner join tDisco on tDisco.nombre = tCopia.NombreCopia
		where tCopia.vendido = 0 and NombrePropietario <> @NombreUsuario
		--inner join tUsuario on tUsuario.nombre = tCopia.NombrePropietario


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spListarEnviosNoFinalizados]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[spListarEnviosNoFinalizados] 

AS

	BEGIN TRANSACTION;

	BEGIN TRY

		select tCompraVenta.NombreVendedor,tCompraVenta.NombreCliente, tCopia.NombreCopia, tUsuario.Direccion  from tEnvio
		inner join tCompraVenta on tCompraVenta.Id = tEnvio.IdCompra
		inner join tUsuario on tUsuario.nombre = tCompraVenta.NombreCliente
		inner join tCopia on tCopia.Id = tCompraVenta.IdCopia
		where tEnvio.Despachado <> 0

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spListarEtiquetas]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spListarEtiquetas] 

AS

	BEGIN TRANSACTION;

	BEGIN TRY	 
	select * from etiquetas
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spListarInversionesSinFinalizar]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spListarInversionesSinFinalizar] 
@FecFin date
AS

	BEGIN TRANSACTION;

	BEGIN TRY

		select NombreUsuario, fecInicio, fecFin, MontoInicio, MontoFin from tInversion where FecFin > @FecFin


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spListarMisCompras]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[spListarMisCompras] 
@NombreUsuario varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY

		select d.nombre, d.year, d.urlPortada, b.nombre as 'NombreBanda' from tCompraVenta cv
		inner join tCopia c on cv.IdCopia = c.Id
		inner join tDisco d on d.nombre = c.NombreCopia
		inner join tBanda b on b.Id = d.idBanda
		where cv.NombreCliente = @NombreUsuario
		

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spListarPermisosHijo]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spListarPermisosHijo]
@ID int
as
begin
SELECT p.ID_PERMISO, p.PERMISO  From PERMISO p
inner join grupo g on g.ID_HIJO = p.ID_PERMISO
where g.ID_GRUPO = @ID

end

GO
/****** Object:  StoredProcedure [dbo].[spListarPermisosPadre]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spListarPermisosPadre]
as
begin
SELECT *  From PERMISO where ID_PERMISO > 99
end

GO
/****** Object:  StoredProcedure [dbo].[spListarSubPermisos]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[spListarSubPermisos]
as
begin
SELECT *  From PERMISO where ID_PERMISO < 100
end

GO
/****** Object:  StoredProcedure [dbo].[spListarTraducciones]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spListarTraducciones] 
@idioma varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY	 
		select e.nombre as 'Etiqueta', t.traduccion as 'Traduccion' from traducciones t
		inner join etiquetas e on e.id_etiqueta = t.id_etiqueta
		inner join idiomas i on i.id_idioma = t.id_idioma
		where i.nombre = @idioma
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spListarUsuariosNoBoss]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spListarUsuariosNoBoss] 

AS

	BEGIN TRANSACTION;

	BEGIN TRY

		select u.nombre from tUsuario u
		inner join USUARIO_PERMISO up on u.nombre = up.ID_USUARIO
		where up.ID_PERMISO > 100


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spModificarEtiqueta]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spModificarEtiqueta] 
@Etiqueta varchar(50),
@NuevoValor varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY
		
		update etiquetas set nombre = @NuevoValor where nombre = @Etiqueta


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spModificarTraduccion]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spModificarTraduccion] 
@Traduccion varchar(50),
@NuevoValor varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY
		

		update traducciones set traduccion = @NuevoValor where traduccion = @Traduccion


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spObtenerIdiomas]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spObtenerIdiomas] 

AS

	BEGIN TRANSACTION;
	BEGIN TRY
		select * from idiomas	
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spObtenerSaldoActual]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spObtenerSaldoActual] 
@nombre varchar(50)
AS

	BEGIN TRANSACTION;

	BEGIN TRY


		select cantidad from tWallet where nombre = @nombre


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spObtenerTraducciones]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spObtenerTraducciones] 
@id_idioma int
AS

	BEGIN TRANSACTION;
	BEGIN TRY
		select t.id_idioma,t.traduccion as traduccion_traduccion, e.id_etiqueta,e.nombre as nombre_etiqueta from traducciones t inner join etiquetas e on t.id_etiqueta=e.id_etiqueta where t.id_idioma = @id_idioma
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spPutFinishHourLog]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spPutFinishHourLog] 

@Nombre varchar(50),
@FecIngreso dateTime,
@FecEgreso dateTime
AS

	BEGIN TRANSACTION;

	BEGIN TRY

		--declare @idAux int
		--IF ((select count(*) from tCopia)= 0)
		--BEGIN
		--	Set @idAux =   1

		--END
		--ELSE
		--BEGIN
		--	Set @idAux = (SELECT top 1 Id from tCopia order by Id DESC)
		--	Set @idAux = @idAux + 1
		--END

		update tLogs set fecEgreso = @FecEgreso where usuario = @Nombre and fecIngreso = @FecIngreso

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spSacarPermiso]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spSacarPermiso]
@IdPadre int,
@IdHijo int
as
	BEGIN TRANSACTION;

	BEGIN TRY
	delete from grupo where ID_GRUPO = @IdPadre and ID_HIJO = @IdHijo
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH

		ROLLBACK TRANSACTION;
	END CATCH;
	
GO
/****** Object:  StoredProcedure [dbo].[spValidarUsuario]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spValidarUsuario] 
@Username varchar(50),
@Clave varchar(50)
AS
	SELECT u.nombre, u.pwd, p.PERMISO  FROM tUsuario u
	inner join USUARIO_PERMISO up on up.ID_Usuario = u.nombre
	inner join PERMISO P on P.ID_PERMISO = up.ID_PERMISO
	WHERE nombre = @Username and Pwd = @Clave


GO
/****** Object:  StoredProcedure [dbo].[USUARIO_PERMISO_LISTAR]    Script Date: 15/01/2022 12:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USUARIO_PERMISO_LISTAR]
@nombre varchar(50)
as
begin
SELECT *  From PERMISO p
Inner join USUARIO_PERMISO u on p.ID_PERMISO = u.ID_PERMISO
where u.ID_USUARIO = @nombre
end

GO
