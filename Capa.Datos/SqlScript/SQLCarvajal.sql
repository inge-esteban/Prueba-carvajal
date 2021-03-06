USE [VuelosCarbajal]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 04/07/2022 17:08:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](100) NULL,
	[contraseña] [nchar](300) NULL,
	[rol] [nchar](20) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vuelo]    Script Date: 04/07/2022 17:08:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vuelo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CiudadOrigen] [nchar](100) NULL,
	[CiudadDestino] [nchar](100) NULL,
	[Fecha] [datetime2](7) NULL,
	[HoraSalida] [nchar](20) NULL,
	[HoraLlegada] [nchar](20) NULL,
	[NumeroVuelo] [int] NULL,
	[Aerolinea] [nvarchar](500) NULL,
	[EstadoVuelo] [nvarchar](500) NULL,
 CONSTRAINT [PK_vuelo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [Nombre], [contraseña], [rol]) VALUES (1, N'Carlos                                                                                              ', N'hola                                                                                                                                                                                                                                                                                                        ', N'adm                 ')
INSERT [dbo].[Usuario] ([Id], [Nombre], [contraseña], [rol]) VALUES (2, N'Esteban                                                                                             ', N'hola                                                                                                                                                                                                                                                                                                        ', N'user                ')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[vuelo] ON 

INSERT [dbo].[vuelo] ([Id], [CiudadOrigen], [CiudadDestino], [Fecha], [HoraSalida], [HoraLlegada], [NumeroVuelo], [Aerolinea], [EstadoVuelo]) VALUES (1, N'Bogotá                                                                                              ', N'Miami                                                                                               ', CAST(N'2022-07-20T00:00:00.0000000' AS DateTime2), N'5:45                ', N'7:30                ', 789, N'Latam', N'A tiempo')
INSERT [dbo].[vuelo] ([Id], [CiudadOrigen], [CiudadDestino], [Fecha], [HoraSalida], [HoraLlegada], [NumeroVuelo], [Aerolinea], [EstadoVuelo]) VALUES (2, N'Madrid                                                                                              ', N'Cartagena                                                                                           ', CAST(N'2022-07-09T00:00:00.0000000' AS DateTime2), N'3:30                ', N'10:45               ', 45, N'Latam', N'A tiempo')
INSERT [dbo].[vuelo] ([Id], [CiudadOrigen], [CiudadDestino], [Fecha], [HoraSalida], [HoraLlegada], [NumeroVuelo], [Aerolinea], [EstadoVuelo]) VALUES (3, N'Nueva York                                                                                          ', N'Los angeles                                                                                         ', CAST(N'2022-07-12T00:00:00.0000000' AS DateTime2), N'5:45                ', N'5:45                ', 5632, N'AirBoy', N'Retrasado')
INSERT [dbo].[vuelo] ([Id], [CiudadOrigen], [CiudadDestino], [Fecha], [HoraSalida], [HoraLlegada], [NumeroVuelo], [Aerolinea], [EstadoVuelo]) VALUES (4, N'Lima                                                                                                ', N'Bogota                                                                                              ', CAST(N'2022-07-04T00:00:00.0000000' AS DateTime2), N'5:45                ', N'6:55                ', 302, N'viva', N'A tiempo')
INSERT [dbo].[vuelo] ([Id], [CiudadOrigen], [CiudadDestino], [Fecha], [HoraSalida], [HoraLlegada], [NumeroVuelo], [Aerolinea], [EstadoVuelo]) VALUES (5, N'Medellin                                                                                            ', N'San jose                                                                                            ', CAST(N'2022-07-04T00:00:00.0000000' AS DateTime2), N'5:6                 ', N'5:45                ', 7859, N'latam', N'Retrasado')
INSERT [dbo].[vuelo] ([Id], [CiudadOrigen], [CiudadDestino], [Fecha], [HoraSalida], [HoraLlegada], [NumeroVuelo], [Aerolinea], [EstadoVuelo]) VALUES (6, N'Cancun                                                                                              ', N'Bogota                                                                                              ', CAST(N'2022-07-04T00:00:00.0000000' AS DateTime2), N'4:55                ', N'5:45                ', 4556, N'MexicoAir', N'A tiempo')
INSERT [dbo].[vuelo] ([Id], [CiudadOrigen], [CiudadDestino], [Fecha], [HoraSalida], [HoraLlegada], [NumeroVuelo], [Aerolinea], [EstadoVuelo]) VALUES (8, N'Bogota                                                                                              ', N'Cali                                                                                                ', CAST(N'2022-07-04T00:00:00.0000000' AS DateTime2), N'5:55                ', N'44:44               ', 753264, N'Viva', N'a tiempo')
SET IDENTITY_INSERT [dbo].[vuelo] OFF
GO
