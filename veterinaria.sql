USE [Veterinaria]
GO
/****** Object:  Table [dbo].[Calendario_Vacunas]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Calendario_Vacunas](
	[nro_historia_clinica] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_vacuna] [int] NOT NULL,
	[fecha_prevista] [date] NOT NULL,
	[fecha_real] [date] NOT NULL,
	[laboratorio] [int] NOT NULL,
	[dosis] [float] NULL,
	[tipo_doc_empl] [varchar](10) NOT NULL,
	[nro_doc_empl] [int] NOT NULL,
 CONSTRAINT [PK_Calendario_Vacunas] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC,
	[id_vacuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Consultas]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Consultas](
	[nro_historia_clinica] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_consulta] [int] NOT NULL,
	[tipo_documento_empl] [varchar](10) NOT NULL,
	[nro_documento_empl] [int] NOT NULL,
	[fecha_entrada] [date] NOT NULL,
	[fecha_salida] [date] NOT NULL,
 CONSTRAINT [PK_Consultas] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC,
	[id_consulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diagnosticos]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diagnosticos](
	[id_diagnostico] [int] NOT NULL,
	[descripcion] [varchar](200) NULL,
 CONSTRAINT [PK_Diagnosticos] PRIMARY KEY CLUSTERED 
(
	[id_diagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DiagnosticoxConsulta]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiagnosticoxConsulta](
	[nro_historia_clinica] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_consulta] [int] NOT NULL,
	[id_diagnostico] [int] NOT NULL,
 CONSTRAINT [PK_DiagnosticoxConsulta] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC,
	[id_consulta] ASC,
	[id_diagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dueños]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dueños](
	[id_dueño] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[telefono] [int] NULL,
 CONSTRAINT [PK_Dueños] PRIMARY KEY CLUSTERED 
(
	[id_dueño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[tipo_doc] [varchar](10) NOT NULL,
	[nro_doc] [int] NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[matricula] [varchar](50) NULL,
	[sucursal] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[tipo_doc] ASC,
	[nro_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Laboratorios]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Laboratorios](
	[id_laboratorio] [int] NOT NULL,
	[razon_social] [varchar](100) NULL,
	[direccion] [varchar](100) NULL,
 CONSTRAINT [PK_Laboratorios] PRIMARY KEY CLUSTERED 
(
	[id_laboratorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Medicamentos]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medicamentos](
	[id_medicamento] [int] NOT NULL,
	[descripcion] [varchar](200) NULL,
	[id_laboratorio] [int] NOT NULL,
	[fecha_ultima_compra] [datetime] NOT NULL,
 CONSTRAINT [PK_Medicamentos] PRIMARY KEY CLUSTERED 
(
	[id_medicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedicamentoxConsulta]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MedicamentoxConsulta](
	[nro_historia_clinica] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_consulta] [int] NOT NULL,
	[id_medicamento] [int] NOT NULL,
	[dosis] [float] NULL,
	[periodicidad] [varchar](20) NULL,
 CONSTRAINT [PK_MedicamentoxConsulta] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC,
	[id_consulta] ASC,
	[id_medicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedicamentoxSucursal]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicamentoxSucursal](
	[id_medicamento] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[cantidad_existente] [int] NULL,
	[cantidad_minima] [int] NULL,
 CONSTRAINT [PK_MedicamentoxSucursal] PRIMARY KEY CLUSTERED 
(
	[id_medicamento] ASC,
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Perros]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perros](
	[nro_historia_clinica] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[nombre] [varchar](100) NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[id_raza] [int] NOT NULL,
	[peso] [float] NULL,
	[altura] [float] NULL,
	[id_dueño] [int] NOT NULL,
 CONSTRAINT [PK_Perros] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Razas]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Razas](
	[denominacion] [nvarchar](50) NULL,
	[peso_minimo_hembra] [float] NULL,
	[peso_minimo_macho] [float] NULL,
	[altura_media_hembra] [float] NULL,
	[altura_media_macho] [float] NULL,
	[nota_cuidados] [varchar](200) NULL,
	[id_raza] [int] NOT NULL,
 CONSTRAINT [PK_Razas] PRIMARY KEY CLUSTERED 
(
	[id_raza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sintomas]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sintomas](
	[id_sintoma] [int] NOT NULL,
	[descripcion] [varchar](200) NULL,
 CONSTRAINT [PK_Sintomas] PRIMARY KEY CLUSTERED 
(
	[id_sintoma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SintomaxConsulta]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SintomaxConsulta](
	[nro_historia_clinica] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_consulta] [int] NOT NULL,
	[id_sintoma] [int] NOT NULL,
 CONSTRAINT [PK_SintomaxConsulta] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC,
	[id_consulta] ASC,
	[id_sintoma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sucursales]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sucursales](
	[id_sucursal] [int] NOT NULL,
	[nombre] [varchar](100) NULL,
	[tipo_doc_superv] [varchar](10) NOT NULL,
	[nro_doc_superv] [int] NOT NULL,
	[tipo_doc_superv_supl] [varchar](10) NOT NULL,
	[nro_doc_superv_supl] [int] NOT NULL,
 CONSTRAINT [PK_Sucursales] PRIMARY KEY CLUSTERED 
(
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] NOT NULL,
	[n_usuario] [varchar](1) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vacunas]    Script Date: 04/09/2016 20:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vacunas](
	[id_vacuna] [int] NOT NULL,
	[descripcion] [varchar](200) NULL,
 CONSTRAINT [PK_Vacunas] PRIMARY KEY CLUSTERED 
(
	[id_vacuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([sucursal])
REFERENCES [dbo].[Sucursales] ([id_sucursal])
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([sucursal])
REFERENCES [dbo].[Sucursales] ([id_sucursal])
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([sucursal])
REFERENCES [dbo].[Sucursales] ([id_sucursal])
GO
ALTER TABLE [dbo].[Sucursales]  WITH CHECK ADD FOREIGN KEY([tipo_doc_superv], [nro_doc_superv])
REFERENCES [dbo].[Empleados] ([tipo_doc], [nro_doc])
GO
ALTER TABLE [dbo].[Sucursales]  WITH CHECK ADD FOREIGN KEY([tipo_doc_superv_supl], [nro_doc_superv_supl])
REFERENCES [dbo].[Empleados] ([tipo_doc], [nro_doc])
GO
ALTER TABLE [dbo].[Sucursales]  WITH CHECK ADD FOREIGN KEY([tipo_doc_superv], [nro_doc_superv])
REFERENCES [dbo].[Empleados] ([tipo_doc], [nro_doc])
GO
ALTER TABLE [dbo].[Sucursales]  WITH CHECK ADD FOREIGN KEY([tipo_doc_superv_supl], [nro_doc_superv_supl])
REFERENCES [dbo].[Empleados] ([tipo_doc], [nro_doc])
GO
Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_login.ShowDialog()
    End Sub
    
    Private Sub NuevoEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cargaEmpleado.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cargaEmpleado.limpiar_componentes(frm_editarEmpleado.gro_datosEmpleadoEditar)
        frm_editarEmpleado.ShowDialog()
    End Sub

    Private Sub NuevoLToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cargaLaboratorio.ShowDialog()
    End Sub

    Private Sub EditarLaboratorioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cargaEmpleado.limpiar_componentes(frm_editarLaboratorio.gro_datosLaboratorioEditar)
        frm_editarLaboratorio.ShowDialog()
    End Sub


    Private Sub DueñosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cargaMedicamento.ShowDialog()
    End Sub

    Private Sub EditarMedicamentoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cargaEmpleado.limpiar_componentes(frm_editarMedicamento.gro_datosMedicamentosEditar)
        frm_editarMedicamento.ShowDialog()
    End Sub

    Private Sub NuevoDueñoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cargaDueño.ShowDialog()

    End Sub

    Private Sub EditarDueñoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_editarDueño.ShowDialog()

    End Sub

    Private Sub NuevoPerroToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cargaPerro.ShowDialog()

    End Sub

    
    Private Sub EditarPerroToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_editarPerro.ShowDialog()

    End Sub

    Private Sub btn_atencionConsultas_Click(sender As Object, e As EventArgs)
        frm_Atencion.ShowDialog()

    End Sub

    Private Sub btn_atencionConsulta_Click(sender As Object, e As EventArgs) Handles btn_atencionConsulta.Click
        frm_Atencion.ShowDialog()

    End Sub

    Private Sub NuevoDiagnosticoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cargaDiagnostico.ShowDialog()

    End Sub

    Private Sub EditarDiagnosticoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_editarDiagnostico.ShowDialog()
    End Sub

    Private Sub PerrosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
