USE [master]
GO

CREATE DATABASE [DiplomaAUX]

GO
USE [DiplomaAUX]
GO

CREATE TABLE [dbo].[Bitacora](
	[ID_Bitacora] [int] IDENTITY(1,1) NOT NULL,
	[ID_EventoBitacora] [int] NOT NULL,
	[Id] [int] NOT NULL,
	[Fecha] [nvarchar](50) NOT NULL,
	[Hora] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[ID_Bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventoBitacora]    Script Date: 20/11/2021 5:33:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventoBitacora](
	[ID_EventoBitacora] [int] IDENTITY(1,1) NOT NULL,
	[EventoBitacora] [nvarchar](150) NULL,
	[Criticidad] [nvarchar](50) NULL,
 CONSTRAINT [PK_EventoBitacora] PRIMARY KEY CLUSTERED 
(
	[ID_EventoBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 20/11/2021 5:33:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](max) NULL,
	[DVH] [nvarchar](max) NULL,
	[Activo] [bit] NULL,
	[Bloqueado] [bit] NULL,
	[CantidadIntentos] [int] NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31293, 3, 2, N'04/11/2021', N'19:31')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31294, 4, 2, N'01/11/2021', N'7:32')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31295, 3, 2, N'04/11/2021', N'20:19')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31296, 3, 2, N'04/11/2021', N'20:19')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31297, 4, 1012, N'04/11/2021', N'20:20')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31298, 4, 1012, N'04/11/2021', N'20:20')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31299, 4, 1012, N'04/11/2021', N'20:20')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31300, 1, 1012, N'04/11/2021', N'20:20')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31301, 1, 1012, N'04/11/2021', N'20:20')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31302, 1, 1012, N'04/11/2021', N'20:20')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31303, 1, 1012, N'04/11/2021', N'20:20')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31304, 1, 1012, N'04/11/2021', N'20:20')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31305, 3, 2, N'04/11/2021', N'20:20')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (31306, 1, 6019, N'04/11/2021', N'20:28')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (32262, 3, 2, N'20/11/2021', N'17:02')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (32263, 3, 2, N'20/11/2021', N'17:04')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (32264, 3, 2, N'20/11/2021', N'17:06')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (32265, 3, 2, N'20/11/2021', N'17:08')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (32266, 3, 2, N'20/11/2021', N'17:10')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (32267, 3, 2, N'20/11/2021', N'17:13')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (32268, 9, 2, N'20/11/2021', N'17:13')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (32269, 9, 2, N'20/11/2021', N'17:13')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (32270, 10, 2, N'20/11/2021', N'17:13')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (32271, 10, 2, N'20/11/2021', N'17:13')
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[EventoBitacora] ON 

INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora], [Criticidad]) VALUES (1, N'Alta usuarios', N'Baja')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora], [Criticidad]) VALUES (2, N'Asignar Permiso', N'Baja')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora], [Criticidad]) VALUES (3, N'Login', N'Baja')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora], [Criticidad]) VALUES (4, N'Logout', N'Baja')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora], [Criticidad]) VALUES (5, N'Error Digito Verificador Horizontal', N'Alta')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora], [Criticidad]) VALUES (7, N'Error Digito Verificador Vertical', N'Alta')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora], [Criticidad]) VALUES (8, N'Contraseña incorrecta', N'Baja')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora], [Criticidad]) VALUES (9, N'Generar Backup', N'Baja')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora], [Criticidad]) VALUES (10, N'Restaurar Backup', N'Alta')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora], [Criticidad]) VALUES (11, N'Baja Usuario', N'Alta')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora], [Criticidad]) VALUES (12, N'Modificar Usuario', N'Media')
SET IDENTITY_INSERT [dbo].[EventoBitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (2, N'andres.benitez@transener.com.ar', N'andres.benitez@transener.com.ar', N'FC78F43E1AA478259790215C1253E197095A17DE01D688E5361B8D5702455A11691C1A05F961D51F661E2A59A484121F39F44E9A1B147DD55EA7FEC6BC1C94B5', N'7E312F11B637B83187B31A56D88346D4756E3F06AF02F3E9664A8BCF7424D883E148053D93980BE013A0A8C4A3E137C1FDD84437EF32C25A0D33D38AFB2F2DB6', 1, 0, 0, N'Andres', N'Benitez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (1012, N'valeria2275@gmail.com', N'valeria2275@gmail.com', N'FC78F43E1AA478259790215C1253E197095A17DE01D688E5361B8D5702455A11691C1A05F961D51F661E2A59A484121F39F44E9A1B147DD55EA7FEC6BC1C94B5', N'D6B45FA0659F0583A6DA1B8E253ED237F0FBE83279475AAAF9291335DC14850E0A175D4895CBEA2C5F3815D515ADADD949EB7B291D87B2BE81AAA17BBFA53DDE', 1, 0, 0, N'Francisco Andres', N'Benitez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (2012, N'marigomez@gmail.com', N'marigomez@gmail.com', N'DEA4DCDA567C0689A8EF8296763E4247AA667DF6EB33FC854437A896482657817E464CBE3A7F23336FEBEFD74E206B1B027FC84D52662C192866A9768D65E460', N'87CCA69CD6A9E71FA01F95E698F6088AC28E8C3B51DDFCDF8F7390B4DCC21306A262372196B4F835997118B259D551C437BBFC8AF4A084C266819DE365D5B75A', 1, 0, 0, N'MAria', N'Gomez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (3012, N'santi@gmail.com', N'santi@gmail.com', N'8782A2318BDDEA4CD9659C29A87A6863F6E8A3859BD09E24FD4633B41E493CFFB5D432416AC9F06C819DD61F584B6309E3E3C072A3A10D7CF6279EA76C89CF49', N'E941DFA64F701630DD1942FB0075630E67AE0D7AA716517AB522E19E9B7350EFB8BFB71CB6971553C85CF40B72D9C6D6A66C54620D441E0F7CF24DCE57A33F11', 1, 0, 0, N'Santiago', N'Benitez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (3013, N'juan@hotmail.com', N'juan@hotmail.com', N'754552B1C54ACAD09F99ED5F9E2610D99F9397A9331763D99FF8C6D3A9176CB0B308C8E98030875652A2A45C3322F4FDFA44A50926B5458C7DD268BE87BC832D', N'A46AD2B8DF3BEACDC4F16C0F6AE04D57A2969FCC2280AFD83F6E0EEE0A96B2C863A932486634524EF26AAD43E4B9F4A40038B49F84CE7ADBC43A0EF8AFC604F6', 1, 0, 0, N'Juan', N'Lopez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (3014, N'pedro@gmail.com', N'pedro@gmail.com', N'DA670EF2501AABFB29BE3B8DFBBF8CC1ABD687FA2A73B4F27D92C5343512A391BB963BA47F47F58EB9C168E5CA27D3FAD2EF5AACEE1B6918070B98D1A5AFE653', N'A5B457295AA19FD36460AFC92F2D2E68CB9010AECB85E7416FACE7C075C5085DC6F188B601421F37F61391D7C7A711C48F6275E568C1A519086C80EBEF0AB636', 1, 0, 0, N'Pedro', N'Gomez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (3015, N'Marce@hotmail.com', N'Marce@hotmail.com', N'4F715FC6414B6F558789A7EBA0723B19FB7441F4F7BA89A77FD1B45A2DEF9B6141FEE095647675BCB8E291C44E4B5C7E1A3EDA981A8C12B35D4C8DCBA1AD76FF', N'1C7A9B762590914FCB36337A59EE1EDF69267D03A5F7C61847FA22639E7A78F986A1DEF89251A90E7AE4882F62571CD03F64957C0E3E5C36B34BF79FCDF36458', 1, 0, 0, N'Marcela', N'Oldfi')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (4012, N'Julipaz@gmail.com', N'Julipaz@gmail.com', N'B06D732F8BA1B477D1E178A241855EAB0AEB6288629CB9A24174C96B33B80BE2B46F6C2258B57BCCAD1E43637BBE5FBD690D7EDDC59F1B451F46C88F706576BC', N'B508A517CA558063E36230FE3904A3267369278E0F89706FD1FA5AB06239D8C171B0573AA573063274A7066678629CEC3B31686DB1C677B3C6D7528461BA1444', 1, 0, 0, N'Julieta', N'Paz')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (5017, N'juanjuan@gmail.com', N'juanjuan@gmail.com', N'FC78F43E1AA478259790215C1253E197095A17DE01D688E5361B8D5702455A11691C1A05F961D51F661E2A59A484121F39F44E9A1B147DD55EA7FEC6BC1C94B5', N'B7B8CFB6FFBAF9269D45A2399857C95730325A66220FB5F465DB3B04F96AC1CA44F3474B3F6B4C775D0FEC03004B01F4BCC57BEE4BA955673A52FC1DAF9E8EC9', 1, 0, 0, N'Juan', N'Juanes')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (6019, N'juan@hhh.com', N'juan@hhh.com', N'8D32B1CAA694F39C575AB8E9955033BDC16984F5A948A792679A601A3FE5534D351A3E48420E11B53E0A02B9EDEDED71F098CDD1B78441DE679CF46F1B980E9B', N'3E8F9DFA55E8AB36C756CC3EC07A2BECE67B6EFE87524E85BB5BCC857BD96489A80DB8527CDC1E45162B8397177AB53EDD1ECE3606DA89AC2DE7FB507D2F9732', 1, 0, 0, N'pepe', N'lopez')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
USE [master]
GO
ALTER DATABASE [DiplomaAUX] SET  READ_WRITE 
GO
