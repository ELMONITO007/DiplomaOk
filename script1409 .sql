USE master
create database  [Diploma]
GO
USE [Diploma]
GO
/****** Object:  Table [dbo].[Alergias]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alergias](
	[Legajo] [int] NOT NULL,
	[Alergia_Medicamentos] [bit] NULL,
	[Cuales_Alergias_Medicamentos] [nvarchar](50) NULL,
	[Alergia_Alimento] [bit] NULL,
	[Cuales_Alergias_Alimento] [nvarchar](50) NULL,
	[Alergia_Elementos] [bit] NULL,
	[Cuales_Alergias_Elementos] [nvarchar](50) NULL,
	[Otras_Alergias] [nvarchar](50) NULL,
 CONSTRAINT [PK_Alergias] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencia](
	[ID_Asistencia] [int] IDENTITY(1,1) NOT NULL,
	[Dia] [int] NOT NULL,
	[Mes] [int] NOT NULL,
	[Año] [int] NOT NULL,
	[Asistio] [bit] NOT NULL,
	[Legajo] [int] NOT NULL,
 CONSTRAINT [PK_sistencia] PRIMARY KEY CLUSTERED 
(
	[ID_Asistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Backup]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Backup](
	[ID_Backup] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [nvarchar](50) NULL,
	[Nombre] [nvarchar](150) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Backup] PRIMARY KEY CLUSTERED 
(
	[ID_Backup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Boletin]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boletin](
	[ID_Boletin] [int] IDENTITY(1,1) NOT NULL,
	[año] [int] NULL,
	[Cutrimestre] [int] NULL,
	[notas] [nvarchar](max) NULL,
	[legajo] [int] NULL,
 CONSTRAINT [PK_Boletin] PRIMARY KEY CLUSTERED 
(
	[ID_Boletin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Casa]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Casa](
	[Legajo] [int] NOT NULL,
	[Vive_Casa] [bit] NULL,
	[Vive_Departamento] [bit] NULL,
	[Vive_Barrio_Cerrado] [bit] NULL,
	[Tiene_Habitacion_Propia] [bit] NULL,
	[Tiene_Patio] [bit] NULL,
 CONSTRAINT [PK_Casa] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comunicado]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comunicado](
	[ID_Cominicado] [int] IDENTITY(1,1) NOT NULL,
	[legajo] [int] NULL,
	[comunicado] [nvarchar](max) NULL,
	[fecha] [date] NULL,
	[visto] [bit] NULL,
	[legajo_Maestro] [int] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Comunicado] PRIMARY KEY CLUSTERED 
(
	[ID_Cominicado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[ID_Curso] [int] IDENTITY(1,1) NOT NULL,
	[ID_Sala] [int] NULL,
	[Nombre] [nvarchar](50) NULL,
	[ID_Grado] [int] NULL,
	[id_salaHorario] [int] NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[ID_Curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CursoAlumno]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CursoAlumno](
	[ID_Curso] [int] NULL,
	[Legajo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CursoHorario]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CursoHorario](
	[ID_Curso] [int] NOT NULL,
	[ID_MaestroHorario] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documentacion]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documentacion](
	[ID_Documentacion] [int] IDENTITY(1,1) NOT NULL,
	[Legajo] [int] NULL,
	[NombreDocumento] [nvarchar](150) NULL,
	[Activo] [bit] NULL,
	[Año] [int] NULL,
 CONSTRAINT [PK_Documentacion] PRIMARY KEY CLUSTERED 
(
	[ID_Documentacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DVV]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DVV](
	[ID_DVV] [int] IDENTITY(1,1) NOT NULL,
	[Tabla] [nvarchar](50) NOT NULL,
	[DVV] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DVV] PRIMARY KEY CLUSTERED 
(
	[ID_DVV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[ID_Especialidad] [int] IDENTITY(1,1) NOT NULL,
	[Especialidad] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Especialidad] PRIMARY KEY CLUSTERED 
(
	[ID_Especialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EspecialidadPersona]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EspecialidadPersona](
	[Legajo] [int] NULL,
	[ID_Especialidad] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventoBitacora]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventoBitacora](
	[ID_EventoBitacora] [int] IDENTITY(1,1) NOT NULL,
	[EventoBitacora] [nvarchar](150) NULL,
 CONSTRAINT [PK_EventoBitacora] PRIMARY KEY CLUSTERED 
(
	[ID_EventoBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examen]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examen](
	[Id_Examen] [int] IDENTITY(1,1) NOT NULL,
	[Legajo] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Nota] [int] NOT NULL,
	[Id_Materia] [int] NOT NULL,
 CONSTRAINT [PK_Examen] PRIMARY KEY CLUSTERED 
(
	[Id_Examen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familia](
	[Legajo] [int] NOT NULL,
	[Padres_Separados] [bit] NULL,
	[Hermanos] [bit] NULL,
	[Vive_Abuela] [bit] NULL,
	[Tiene_Tios] [bit] NULL,
	[Papa_Trabajo] [bit] NULL,
	[Mama_Trabajo] [bit] NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grado]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grado](
	[ID_Grado] [int] IDENTITY(1,1) NOT NULL,
	[Año] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Grado] PRIMARY KEY CLUSTERED 
(
	[ID_Grado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[ID_Idioma] [int] IDENTITY(1,1) NOT NULL,
	[Idioma] [nvarchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Codigo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[ID_Idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Maestro_Horario]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maestro_Horario](
	[Legajo] [int] NULL,
	[DiaSemana] [int] NULL,
	[Turno] [nvarchar](50) NULL,
	[Hora] [int] NULL,
	[Año] [int] NULL,
	[Disponible] [bit] NULL,
	[ID_MaestroHorario] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Maestro_Horario] PRIMARY KEY CLUSTERED 
(
	[ID_MaestroHorario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mantenimiento]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mantenimiento](
	[Id_mantenimiento] [int] IDENTITY(1,1) NOT NULL,
	[Id_tipoMantenimiento] [int] NOT NULL,
	[fecha] [date] NULL,
	[fechaRealizado] [date] NULL,
	[Realizado] [bit] NULL,
	[ID_Proveedor] [int] NULL,
	[Activo] [bit] NULL,
	[Legajo] [int] NULL,
 CONSTRAINT [PK_Mantenimiento] PRIMARY KEY CLUSTERED 
(
	[Id_mantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[ID_Materia] [int] IDENTITY(1,1) NOT NULL,
	[Materia] [nvarchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
	[ID_especialidad] [int] NULL,
 CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED 
(
	[ID_Materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obras_Social]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obras_Social](
	[Legajo] [int] NOT NULL,
	[Tiene_Obra_Social] [bit] NULL,
	[Obra_Social] [nvarchar](50) NULL,
	[Telefono_Emergencia] [int] NULL,
	[Numero_Socio] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Palabra]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Palabra](
	[ID_Palabra] [int] IDENTITY(1,1) NOT NULL,
	[Palabra] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Palabra] PRIMARY KEY CLUSTERED 
(
	[ID_Palabra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parentesco]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parentesco](
	[Legajo_Alumno] [int] NULL,
	[Legajo_Adulto] [int] NULL,
	[Parentesco] [nvarchar](50) NULL,
	[AutorizadoRetirar] [bit] NULL,
	[Id_Parentesco] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_AutorizadoRetirar] PRIMARY KEY CLUSTERED 
(
	[Id_Parentesco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Legajo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[DNI] [nvarchar](50) NULL,
	[Tipo_Persona] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
	[fechaNacimiento] [date] NULL,
 CONSTRAINT [PK_TelefonoPersona] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Id_TipoProveedor] [int] NULL,
	[matricula] [nvarchar](50) NULL,
	[nombre] [nvarchar](50) NULL,
	[telefono] [nvarchar](50) NULL,
	[contacto] [nvarchar](50) NULL,
	[cuit] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[Id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolesComposite]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolesComposite](
	[ID_Rol] [int] IDENTITY(1,1) NOT NULL,
	[ID_CompositeRol] [int] NULL,
	[ID_CompositePermiso] [int] NULL,
 CONSTRAINT [PK_RolesComposite] PRIMARY KEY CLUSTERED 
(
	[ID_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[ID_Sala] [int] IDENTITY(1,1) NOT NULL,
	[ID_TipoSala] [int] NOT NULL,
	[Capacidad] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Tiempo] [bit] NOT NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[ID_Sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala_Horario]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala_Horario](
	[ID_Sala] [int] NULL,
	[DiaSemana] [int] NULL,
	[Turno] [nvarchar](50) NULL,
	[Hora] [int] NULL,
	[Año] [int] NULL,
	[ID_SalaHorario] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Sala_Horario] PRIMARY KEY CLUSTERED 
(
	[ID_SalaHorario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefono](
	[ID_Telefono] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Area] [int] NULL,
	[Numero] [int] NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED 
(
	[ID_Telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TelefonoPersona]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelefonoPersona](
	[Legajo] [int] NULL,
	[ID_Telefono] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoMantenimiento]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMantenimiento](
	[Id_TipoMantenimiento] [int] IDENTITY(1,1) NOT NULL,
	[Id_TipoProveedor] [int] NULL,
	[periocidad] [int] NULL,
	[tipoMantenimiento] [nvarchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_TipoMantenimiento] PRIMARY KEY CLUSTERED 
(
	[Id_TipoMantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPersona]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPersona](
	[ID_Tipo_Persona] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_TipoPersona] PRIMARY KEY CLUSTERED 
(
	[ID_Tipo_Persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoProveedor]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoProveedor](
	[Id_TipoProveedor] [int] IDENTITY(1,1) NOT NULL,
	[TipoProveedor] [nvarchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_TipoProveedor] PRIMARY KEY CLUSTERED 
(
	[Id_TipoProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoSala]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoSala](
	[Id_TipoSala] [int] IDENTITY(1,1) NOT NULL,
	[TipoSala] [nvarchar](50) NULL,
 CONSTRAINT [PK_TipoSala] PRIMARY KEY CLUSTERED 
(
	[Id_TipoSala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[ID_Idioma] [int] NOT NULL,
	[ID_Palabra] [int] NOT NULL,
	[Traduccion] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 20/11/2021 5:32:58 p. m. ******/
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
/****** Object:  Table [dbo].[UsuarioPersona]    Script Date: 20/11/2021 5:32:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPersona](
	[Legajo] [int] NULL,
	[Id] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Alergias] ([Legajo], [Alergia_Medicamentos], [Cuales_Alergias_Medicamentos], [Alergia_Alimento], [Cuales_Alergias_Alimento], [Alergia_Elementos], [Cuales_Alergias_Elementos], [Otras_Alergias]) VALUES (13, 0, NULL, 0, N'', 0, N'', N'')
INSERT [dbo].[Alergias] ([Legajo], [Alergia_Medicamentos], [Cuales_Alergias_Medicamentos], [Alergia_Alimento], [Cuales_Alergias_Alimento], [Alergia_Elementos], [Cuales_Alergias_Elementos], [Otras_Alergias]) VALUES (2020, 1, NULL, 0, N'', 0, N'', N'Otras Alergias')
INSERT [dbo].[Alergias] ([Legajo], [Alergia_Medicamentos], [Cuales_Alergias_Medicamentos], [Alergia_Alimento], [Cuales_Alergias_Alimento], [Alergia_Elementos], [Cuales_Alergias_Elementos], [Otras_Alergias]) VALUES (2021, 0, NULL, 1, N'Pollo', 0, N'', N'Otras Alergias')
INSERT [dbo].[Alergias] ([Legajo], [Alergia_Medicamentos], [Cuales_Alergias_Medicamentos], [Alergia_Alimento], [Cuales_Alergias_Alimento], [Alergia_Elementos], [Cuales_Alergias_Elementos], [Otras_Alergias]) VALUES (2022, 0, NULL, 0, N'', 1, N'Perfume', N'Risntitis')
INSERT [dbo].[Alergias] ([Legajo], [Alergia_Medicamentos], [Cuales_Alergias_Medicamentos], [Alergia_Alimento], [Cuales_Alergias_Alimento], [Alergia_Elementos], [Cuales_Alergias_Elementos], [Otras_Alergias]) VALUES (5021, 0, NULL, 0, N'', 0, N'', N'Otras Alergias')
GO
SET IDENTITY_INSERT [dbo].[Asistencia] ON 

INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (2, 2, 3, 2021, 1, 13)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (3, 2, 3, 2021, 0, 2020)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (4, 1, 3, 2021, 1, 13)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (5, 1, 3, 2021, 1, 2020)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (6, 3, 3, 2021, 1, 13)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (7, 3, 3, 2021, 1, 2020)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (8, 3, 4, 2021, 1, 13)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (9, 4, 3, 2021, 1, 13)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (10, 4, 3, 2021, 1, 2020)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (11, 2, 8, 2021, 1, 13)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (12, 2, 8, 2021, 1, 2020)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (13, 3, 8, 2021, 1, 13)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (14, 3, 8, 2021, 1, 2020)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (15, 2, 7, 2021, 1, 13)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (16, 2, 7, 2021, 1, 2020)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (17, 9, 9, 2021, 1, 13)
INSERT [dbo].[Asistencia] ([ID_Asistencia], [Dia], [Mes], [Año], [Asistio], [Legajo]) VALUES (18, 9, 9, 2021, 1, 2020)
SET IDENTITY_INSERT [dbo].[Asistencia] OFF
GO
SET IDENTITY_INSERT [dbo].[AspNetRoles] ON 

INSERT [dbo].[AspNetRoles] ([Id], [Name], [Activo]) VALUES (1, N'Backcups', 0)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [Activo]) VALUES (2, N'Backcup', 1)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [Activo]) VALUES (1005, N'Administrador', 1)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [Activo]) VALUES (1007, N'Alumno', 1)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [Activo]) VALUES (1008, N'Gestion Alumno', 1)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [Activo]) VALUES (1009, N'Gestion Aula', 1)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [Activo]) VALUES (1010, N'Administracion', 1)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [Activo]) VALUES (1011, N'Secretaria', 1)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [Activo]) VALUES (1012, N'Backcups', 0)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [Activo]) VALUES (1013, N'UAI', 0)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [Activo]) VALUES (1015, N'Maestro', 1)
SET IDENTITY_INSERT [dbo].[AspNetRoles] OFF
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (2, 1005)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (1012, 1007)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (2012, 1007)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (3012, 1007)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (3013, 1007)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (3014, 1007)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (3015, 1007)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (4012, 1007)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (4013, 1015)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (5013, 1007)
GO
SET IDENTITY_INSERT [dbo].[Backup] ON 

INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (3, N'15-02-2021 06 29 48', N'Backup-15-02-2021 06 29 48', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (1002, N'16-02-2021 05 28 26', N'Backup-16-02-2021 05 28 26', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (1003, N'16-02-2021 06 22 00', N'Backup-16-02-2021 06 22 00', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (1004, N'20-02-2021 11 23 29', N'Backup-20-02-2021 11 23 29', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (1005, N'22-02-2021 10 53 09', N'Backup-22-02-2021 10 53 09', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (1006, N'22-02-2021 12 19 57', N'Backup-22-02-2021 12 19 57', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (1007, N'22-02-2021 06 51 02', N'Backup-22-02-2021 06 51 02', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (1008, N'16-03-2021 08 37 12', N'Backup-16-03-2021 08 37 12', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (1009, N'16-03-2021 10 02 38', N'Backup-16-03-2021 10 02 38', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2003, N'28-06-2021 06 38 55', N'Backup-28-06-2021 06 38 55', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2004, N'28-06-2021 06 42 14', N'Backup-28-06-2021 06 42 14', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2005, N'28-06-2021 06 45 25', N'Backup-28-06-2021 06 45 25', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2006, N'28-06-2021 06 45 45', N'Backup-28-06-2021 06 45 45', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2007, N'28-06-2021 06 47 14', N'Backup-28-06-2021 06 47 14', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2008, N'28-06-2021 06 47 33', N'Backup-28-06-2021 06 47 33', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2009, N'28-06-2021 07 07 59', N'Backup-28-06-2021 07 07 59', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2010, N'28-06-2021 07 08 24', N'Backup-28-06-2021 07 08 24', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2011, N'28-06-2021 07 08 30', N'Backup-28-06-2021 07 08 30', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2012, N'28-06-2021 07 08 56', N'Backup-28-06-2021 07 08 56', 0)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2013, N'15-07-2021 11 34 32', N'Backup-15-07-2021 11 34 32', 1)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2014, N'18-09-2021 03 36 24', N'Backup-18-09-2021 03 36 24', 1)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2015, N'14-10-2021 05 41 08', N'Backup-14-10-2021 05 41 08', 1)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2016, N'14-10-2021 07 54 11', N'Backup-14-10-2021 07 54 11', 1)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2017, N'21-10-2021 08 11 31', N'Backup-21-10-2021 08 11 31', 1)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2018, N'28-10-2021 08 44 54', N'Backup-28-10-2021 08 44 54', 1)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2019, N'02-11-2021 10 18 40', N'Backup-02-11-2021 10 18 40', 1)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2020, N'04-11-2021 05 48 58', N'Backup-04-11-2021 05 48 58', 1)
INSERT [dbo].[Backup] ([ID_Backup], [Fecha], [Nombre], [Activo]) VALUES (2021, N'20-11-2021 05 13 12', N'Backup-20-11-2021 05 13 12', 1)
SET IDENTITY_INSERT [dbo].[Backup] OFF
GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (17179, 3, 2, N'22/09/2021', N'20:26')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (17180, 3, 2, N'22/09/2021', N'20:28')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (17181, 3, 2, N'22/09/2021', N'20:29')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (17182, 3, 2, N'22/09/2021', N'20:30')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (17183, 3, 2, N'22/09/2021', N'20:36')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (17184, 3, 2, N'22/09/2021', N'20:39')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (18178, 3, 2, N'25/09/2021', N'19:41')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (18179, 3, 2, N'25/09/2021', N'19:44')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (18180, 3, 2, N'25/09/2021', N'19:51')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (18181, 3, 2, N'25/09/2021', N'19:57')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (18182, 3, 2, N'25/09/2021', N'20:00')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (18183, 3, 2, N'25/09/2021', N'20:40')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19178, 3, 2, N'26/09/2021', N'19:36')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19179, 3, 2, N'26/09/2021', N'19:44')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19180, 3, 2, N'26/09/2021', N'19:45')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19181, 3, 2, N'26/09/2021', N'19:47')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19182, 3, 2, N'26/09/2021', N'19:48')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19183, 3, 2, N'26/09/2021', N'19:49')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19184, 3, 2, N'26/09/2021', N'19:51')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19185, 3, 2, N'26/09/2021', N'19:52')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19186, 3, 2, N'26/09/2021', N'19:53')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19187, 3, 2, N'26/09/2021', N'19:57')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19188, 3, 2, N'26/09/2021', N'19:58')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19189, 3, 2, N'26/09/2021', N'19:59')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19190, 3, 2, N'26/09/2021', N'20:00')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19191, 3, 2, N'26/09/2021', N'20:02')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19192, 3, 2, N'26/09/2021', N'20:05')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (19193, 3, 2, N'26/09/2021', N'20:06')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (20178, 3, 2, N'12/10/2021', N'23:17')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (21178, 3, 2, N'13/10/2021', N'17:41')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (21179, 3, 2, N'13/10/2021', N'17:41')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (21180, 3, 2, N'13/10/2021', N'18:26')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (21181, 3, 2, N'13/10/2021', N'18:59')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (21182, 3, 2, N'13/10/2021', N'19:01')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (21183, 3, 2, N'13/10/2021', N'19:09')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22178, 3, 2, N'14/10/2021', N'16:51')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22179, 3, 2, N'14/10/2021', N'16:59')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22180, 3, 2, N'14/10/2021', N'17:00')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22181, 3, 2, N'14/10/2021', N'17:02')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22182, 3, 2, N'14/10/2021', N'17:04')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22183, 3, 2, N'14/10/2021', N'17:07')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22184, 3, 2, N'14/10/2021', N'17:10')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22185, 3, 2, N'14/10/2021', N'17:11')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22186, 3, 2, N'14/10/2021', N'17:12')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22187, 3, 2, N'14/10/2021', N'17:14')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22188, 3, 2, N'14/10/2021', N'17:17')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22189, 3, 2, N'14/10/2021', N'17:19')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22190, 3, 2, N'14/10/2021', N'17:21')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22191, 3, 2, N'14/10/2021', N'17:22')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22192, 3, 2, N'14/10/2021', N'17:26')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22193, 3, 2, N'14/10/2021', N'17:26')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22194, 3, 2, N'14/10/2021', N'17:28')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22195, 3, 2, N'14/10/2021', N'17:28')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22196, 3, 2, N'14/10/2021', N'17:30')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22197, 3, 2, N'14/10/2021', N'17:36')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22198, 3, 2, N'14/10/2021', N'17:36')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22199, 3, 2, N'14/10/2021', N'17:38')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22200, 3, 2, N'14/10/2021', N'17:39')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22201, 3, 2, N'14/10/2021', N'17:39')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22202, 3, 2, N'14/10/2021', N'17:40')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22203, 3, 2, N'14/10/2021', N'17:41')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_EventoBitacora], [Id], [Fecha], [Hora]) VALUES (22204, 3, 2, N'14/10/2021', N'19:39')
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[Boletin] ON 

INSERT [dbo].[Boletin] ([ID_Boletin], [año], [Cutrimestre], [notas], [legajo]) VALUES (2, 2021, 4, N'', 2020)
SET IDENTITY_INSERT [dbo].[Boletin] OFF
GO
INSERT [dbo].[Casa] ([Legajo], [Vive_Casa], [Vive_Departamento], [Vive_Barrio_Cerrado], [Tiene_Habitacion_Propia], [Tiene_Patio]) VALUES (13, 0, 1, 0, 1, 0)
INSERT [dbo].[Casa] ([Legajo], [Vive_Casa], [Vive_Departamento], [Vive_Barrio_Cerrado], [Tiene_Habitacion_Propia], [Tiene_Patio]) VALUES (2020, 1, 0, 0, 0, 0)
INSERT [dbo].[Casa] ([Legajo], [Vive_Casa], [Vive_Departamento], [Vive_Barrio_Cerrado], [Tiene_Habitacion_Propia], [Tiene_Patio]) VALUES (2021, 1, 0, 1, 0, 0)
INSERT [dbo].[Casa] ([Legajo], [Vive_Casa], [Vive_Departamento], [Vive_Barrio_Cerrado], [Tiene_Habitacion_Propia], [Tiene_Patio]) VALUES (2022, 0, 0, 0, 1, 0)
INSERT [dbo].[Casa] ([Legajo], [Vive_Casa], [Vive_Departamento], [Vive_Barrio_Cerrado], [Tiene_Habitacion_Propia], [Tiene_Patio]) VALUES (5021, 1, 0, 0, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Comunicado] ON 

INSERT [dbo].[Comunicado] ([ID_Cominicado], [legajo], [comunicado], [fecha], [visto], [legajo_Maestro], [activo]) VALUES (1, 13, N'Fran se proto bien.', CAST(N'2021-10-24' AS Date), 1, 1019, 1)
SET IDENTITY_INSERT [dbo].[Comunicado] OFF
GO
SET IDENTITY_INSERT [dbo].[Curso] ON 

INSERT [dbo].[Curso] ([ID_Curso], [ID_Sala], [Nombre], [ID_Grado], [id_salaHorario]) VALUES (2, 1, N'Roja', 1, 8)
INSERT [dbo].[Curso] ([ID_Curso], [ID_Sala], [Nombre], [ID_Grado], [id_salaHorario]) VALUES (1002, 1, N'Nocheros', 1, 1005)
INSERT [dbo].[Curso] ([ID_Curso], [ID_Sala], [Nombre], [ID_Grado], [id_salaHorario]) VALUES (1003, 6, N'Violeta', 2, 1007)
SET IDENTITY_INSERT [dbo].[Curso] OFF
GO
INSERT [dbo].[CursoAlumno] ([ID_Curso], [Legajo]) VALUES (1003, 4021)
INSERT [dbo].[CursoAlumno] ([ID_Curso], [Legajo]) VALUES (2, 1022)
INSERT [dbo].[CursoAlumno] ([ID_Curso], [Legajo]) VALUES (2, 13)
INSERT [dbo].[CursoAlumno] ([ID_Curso], [Legajo]) VALUES (1003, 2021)
INSERT [dbo].[CursoAlumno] ([ID_Curso], [Legajo]) VALUES (2, 2020)
INSERT [dbo].[CursoAlumno] ([ID_Curso], [Legajo]) VALUES (2, 4021)
GO
INSERT [dbo].[CursoHorario] ([ID_Curso], [ID_MaestroHorario]) VALUES (2, 1)
INSERT [dbo].[CursoHorario] ([ID_Curso], [ID_MaestroHorario]) VALUES (2, 1003)
INSERT [dbo].[CursoHorario] ([ID_Curso], [ID_MaestroHorario]) VALUES (2, 3011)
INSERT [dbo].[CursoHorario] ([ID_Curso], [ID_MaestroHorario]) VALUES (1003, 3015)
GO
SET IDENTITY_INSERT [dbo].[Documentacion] ON 

INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (1, 13, N'DNI Alumno', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2, 13, N'DNI Padre', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (3, 13, N'Certificado Nacimientos', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (4, 13, N'Vacunas', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (1002, 1022, N'DNI Maestro', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (1003, 1022, N'Titulo Maestro', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (1004, 1022, N'Certificado Maestro', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2002, 2020, N'DNI Alumno', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2003, 2020, N'DNI Padre', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2004, 2020, N'Certificado Nacimientos', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2005, 2020, N'Vacunas', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2006, 2021, N'DNI Alumno', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2007, 2021, N'DNI Padre', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2008, 2021, N'Certificado Nacimientos', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2009, 2021, N'Vacunas', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2010, 2022, N'DNI Alumno', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2011, 2022, N'DNI Padre', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2012, 2022, N'Certificado Nacimientos', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2013, 2022, N'Vacunas', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2014, 2023, N'DNI Maestro', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2015, 2023, N'Titulo Maestro', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (2016, 2023, N'Certificado Maestro', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (3002, 3020, N'DNI Maestro', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (3003, 3020, N'Titulo Maestro', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (3004, 3020, N'Certificado Maestro', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (3005, 4021, NULL, 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (3006, 4021, NULL, 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (3007, 4021, NULL, 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (4005, 5021, N'DNI Alumno', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (4006, 5021, N'DNI Padre', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (4007, 5021, N'Certificado Nacimientos', 1, 2021)
INSERT [dbo].[Documentacion] ([ID_Documentacion], [Legajo], [NombreDocumento], [Activo], [Año]) VALUES (4008, 5021, N'Vacunas', 1, 2021)
SET IDENTITY_INSERT [dbo].[Documentacion] OFF
GO
SET IDENTITY_INSERT [dbo].[DVV] ON 

INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (2, N'Usuario', N'58BF6B5F8B61C4F5BA5232D55C8E3EAE145BEFF4184F9362495D4E10F855CDCA906BE20F33AF22C4E20D361FB9D5C79F217DDC263817D6536EECA15BE78D5248')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (1011, N'Usuario', N'65797D534AC4E244C526EA8CE1866FC33A4E90E3E2141277D784B327CE57198A84234CC2AC16C6C6C734C939A34142501BE88776590D4C1972FF07096B535FA9')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (2011, N'Usuario', N'26026672DAF7D2180A64A584545EBE0DC7F7A7674E6B543E29DEED3B8D2663856C5D45220CCF7745F4D20A4E38EA541EC094904130B6572FCC849671D5B5206C')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (3011, N'Usuario', N'210FF3C4FA177C7A97C1B64153BFB58487A161DB842C1B77FCF121ECD5CAFE32E3F02B139972D5B805373A260E3BEFD03AD2C55D680924BDED7484F47F44A5C0')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (3012, N'Usuario', N'65C1BACFFD765EC756A788EEC8B885FB8014676429EE558B3936EAD889ECE0343F6F412EAE2589D8C8714C1B1CD5B4C9EF0B128ACE5A9251952F336EA4086A42')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (3013, N'Usuario', N'9A0C70FEF5DE7329BC6C50DAABE887F64CA2734D5738B692E9A9606D08C80DE925D1BF7577CE0F5A52B3B262C23784E599A6E38315AE331F0CBA37E745FBC43B')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (3014, N'Usuario', N'60C20A8B42092B70559E9A25E4C35DBE9E76B95BA17E2AA3676F8C0C52EF0EF663B1BD595D461D78C163C6C3C1910A1C76823E3EFB558BAE5FEFCD90CC056BA1')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (4011, N'Usuario', N'51883D543C64F895C797BCB5C4763767A76BC7B60D2B7166003A1308503DDDAF0C933E1F5E9BCE5E05D66D636BA140B334881372FAB570493EB62178C777D466')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (5011, N'Usuario', N'C6B046FCEB63413AD46EFF3BB84674145B40EED8F3C5C083EB0D2087C8B36665083B7C754A0EF0EC492FC3D055A833A42EAF7104C1187B47364E2D2556646F9B')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (6011, N'Usuario', N'C6B046FCEB63413AD46EFF3BB84674145B40EED8F3C5C083EB0D2087C8B36665083B7C754A0EF0EC492FC3D055A833A42EAF7104C1187B47364E2D2556646F9B')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (6012, N'Usuario', N'C6B046FCEB63413AD46EFF3BB84674145B40EED8F3C5C083EB0D2087C8B36665083B7C754A0EF0EC492FC3D055A833A42EAF7104C1187B47364E2D2556646F9B')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (6013, N'Usuario', N'C6B046FCEB63413AD46EFF3BB84674145B40EED8F3C5C083EB0D2087C8B36665083B7C754A0EF0EC492FC3D055A833A42EAF7104C1187B47364E2D2556646F9B')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (6014, N'Usuario', N'F6909B1FFB05F7CD3B6D6CC56A541C1294531A3EE2A2E68ADA377D265917233D5EFD45770EFC02AC83A0A44E7DF1A3E5D823CDF44B6BB7D9F8A43176F8B00B8C')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (7011, N'Usuario', N'F6909B1FFB05F7CD3B6D6CC56A541C1294531A3EE2A2E68ADA377D265917233D5EFD45770EFC02AC83A0A44E7DF1A3E5D823CDF44B6BB7D9F8A43176F8B00B8C')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (7012, N'Usuario', N'5B9294A5B9D6F4CFAB3EBE644825D07827EB3DD15D6953D368BE8A8DFC73F58FA92101BF29658707D332878908ADFB636EA07E9113F4895068A534C1781062C8')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (8011, N'Usuario', N'5B9294A5B9D6F4CFAB3EBE644825D07827EB3DD15D6953D368BE8A8DFC73F58FA92101BF29658707D332878908ADFB636EA07E9113F4895068A534C1781062C8')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (8012, N'Usuario', N'5B9294A5B9D6F4CFAB3EBE644825D07827EB3DD15D6953D368BE8A8DFC73F58FA92101BF29658707D332878908ADFB636EA07E9113F4895068A534C1781062C8')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (8013, N'Usuario', N'8645E5FB09BDFB7F80C4D48881409D1C05A55879B3AC43F66EF24D748795C6DA2CB62A2B7080DFE8D8B4F2A75DA9883F2AB2A6D3AF43E966810012BB951C3F12')
INSERT [dbo].[DVV] ([ID_DVV], [Tabla], [DVV]) VALUES (9012, N'Usuario', N'8645E5FB09BDFB7F80C4D48881409D1C05A55879B3AC43F66EF24D748795C6DA2CB62A2B7080DFE8D8B4F2A75DA9883F2AB2A6D3AF43E966810012BB951C3F12')
SET IDENTITY_INSERT [dbo].[DVV] OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidad] ON 

INSERT [dbo].[Especialidad] ([ID_Especialidad], [Especialidad], [Activo]) VALUES (1, N'Maestro', 1)
INSERT [dbo].[Especialidad] ([ID_Especialidad], [Especialidad], [Activo]) VALUES (2, N'Musica', 1)
INSERT [dbo].[Especialidad] ([ID_Especialidad], [Especialidad], [Activo]) VALUES (3, N'Dibujo', 1)
INSERT [dbo].[Especialidad] ([ID_Especialidad], [Especialidad], [Activo]) VALUES (4, N'Educacion Fisica', 1)
INSERT [dbo].[Especialidad] ([ID_Especialidad], [Especialidad], [Activo]) VALUES (5, N'Ingles', 1)
SET IDENTITY_INSERT [dbo].[Especialidad] OFF
GO
INSERT [dbo].[EspecialidadPersona] ([Legajo], [ID_Especialidad]) VALUES (1022, 1)
INSERT [dbo].[EspecialidadPersona] ([Legajo], [ID_Especialidad]) VALUES (2023, 1)
INSERT [dbo].[EspecialidadPersona] ([Legajo], [ID_Especialidad]) VALUES (3020, 3)
INSERT [dbo].[EspecialidadPersona] ([Legajo], [ID_Especialidad]) VALUES (4021, 4)
GO
SET IDENTITY_INSERT [dbo].[EventoBitacora] ON 

INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (1, N'Alta usuarios')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (2, N'Asignar Permiso')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (3, N'Login')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (4, N'Logout')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (5, N'Error Digito Verificador Horizontal')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (7, N'Error Digito Verificador Vertical')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (8, N'Contraseña incorrecta')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (9, N'Generar Backup')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (10, N'Restaurar Backup')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (11, N'Baja Usuario')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (12, N'Modificar Usuario')
INSERT [dbo].[EventoBitacora] ([ID_EventoBitacora], [EventoBitacora]) VALUES (13, N'')
SET IDENTITY_INSERT [dbo].[EventoBitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[Examen] ON 

INSERT [dbo].[Examen] ([Id_Examen], [Legajo], [Fecha], [Nota], [Id_Materia]) VALUES (1, 13, CAST(N'2021-10-24' AS Date), 9, 1)
INSERT [dbo].[Examen] ([Id_Examen], [Legajo], [Fecha], [Nota], [Id_Materia]) VALUES (2, 13, CAST(N'2021-10-28' AS Date), 9, 1003)
INSERT [dbo].[Examen] ([Id_Examen], [Legajo], [Fecha], [Nota], [Id_Materia]) VALUES (3, 13, CAST(N'2021-10-28' AS Date), 9, 1004)
INSERT [dbo].[Examen] ([Id_Examen], [Legajo], [Fecha], [Nota], [Id_Materia]) VALUES (4, 13, CAST(N'2021-11-04' AS Date), 8, 1004)
SET IDENTITY_INSERT [dbo].[Examen] OFF
GO
INSERT [dbo].[Familia] ([Legajo], [Padres_Separados], [Hermanos], [Vive_Abuela], [Tiene_Tios], [Papa_Trabajo], [Mama_Trabajo]) VALUES (13, NULL, 1, 0, 1, 1, 1)
INSERT [dbo].[Familia] ([Legajo], [Padres_Separados], [Hermanos], [Vive_Abuela], [Tiene_Tios], [Papa_Trabajo], [Mama_Trabajo]) VALUES (2020, NULL, 0, 0, 1, 0, 0)
INSERT [dbo].[Familia] ([Legajo], [Padres_Separados], [Hermanos], [Vive_Abuela], [Tiene_Tios], [Papa_Trabajo], [Mama_Trabajo]) VALUES (2021, NULL, 0, 0, 1, 0, 1)
INSERT [dbo].[Familia] ([Legajo], [Padres_Separados], [Hermanos], [Vive_Abuela], [Tiene_Tios], [Papa_Trabajo], [Mama_Trabajo]) VALUES (2022, NULL, 0, 0, 0, 1, 0)
INSERT [dbo].[Familia] ([Legajo], [Padres_Separados], [Hermanos], [Vive_Abuela], [Tiene_Tios], [Papa_Trabajo], [Mama_Trabajo]) VALUES (5021, NULL, 1, 0, 0, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Grado] ON 

INSERT [dbo].[Grado] ([ID_Grado], [Año], [Nombre], [Activo]) VALUES (1, 4, N'Jardin', 1)
INSERT [dbo].[Grado] ([ID_Grado], [Año], [Nombre], [Activo]) VALUES (2, 5, N'Preescolar', 1)
INSERT [dbo].[Grado] ([ID_Grado], [Año], [Nombre], [Activo]) VALUES (3, 3, N'Salita de 3', 1)
SET IDENTITY_INSERT [dbo].[Grado] OFF
GO
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma], [Activo], [Codigo]) VALUES (1007, N'Español', 1, N'es-AR')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma], [Activo], [Codigo]) VALUES (1013, N'Ingles', 1, N'en-US')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma], [Activo], [Codigo]) VALUES (2012, N'Portugues', 1, N'pt-BR')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma], [Activo], [Codigo]) VALUES (3012, N'Frances', 1, N'fr-FR')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma], [Activo], [Codigo]) VALUES (3013, N'Diploma', 1, N'es-ES')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
GO
SET IDENTITY_INSERT [dbo].[Maestro_Horario] ON 

INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (1022, 0, N'Mañana', 0, 2021, 0, 1)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (2023, 0, N'Tarde', 0, 2021, 1, 2)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (3020, 1, N'Mañana', 1, 2021, 0, 1003)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (3020, 1, N'Mañana', 2, 2021, 1, 1004)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (3020, 1, N'Mañana', 3, 2021, 1, 1005)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (3020, 1, N'Mañana', 4, 2021, 1, 1006)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (3020, 1, N'Mañana', 5, 2021, 1, 1007)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (3020, 2, N'Tarde', 1, 2021, 1, 1008)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (3020, 2, N'Tarde', 2, 2021, 1, 1009)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (3020, 2, N'Tarde', 3, 2021, 1, 1010)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (3020, 2, N'Tarde', 4, 2021, 1, 1011)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (3020, 2, N'Tarde', 5, 2021, 1, 1012)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (2023, 0, N'Mañana', 0, 2021, 1, 2002)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (1022, 0, N'Tarde', 0, 2021, 1, 2003)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (3020, 1, N'Mañana', 1, 2021, 1, 2004)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (4021, 1, N'Mañana', 2, 2021, 0, 3011)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (4021, 1, N'Mañana', 3, 2021, 1, 3012)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (4021, 1, N'Mañana', 4, 2021, 1, 3013)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (4021, 1, N'Mañana', 5, 2021, 1, 3014)
INSERT [dbo].[Maestro_Horario] ([Legajo], [DiaSemana], [Turno], [Hora], [Año], [Disponible], [ID_MaestroHorario]) VALUES (4021, 1, N'Mañana', 1, 2021, 0, 3015)
SET IDENTITY_INSERT [dbo].[Maestro_Horario] OFF
GO
SET IDENTITY_INSERT [dbo].[Mantenimiento] ON 

INSERT [dbo].[Mantenimiento] ([Id_mantenimiento], [Id_tipoMantenimiento], [fecha], [fechaRealizado], [Realizado], [ID_Proveedor], [Activo], [Legajo]) VALUES (1, 2, CAST(N'2021-09-18' AS Date), CAST(N'2021-09-18' AS Date), 1, 1, 1, 1019)
SET IDENTITY_INSERT [dbo].[Mantenimiento] OFF
GO
SET IDENTITY_INSERT [dbo].[Materia] ON 

INSERT [dbo].[Materia] ([ID_Materia], [Materia], [Activo], [ID_especialidad]) VALUES (1, N'Dibujo', 1, 3)
INSERT [dbo].[Materia] ([ID_Materia], [Materia], [Activo], [ID_especialidad]) VALUES (2, N'Musica', 0, 2)
INSERT [dbo].[Materia] ([ID_Materia], [Materia], [Activo], [ID_especialidad]) VALUES (1002, N'Ingles', 1, 5)
INSERT [dbo].[Materia] ([ID_Materia], [Materia], [Activo], [ID_especialidad]) VALUES (1003, N'Matematica', 1, 1)
INSERT [dbo].[Materia] ([ID_Materia], [Materia], [Activo], [ID_especialidad]) VALUES (1004, N'Lengua', 1, 1)
INSERT [dbo].[Materia] ([ID_Materia], [Materia], [Activo], [ID_especialidad]) VALUES (1005, N'Educacion Fisica', 1, 4)
INSERT [dbo].[Materia] ([ID_Materia], [Materia], [Activo], [ID_especialidad]) VALUES (1006, N'Musica', 1, 2)
SET IDENTITY_INSERT [dbo].[Materia] OFF
GO
INSERT [dbo].[Obras_Social] ([Legajo], [Tiene_Obra_Social], [Obra_Social], [Telefono_Emergencia], [Numero_Socio]) VALUES (13, 1, N'Galeno', 1144559966, 16156185)
INSERT [dbo].[Obras_Social] ([Legajo], [Tiene_Obra_Social], [Obra_Social], [Telefono_Emergencia], [Numero_Socio]) VALUES (2020, 1, N'OLX', 1123314444, 168416841)
INSERT [dbo].[Obras_Social] ([Legajo], [Tiene_Obra_Social], [Obra_Social], [Telefono_Emergencia], [Numero_Socio]) VALUES (2021, 0, N'', 0, 0)
INSERT [dbo].[Obras_Social] ([Legajo], [Tiene_Obra_Social], [Obra_Social], [Telefono_Emergencia], [Numero_Socio]) VALUES (2022, 0, N'', 0, 0)
INSERT [dbo].[Obras_Social] ([Legajo], [Tiene_Obra_Social], [Obra_Social], [Telefono_Emergencia], [Numero_Socio]) VALUES (5021, 1, N'Galeno', 1144448888, 7278)
GO
SET IDENTITY_INSERT [dbo].[Palabra] ON 

INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1, N'Aceptar', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (2, N'Cancelar', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3, N'Alta', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (4, N'Eliminar', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (5, N'Modificar', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (6, N'Buscar', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (7, N'Usuario', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (8, N'Contraseña', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (9, N'Pregunta Secreta', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (10, N'Respuesta Secreta', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (11, N'Nuevo Usuario', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (12, N'Cerrar Sesion', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (13, N'Gestion de Usuarios', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (14, N'Gestion de Bitacora', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (15, N'Gestion de Permisos', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (16, N'Gestion de Idiomas', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (17, N'Gestion de Backup', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (18, N'Cambiar Idioma', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (19, N'Alta de Idioma', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (20, N'Gestion de Infra', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (21, N'Gestion de Ventas', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (22, N'Gestion de personal', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (23, N'Servicios', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (24, N'Gestion de Alumnos', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (25, N'Gestion Intitucional', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1018, N'VerTodo', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1019, N'Ver por usuario', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1020, N'Ver por evento', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1021, N'Gestion intitucional', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1022, N'Recuperar Backup', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1023, N'Crear Backup', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1024, N'Nombre del Archivo', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1025, N'Listar', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1026, N'Desbloquear', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1027, N'Nombre Usuario', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1028, N'Intentos Logueo', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1029, N'Bloqueado', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1030, N'Nombre', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1031, N'Apellido', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1032, N'Error Buscar', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (1033, N'Garta', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (2033, N'Palabra', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (2035, N'Traduccion', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3041, N'Ingresar', 0)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3042, N'Ingresar', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3043, N'Configuraciones', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3044, N'Gestion salas', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3045, N'Boletin', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3046, N'Proyecto', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3047, N'Idioma', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3048, N'Crear', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3049, N'Restaurar', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3050, N'Consistencia', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3051, N'Permiso', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3052, N'Ver permisos de roles', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3053, N'Asignar roles o permisos', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3054, N'Quitar Roles o permisos', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3055, N'Permisos a usuarios', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3056, N'Quitar Permiso Usuario', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3057, N'Roles', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3058, N'Rol', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3059, N'Quitar Permiso', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3060, N'Agregar Permiso', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3061, N'Roles o permisos disponibles', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3062, N'Permisos o Rol', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3063, N'Listado', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3064, N'Seleccionar', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3065, N'CambiarContraseña', 1)
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra], [Activo]) VALUES (3066, N'Codigo', 1)
SET IDENTITY_INSERT [dbo].[Palabra] OFF
GO
SET IDENTITY_INSERT [dbo].[Parentesco] ON 

INSERT [dbo].[Parentesco] ([Legajo_Alumno], [Legajo_Adulto], [Parentesco], [AutorizadoRetirar], [Id_Parentesco]) VALUES (13, 1018, N'Madre', 1, 1)
INSERT [dbo].[Parentesco] ([Legajo_Alumno], [Legajo_Adulto], [Parentesco], [AutorizadoRetirar], [Id_Parentesco]) VALUES (13, 1019, N'Madre', 1, 2)
INSERT [dbo].[Parentesco] ([Legajo_Alumno], [Legajo_Adulto], [Parentesco], [AutorizadoRetirar], [Id_Parentesco]) VALUES (13, 3021, N'Abuela', 1, 3)
INSERT [dbo].[Parentesco] ([Legajo_Alumno], [Legajo_Adulto], [Parentesco], [AutorizadoRetirar], [Id_Parentesco]) VALUES (5021, 5022, N'Padre', 1, 1003)
SET IDENTITY_INSERT [dbo].[Parentesco] OFF
GO
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (13, N'Francisco Andres', N'Benitez', N'Oran 3069 Ituzaingo', N'52610649', N'Alumno', 1, CAST(N'2016-07-14' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (1018, N'Valeria', N'Midun', N'oran 3069', N'25482078', N'Familiar', 1, CAST(N'1976-06-26' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (1019, N'Andres', N'Benitez', N'oran 3069', N'30963708', N'Familiar', 1, CAST(N'1984-11-12' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (1022, N'Maria', N'Gomez', N'jamaica 123', N'25999966', N'Maestro', 1, CAST(N'2003-02-22' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (2020, N'Santiago', N'Benitez', N'Perez 123', N'53555999', N'Alumno', 1, CAST(N'2017-02-21' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (2021, N'Juan', N'Lopez', N'kip 555', N'59000555', N'Alumno', 1, CAST(N'2016-02-09' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (2022, N'Pedro', N'Gomez', N'peron 555', N'58666444', N'Alumno', 1, CAST(N'2016-02-09' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (2023, N'Marcela', N'Oldfi', N'Kiopp 555', N'25888666', N'Maestro', 1, CAST(N'1999-06-08' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (3020, N'Julieta', N'Paz', N'Ole 1234', N'29865666', N'Maestro', 1, CAST(N'2003-02-25' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (3021, N'Marta', N'Tritten', N'oran 3069', N'6555999', N'Pariente', 0, CAST(N'1946-12-05' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (4021, N'Juan', N'Juanes', N'Paris 123', N'25889124', N'Maestro', 1, CAST(N'2000-02-08' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (5021, N'pepe', N'lopez', N'pepe 123', N'52666999', N'Alumno', 1, CAST(N'2018-01-16' AS Date))
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [Tipo_Persona], [Activo], [fechaNacimiento]) VALUES (5022, N'Jauan', N'Pepe', N'sarasa 123', N'25888999', N'Pariente', 1, CAST(N'2003-05-13' AS Date))
SET IDENTITY_INSERT [dbo].[Persona] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([Id_proveedor], [Id_TipoProveedor], [matricula], [nombre], [telefono], [contacto], [cuit], [Activo]) VALUES (1, 1, N'4161651', N'Juan Tanque', N'1144445663', N'Juan Lipe', N'23669998887', 1)
INSERT [dbo].[Proveedor] ([Id_proveedor], [Id_TipoProveedor], [matricula], [nombre], [telefono], [contacto], [cuit], [Activo]) VALUES (2, 1, N'4154641', N'Lopcito', N'1144449999', N'juan perez', N'23232226669', 1)
INSERT [dbo].[Proveedor] ([Id_proveedor], [Id_TipoProveedor], [matricula], [nombre], [telefono], [contacto], [cuit], [Activo]) VALUES (3, 2, N'555666', N'Yasta', N'1144449922', N'Mariano perez', N'23232226339', 1)
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[RolesComposite] ON 

INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1, NULL, 1)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (2, NULL, 2)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1004, 1005, NULL)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1008, 1005, 2)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1009, NULL, 1007)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1010, NULL, 1008)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1011, NULL, 1009)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1012, 1010, NULL)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1013, 1010, 1008)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1015, 1005, 1010)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1016, 1010, 1009)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1018, 1011, NULL)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1019, 1011, 1008)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1021, NULL, 1012)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1022, 1005, 1012)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1027, NULL, 1013)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1029, 1005, 1011)
INSERT [dbo].[RolesComposite] ([ID_Rol], [ID_CompositeRol], [ID_CompositePermiso]) VALUES (1030, 1015, NULL)
SET IDENTITY_INSERT [dbo].[RolesComposite] OFF
GO
SET IDENTITY_INSERT [dbo].[Sala] ON 

INSERT [dbo].[Sala] ([ID_Sala], [ID_TipoSala], [Capacidad], [Nombre], [Activo], [Tiempo]) VALUES (1, 2, 29, N'PBuno', 1, 0)
INSERT [dbo].[Sala] ([ID_Sala], [ID_TipoSala], [Capacidad], [Nombre], [Activo], [Tiempo]) VALUES (2, 2, 30, N'PBdos', 1, 0)
INSERT [dbo].[Sala] ([ID_Sala], [ID_TipoSala], [Capacidad], [Nombre], [Activo], [Tiempo]) VALUES (3, 2, 30, N'PBtres', 1, 0)
INSERT [dbo].[Sala] ([ID_Sala], [ID_TipoSala], [Capacidad], [Nombre], [Activo], [Tiempo]) VALUES (4, 2, 25, N'PBcuatro', 1, 0)
INSERT [dbo].[Sala] ([ID_Sala], [ID_TipoSala], [Capacidad], [Nombre], [Activo], [Tiempo]) VALUES (6, 2, 25, N'PBseis', 1, 0)
SET IDENTITY_INSERT [dbo].[Sala] OFF
GO
SET IDENTITY_INSERT [dbo].[Sala_Horario] ON 

INSERT [dbo].[Sala_Horario] ([ID_Sala], [DiaSemana], [Turno], [Hora], [Año], [ID_SalaHorario]) VALUES (1, 0, N'Mañana', 0, 2021, 8)
INSERT [dbo].[Sala_Horario] ([ID_Sala], [DiaSemana], [Turno], [Hora], [Año], [ID_SalaHorario]) VALUES (1, 0, N'Tarde', 0, 2022, 1005)
INSERT [dbo].[Sala_Horario] ([ID_Sala], [DiaSemana], [Turno], [Hora], [Año], [ID_SalaHorario]) VALUES (1, 0, N'Mañana', 0, 2021, 1006)
INSERT [dbo].[Sala_Horario] ([ID_Sala], [DiaSemana], [Turno], [Hora], [Año], [ID_SalaHorario]) VALUES (6, 0, N'Mañana', 0, 2021, 1007)
SET IDENTITY_INSERT [dbo].[Sala_Horario] OFF
GO
SET IDENTITY_INSERT [dbo].[Telefono] ON 

INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (1, 11, 44945252, NULL, 1)
INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (2, 11, 44945355, NULL, 1)
INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (1002, 11, 44945354, NULL, 1)
INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (1003, 11, 44553399, NULL, 1)
INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (2003, 11, 44995566, NULL, 1)
INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (2004, 11, 55556333, NULL, 1)
INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (2005, 11, 44995522, NULL, 1)
INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (2006, 11, 55552212, NULL, 1)
INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (3003, 11, 53338979, NULL, 1)
INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (3004, 11, 44816989, NULL, 1)
INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (4004, 11, 44886666, NULL, 1)
INSERT [dbo].[Telefono] ([ID_Telefono], [Codigo_Area], [Numero], [Descripcion], [Activo]) VALUES (4005, 11, 55559966, NULL, 1)
SET IDENTITY_INSERT [dbo].[Telefono] OFF
GO
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (13, 1)
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (1018, 2)
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (1019, 1002)
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (1022, 1003)
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (2020, 2003)
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (2021, 2004)
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (2022, 2005)
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (2023, 2006)
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (3020, 3003)
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (3021, 3004)
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (5021, 4004)
INSERT [dbo].[TelefonoPersona] ([Legajo], [ID_Telefono]) VALUES (5022, 4005)
GO
SET IDENTITY_INSERT [dbo].[TipoMantenimiento] ON 

INSERT [dbo].[TipoMantenimiento] ([Id_TipoMantenimiento], [Id_TipoProveedor], [periocidad], [tipoMantenimiento], [activo]) VALUES (2, 1, 11, N'Limpieza Tanque', 1)
INSERT [dbo].[TipoMantenimiento] ([Id_TipoMantenimiento], [Id_TipoProveedor], [periocidad], [tipoMantenimiento], [activo]) VALUES (3, 2, 3, N'Cucarachas', 1)
SET IDENTITY_INSERT [dbo].[TipoMantenimiento] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoPersona] ON 

INSERT [dbo].[TipoPersona] ([ID_Tipo_Persona], [Descripcion]) VALUES (1, N'Alumno')
INSERT [dbo].[TipoPersona] ([ID_Tipo_Persona], [Descripcion]) VALUES (2, N'Secretaria')
INSERT [dbo].[TipoPersona] ([ID_Tipo_Persona], [Descripcion]) VALUES (3, N'Maestro')
INSERT [dbo].[TipoPersona] ([ID_Tipo_Persona], [Descripcion]) VALUES (4, N'Administrativo')
INSERT [dbo].[TipoPersona] ([ID_Tipo_Persona], [Descripcion]) VALUES (5, N'Familiar')
SET IDENTITY_INSERT [dbo].[TipoPersona] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoProveedor] ON 

INSERT [dbo].[TipoProveedor] ([Id_TipoProveedor], [TipoProveedor], [activo]) VALUES (1, N'Tanque', 1)
INSERT [dbo].[TipoProveedor] ([Id_TipoProveedor], [TipoProveedor], [activo]) VALUES (2, N'Desinfeccion', 1)
INSERT [dbo].[TipoProveedor] ([Id_TipoProveedor], [TipoProveedor], [activo]) VALUES (3, N'Gases', 0)
SET IDENTITY_INSERT [dbo].[TipoProveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoSala] ON 

INSERT [dbo].[TipoSala] ([Id_TipoSala], [TipoSala]) VALUES (1, N'Musica')
INSERT [dbo].[TipoSala] ([Id_TipoSala], [TipoSala]) VALUES (2, N'Grado')
INSERT [dbo].[TipoSala] ([Id_TipoSala], [TipoSala]) VALUES (3, N'Dibujo')
SET IDENTITY_INSERT [dbo].[TipoSala] OFF
GO
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1, N'Aceptar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3, N'Alta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 19, N'Alta de Idioma')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1031, N'Apellido')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1029, N'Bloqueado')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 6, N'Buscar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 11, N'Cambiar Contraseña')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 18, N'Cambiar Idioma')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 2, N'Cancelar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 12, N'Cerrar Sesion')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 8, N'Contraseña')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1023, N'Crear Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1026, N'Desbloquear')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 4, N'Eliminar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1032, N'Erro Buscar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1033, N'Garta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 24, N'Gestion de Alumnos')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 17, N'Gestion de Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 14, N'Gestion de Bitacora')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 16, N'Gestion de Idiomas')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 20, N'Gestion de Infra')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 15, N'Gestion de Permisos')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 22, N'Gestion de Personal')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 13, N'Gestion de Usuarios')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 21, N'Gestion de Ventas')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 25, N'Gestion Institucional')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1021, N'Gestion Institucional')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1028, N'Intentos Logueo')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1025, N'Listar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 5, N'Modificar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1030, N'Nombre')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1024, N'Nombre del Archivo')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1027, N'Nombre Usuario')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 2033, N'Palabras')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 9, N'Pregunta Secreta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1022, N'Recuperar Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 10, N'Respuesta Secreta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 23, N'Servicios')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 7, N'Usuario')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1020, N'Ver Por Evento')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1019, N'Ver Por Usuario')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 1018, N'Ver todos')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 2035, N'Traduccion')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1, N'Code')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 2, N'Cancel')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3, N'Create')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 4, N'Delete')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 5, N'Update')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 6, N'Search')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 7, N'User')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 8, N'Password')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 9, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 10, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 11, N'New User')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 12, N'Close Session')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 13, N'User Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 14, N'Logs Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 15, N'Permission Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 16, N'Languaje Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 17, N'Backup Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 18, N'Chamgre Languaje')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 19, N'Create Languaje')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 20, N'Infra Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 21, N'Sales Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 22, N'RRHH Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 23, N'Services')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 24, N'Student Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 25, N'Institucional Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1018, N'See all')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1019, N'See by user')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1020, N'See by event')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1021, N'Institucional Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1022, N'Restore Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1023, N'New Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1024, N'FileName')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1025, N'List')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1026, N'UnBlock')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1027, N'Username')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1028, N'Login Attemp')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1029, N'Blocked')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1030, N'Name')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1031, N'UserName')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1032, N'Search Error')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 1033, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 2033, N'Words')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 2035, N'Traduction')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3042, N'Ingresar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3042, N'Enter')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3043, N'Configuraciones')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3043, N'Settings')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3044, N'Gestion salas')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3044, N'classroom Managment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3045, N'Boletin')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3045, N'Boletin')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3046, N'Proyecto')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3046, N'Project')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3047, N'Idioma')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3047, N'Languaje')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 2, NULL)
GO
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 4, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 5, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 6, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 7, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 8, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 9, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 10, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 11, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 12, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 13, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 14, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 15, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 16, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 17, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 18, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 19, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 20, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 21, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 22, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 23, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 24, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 25, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1018, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1019, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1020, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1021, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1022, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1023, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1024, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1025, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1026, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1027, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1028, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1029, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1030, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1031, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1032, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 1033, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 2033, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 2035, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3042, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3043, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3044, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3045, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3046, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3047, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3048, N'Restaurar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3048, N'Create')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3048, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3049, N'Restaurar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3049, N'Restore')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3049, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3050, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3050, N'BD State')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3050, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3051, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3066, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3066, N'Code')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3066, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1, N'Aceitar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 2, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 4, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 5, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 6, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 7, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 8, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 9, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 10, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 11, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 12, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 13, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 14, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 15, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 16, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 17, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 18, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 19, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 20, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 21, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 22, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 23, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 24, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 25, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1018, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1019, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1020, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1021, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1022, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1023, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1024, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1025, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1026, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1027, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1028, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1029, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1030, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1031, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1032, NULL)
GO
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 1033, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 2033, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 2035, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3042, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3043, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3044, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3045, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3046, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3047, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3048, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3049, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3050, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3051, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3052, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3053, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3054, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3055, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3056, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3057, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3058, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3059, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3060, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3061, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3062, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3063, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3064, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3065, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3012, 3066, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1, N'UAI')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 2, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3, N'Sistemas')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 4, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 5, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 6, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 7, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 8, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 9, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 10, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 11, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 12, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 13, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 14, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 15, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 16, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 17, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 18, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 19, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 20, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 21, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 22, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 23, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 24, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 25, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1018, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1019, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1020, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1021, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1022, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1023, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1024, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1025, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1026, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1027, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1028, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1029, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1030, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1031, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1032, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 1033, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 2033, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 2035, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3042, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3043, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3044, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3045, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3046, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3047, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3048, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3049, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3050, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3051, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3052, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3053, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3054, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3055, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3056, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3057, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3058, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3059, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3060, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3061, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3062, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3063, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3064, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3051, N'permissions')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3051, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3052, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3052, N'View role of permissions')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3052, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3053, NULL)
GO
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3053, N'Assign roles or permissions')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3053, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3054, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3054, N'Remove Roles or permissions')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3054, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3055, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3055, N'User permissions')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3055, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3056, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3056, N'Remove User Permission')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3056, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3057, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3057, N'Roles')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3057, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3058, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3058, N'Role')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3058, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3059, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3059, N'Remove Permission')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3059, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3060, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3060, N'Add Permission')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3060, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3061, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3061, N'Available roles or permissions')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3061, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3062, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3062, N'Permissions or Role')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3062, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3063, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3063, N'List')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3063, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3064, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3064, N'Select')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3064, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1007, 3065, N'Cambiar contraseña')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (1013, 3065, N'Change Password')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (2012, 3065, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3065, NULL)
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Traduccion]) VALUES (3013, 3066, NULL)
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (2, N'andres.benitez@transener.com.ar', N'andres.benitez@transener.com.ar', N'FC78F43E1AA478259790215C1253E197095A17DE01D688E5361B8D5702455A11691C1A05F961D51F661E2A59A484121F39F44E9A1B147DD55EA7FEC6BC1C94B5', N'7E312F11B637B83187B31A56D88346D4756E3F06AF02F3E9664A8BCF7424D883E148053D93980BE013A0A8C4A3E137C1FDD84437EF32C25A0D33D38AFB2F2DB6', 1, 0, 0, N'Andres', N'Benitez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (1012, N'valeria2275@gmail.com', N'valeria2275@gmail.com', N'FC78F43E1AA478259790215C1253E197095A17DE01D688E5361B8D5702455A11691C1A05F961D51F661E2A59A484121F39F44E9A1B147DD55EA7FEC6BC1C94B5', N'5C62B60331FEAB7016304D02AD968921ABE933A987777E307BD7639F30B54EFE5C108BBDF1F4A0DC4A97BCCF112BE3DC96A323D0FBAB73A0A48C4DCCDC196D9B', 1, 0, 0, N'Francisco Andres', N'Benitez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (2012, N'marigomez@gmail.com', N'marigomez@gmail.com', N'DEA4DCDA567C0689A8EF8296763E4247AA667DF6EB33FC854437A896482657817E464CBE3A7F23336FEBEFD74E206B1B027FC84D52662C192866A9768D65E460', N'87CCA69CD6A9E71FA01F95E698F6088AC28E8C3B51DDFCDF8F7390B4DCC21306A262372196B4F835997118B259D551C437BBFC8AF4A084C266819DE365D5B75A', 1, 0, 0, N'MAria', N'Gomez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (3012, N'santi@gmail.com', N'santi@gmail.com', N'8782A2318BDDEA4CD9659C29A87A6863F6E8A3859BD09E24FD4633B41E493CFFB5D432416AC9F06C819DD61F584B6309E3E3C072A3A10D7CF6279EA76C89CF49', N'E941DFA64F701630DD1942FB0075630E67AE0D7AA716517AB522E19E9B7350EFB8BFB71CB6971553C85CF40B72D9C6D6A66C54620D441E0F7CF24DCE57A33F11', 1, 0, 0, N'Santiago', N'Benitez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (3013, N'juan@hotmail.com', N'juan@hotmail.com', N'754552B1C54ACAD09F99ED5F9E2610D99F9397A9331763D99FF8C6D3A9176CB0B308C8E98030875652A2A45C3322F4FDFA44A50926B5458C7DD268BE87BC832D', N'A46AD2B8DF3BEACDC4F16C0F6AE04D57A2969FCC2280AFD83F6E0EEE0A96B2C863A932486634524EF26AAD43E4B9F4A40038B49F84CE7ADBC43A0EF8AFC604F6', 1, 0, 0, N'Juan', N'Lopez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (3014, N'pedro@gmail.com', N'pedro@gmail.com', N'DA670EF2501AABFB29BE3B8DFBBF8CC1ABD687FA2A73B4F27D92C5343512A391BB963BA47F47F58EB9C168E5CA27D3FAD2EF5AACEE1B6918070B98D1A5AFE653', N'A5B457295AA19FD36460AFC92F2D2E68CB9010AECB85E7416FACE7C075C5085DC6F188B601421F37F61391D7C7A711C48F6275E568C1A519086C80EBEF0AB636', 1, 0, 0, N'Pedro', N'Gomez')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (3015, N'Marce@hotmail.com', N'Marce@hotmail.com', N'4F715FC6414B6F558789A7EBA0723B19FB7441F4F7BA89A77FD1B45A2DEF9B6141FEE095647675BCB8E291C44E4B5C7E1A3EDA981A8C12B35D4C8DCBA1AD76FF', N'1C7A9B762590914FCB36337A59EE1EDF69267D03A5F7C61847FA22639E7A78F986A1DEF89251A90E7AE4882F62571CD03F64957C0E3E5C36B34BF79FCDF36458', 1, 0, 0, N'Marcela', N'Oldfi')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (4012, N'Julipaz@gmail.com', N'Julipaz@gmail.com', N'B06D732F8BA1B477D1E178A241855EAB0AEB6288629CB9A24174C96B33B80BE2B46F6C2258B57BCCAD1E43637BBE5FBD690D7EDDC59F1B451F46C88F706576BC', N'B508A517CA558063E36230FE3904A3267369278E0F89706FD1FA5AB06239D8C171B0573AA573063274A7066678629CEC3B31686DB1C677B3C6D7528461BA1444', 1, 0, 0, N'Julieta', N'Paz')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (4013, N'juanjuan@gmail.com', N'juanjuan@gmail.com', N'FC78F43E1AA478259790215C1253E197095A17DE01D688E5361B8D5702455A11691C1A05F961D51F661E2A59A484121F39F44E9A1B147DD55EA7FEC6BC1C94B5', N'B7B8CFB6FFBAF9269D45A2399857C95730325A66220FB5F465DB3B04F96AC1CA44F3474B3F6B4C775D0FEC03004B01F4BCC57BEE4BA955673A52FC1DAF9E8EC9', 1, 0, 0, N'Juan', N'Juanes')
INSERT [dbo].[Usuario] ([Id], [UserName], [Email], [Password], [DVH], [Activo], [Bloqueado], [CantidadIntentos], [Nombre], [Apellido]) VALUES (5013, N'juan@hhh.com', N'juan@hhh.com', N'8D32B1CAA694F39C575AB8E9955033BDC16984F5A948A792679A601A3FE5534D351A3E48420E11B53E0A02B9EDEDED71F098CDD1B78441DE679CF46F1B980E9B', N'3E8F9DFA55E8AB36C756CC3EC07A2BECE67B6EFE87524E85BB5BCC857BD96489A80DB8527CDC1E45162B8397177AB53EDD1ECE3606DA89AC2DE7FB507D2F9732', 1, 0, 0, N'pepe', N'lopez')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
INSERT [dbo].[UsuarioPersona] ([Legajo], [Id]) VALUES (13, 1012)
INSERT [dbo].[UsuarioPersona] ([Legajo], [Id]) VALUES (1022, 2012)
INSERT [dbo].[UsuarioPersona] ([Legajo], [Id]) VALUES (2020, 3012)
INSERT [dbo].[UsuarioPersona] ([Legajo], [Id]) VALUES (2021, 3013)
INSERT [dbo].[UsuarioPersona] ([Legajo], [Id]) VALUES (2022, 3014)
INSERT [dbo].[UsuarioPersona] ([Legajo], [Id]) VALUES (2023, 3015)
INSERT [dbo].[UsuarioPersona] ([Legajo], [Id]) VALUES (3020, 4012)
INSERT [dbo].[UsuarioPersona] ([Legajo], [Id]) VALUES (1019, 2)
INSERT [dbo].[UsuarioPersona] ([Legajo], [Id]) VALUES (4021, 4013)
INSERT [dbo].[UsuarioPersona] ([Legajo], [Id]) VALUES (5021, 5013)
GO
ALTER TABLE [dbo].[Alergias]  WITH CHECK ADD  CONSTRAINT [FK_Alergias_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Alergias] CHECK CONSTRAINT [FK_Alergias_Persona]
GO
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_Persona] FOREIGN KEY([Año])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_Persona]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_Usuario1] FOREIGN KEY([UserId])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_Usuario1]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_EventoBitacora] FOREIGN KEY([ID_EventoBitacora])
REFERENCES [dbo].[EventoBitacora] ([ID_EventoBitacora])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_EventoBitacora]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
ALTER TABLE [dbo].[Boletin]  WITH CHECK ADD  CONSTRAINT [FK_Boletin_Persona] FOREIGN KEY([legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Boletin] CHECK CONSTRAINT [FK_Boletin_Persona]
GO
ALTER TABLE [dbo].[Casa]  WITH CHECK ADD  CONSTRAINT [FK_Casa_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Casa] CHECK CONSTRAINT [FK_Casa_Persona]
GO
ALTER TABLE [dbo].[Comunicado]  WITH CHECK ADD  CONSTRAINT [FK_Comunicado_Persona] FOREIGN KEY([legajo_Maestro])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Comunicado] CHECK CONSTRAINT [FK_Comunicado_Persona]
GO
ALTER TABLE [dbo].[Comunicado]  WITH CHECK ADD  CONSTRAINT [FK_Comunicado_Persona1] FOREIGN KEY([legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Comunicado] CHECK CONSTRAINT [FK_Comunicado_Persona1]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Grado] FOREIGN KEY([ID_Grado])
REFERENCES [dbo].[Grado] ([ID_Grado])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Grado]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Sala] FOREIGN KEY([ID_Sala])
REFERENCES [dbo].[Sala] ([ID_Sala])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Sala]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Sala_Horario1] FOREIGN KEY([id_salaHorario])
REFERENCES [dbo].[Sala_Horario] ([ID_SalaHorario])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Sala_Horario1]
GO
ALTER TABLE [dbo].[CursoAlumno]  WITH CHECK ADD  CONSTRAINT [FK_CursoAlumno_Curso] FOREIGN KEY([ID_Curso])
REFERENCES [dbo].[Curso] ([ID_Curso])
GO
ALTER TABLE [dbo].[CursoAlumno] CHECK CONSTRAINT [FK_CursoAlumno_Curso]
GO
ALTER TABLE [dbo].[CursoAlumno]  WITH CHECK ADD  CONSTRAINT [FK_CursoAlumno_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[CursoAlumno] CHECK CONSTRAINT [FK_CursoAlumno_Persona]
GO
ALTER TABLE [dbo].[CursoHorario]  WITH CHECK ADD  CONSTRAINT [FK_CursoHorario_Curso] FOREIGN KEY([ID_Curso])
REFERENCES [dbo].[Curso] ([ID_Curso])
GO
ALTER TABLE [dbo].[CursoHorario] CHECK CONSTRAINT [FK_CursoHorario_Curso]
GO
ALTER TABLE [dbo].[CursoHorario]  WITH CHECK ADD  CONSTRAINT [FK_CursoHorario_Maestro_Horario] FOREIGN KEY([ID_MaestroHorario])
REFERENCES [dbo].[Maestro_Horario] ([ID_MaestroHorario])
GO
ALTER TABLE [dbo].[CursoHorario] CHECK CONSTRAINT [FK_CursoHorario_Maestro_Horario]
GO
ALTER TABLE [dbo].[Documentacion]  WITH CHECK ADD  CONSTRAINT [FK_Documentacion_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Documentacion] CHECK CONSTRAINT [FK_Documentacion_Persona]
GO
ALTER TABLE [dbo].[EspecialidadPersona]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadPersona_Especialidad] FOREIGN KEY([ID_Especialidad])
REFERENCES [dbo].[Especialidad] ([ID_Especialidad])
GO
ALTER TABLE [dbo].[EspecialidadPersona] CHECK CONSTRAINT [FK_EspecialidadPersona_Especialidad]
GO
ALTER TABLE [dbo].[EspecialidadPersona]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadPersona_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[EspecialidadPersona] CHECK CONSTRAINT [FK_EspecialidadPersona_Persona]
GO
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD  CONSTRAINT [FK_Examen_Materia] FOREIGN KEY([Id_Materia])
REFERENCES [dbo].[Materia] ([ID_Materia])
GO
ALTER TABLE [dbo].[Examen] CHECK CONSTRAINT [FK_Examen_Materia]
GO
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD  CONSTRAINT [FK_Examen_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Examen] CHECK CONSTRAINT [FK_Examen_Persona]
GO
ALTER TABLE [dbo].[Familia]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Familia] CHECK CONSTRAINT [FK_Familia_Persona]
GO
ALTER TABLE [dbo].[Maestro_Horario]  WITH CHECK ADD  CONSTRAINT [FK_Maestro_Horario_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Maestro_Horario] CHECK CONSTRAINT [FK_Maestro_Horario_Persona]
GO
ALTER TABLE [dbo].[Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_Mantenimiento_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Mantenimiento] CHECK CONSTRAINT [FK_Mantenimiento_Persona]
GO
ALTER TABLE [dbo].[Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_Mantenimiento_TipoMantenimiento] FOREIGN KEY([Id_tipoMantenimiento])
REFERENCES [dbo].[TipoMantenimiento] ([Id_TipoMantenimiento])
GO
ALTER TABLE [dbo].[Mantenimiento] CHECK CONSTRAINT [FK_Mantenimiento_TipoMantenimiento]
GO
ALTER TABLE [dbo].[Materia]  WITH CHECK ADD  CONSTRAINT [FK_Materia_Especialidad] FOREIGN KEY([ID_especialidad])
REFERENCES [dbo].[Especialidad] ([ID_Especialidad])
GO
ALTER TABLE [dbo].[Materia] CHECK CONSTRAINT [FK_Materia_Especialidad]
GO
ALTER TABLE [dbo].[Obras_Social]  WITH CHECK ADD  CONSTRAINT [FK_Obras_Social_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Obras_Social] CHECK CONSTRAINT [FK_Obras_Social_Persona]
GO
ALTER TABLE [dbo].[Parentesco]  WITH CHECK ADD  CONSTRAINT [FK_AutorizadoRetirar_Persona] FOREIGN KEY([Legajo_Alumno])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Parentesco] CHECK CONSTRAINT [FK_AutorizadoRetirar_Persona]
GO
ALTER TABLE [dbo].[Parentesco]  WITH CHECK ADD  CONSTRAINT [FK_AutorizadoRetirar_Persona1] FOREIGN KEY([Legajo_Adulto])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Parentesco] CHECK CONSTRAINT [FK_AutorizadoRetirar_Persona1]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_TipoProveedor] FOREIGN KEY([Id_TipoProveedor])
REFERENCES [dbo].[TipoProveedor] ([Id_TipoProveedor])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_TipoProveedor]
GO
ALTER TABLE [dbo].[RolesComposite]  WITH CHECK ADD  CONSTRAINT [FK_RolesComposite_AspNetRoles] FOREIGN KEY([ID_CompositeRol])
REFERENCES [dbo].[AspNetRoles] ([Id])
GO
ALTER TABLE [dbo].[RolesComposite] CHECK CONSTRAINT [FK_RolesComposite_AspNetRoles]
GO
ALTER TABLE [dbo].[RolesComposite]  WITH CHECK ADD  CONSTRAINT [FK_RolesComposite_AspNetRoles1] FOREIGN KEY([ID_CompositePermiso])
REFERENCES [dbo].[AspNetRoles] ([Id])
GO
ALTER TABLE [dbo].[RolesComposite] CHECK CONSTRAINT [FK_RolesComposite_AspNetRoles1]
GO
ALTER TABLE [dbo].[Sala]  WITH CHECK ADD  CONSTRAINT [FK_Sala_TipoSala] FOREIGN KEY([ID_TipoSala])
REFERENCES [dbo].[TipoSala] ([Id_TipoSala])
GO
ALTER TABLE [dbo].[Sala] CHECK CONSTRAINT [FK_Sala_TipoSala]
GO
ALTER TABLE [dbo].[Sala_Horario]  WITH CHECK ADD  CONSTRAINT [FK_Sala_Horario_Sala] FOREIGN KEY([ID_Sala])
REFERENCES [dbo].[Sala] ([ID_Sala])
GO
ALTER TABLE [dbo].[Sala_Horario] CHECK CONSTRAINT [FK_Sala_Horario_Sala]
GO
ALTER TABLE [dbo].[TelefonoPersona]  WITH CHECK ADD  CONSTRAINT [FK_TelefonoPersona_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[TelefonoPersona] CHECK CONSTRAINT [FK_TelefonoPersona_Persona]
GO
ALTER TABLE [dbo].[TelefonoPersona]  WITH CHECK ADD  CONSTRAINT [FK_TelefonoPersona_Telefono] FOREIGN KEY([ID_Telefono])
REFERENCES [dbo].[Telefono] ([ID_Telefono])
GO
ALTER TABLE [dbo].[TelefonoPersona] CHECK CONSTRAINT [FK_TelefonoPersona_Telefono]
GO
ALTER TABLE [dbo].[TipoMantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_TipoMantenimiento_TipoProveedor] FOREIGN KEY([Id_TipoProveedor])
REFERENCES [dbo].[TipoProveedor] ([Id_TipoProveedor])
GO
ALTER TABLE [dbo].[TipoMantenimiento] CHECK CONSTRAINT [FK_TipoMantenimiento_TipoProveedor]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Idioma_Palabra_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Idioma_Palabra_Idioma]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Idioma_Palabra_Palabra] FOREIGN KEY([ID_Palabra])
REFERENCES [dbo].[Palabra] ([ID_Palabra])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Idioma_Palabra_Palabra]
GO
ALTER TABLE [dbo].[UsuarioPersona]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPersona_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[UsuarioPersona] CHECK CONSTRAINT [FK_UsuarioPersona_Persona]
GO
ALTER TABLE [dbo].[UsuarioPersona]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPersona_Usuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[UsuarioPersona] CHECK CONSTRAINT [FK_UsuarioPersona_Usuario]
GO
USE [master]
GO
ALTER DATABASE [Diploma] SET  READ_WRITE 
GO
