USE [DbElectrika]
GO
/****** Object:  Table [dbo].[Carrito]    Script Date: 24/09/2023 19:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrito](
	[IdCarrito] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [decimal](18, 2) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[SubTotalNeto] [decimal](18, 2) NOT NULL,
	[TipoDescuento] [varchar](2) NULL,
 CONSTRAINT [PK_Carrito] PRIMARY KEY CLUSTERED 
(
	[IdCarrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 24/09/2023 19:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 24/09/2023 19:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nit] [varchar](10) NOT NULL,
	[Nombres] [varchar](100) NOT NULL,
	[Apellidos] [varchar](100) NOT NULL,
	[Direccion] [varchar](300) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Mail] [varchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 24/09/2023 19:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdDetProveedor] [int] NOT NULL,
	[NumeroFactura] [int] NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Configuraciones]    Script Date: 24/09/2023 19:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configuraciones](
	[IdConfiguracion] [int] IDENTITY(1,1) NOT NULL,
	[AlertaStockBajo] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Configuraciones] PRIMARY KEY CLUSTERED 
(
	[IdConfiguracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cotizaciones]    Script Date: 24/09/2023 19:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cotizaciones](
	[IdCotizacion] [int] IDENTITY(1,1) NOT NULL,
	[IdClietne] [int] NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[TotalNeto] [decimal](18, 2) NOT NULL,
	[FehcaCreacion] [date] NOT NULL,
	[FechaExpiracion] [date] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Cotizaciones] PRIMARY KEY CLUSTERED 
(
	[IdCotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Creditos]    Script Date: 24/09/2023 19:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Creditos](
	[idCredito] [int] IDENTITY(1,1) NOT NULL,
	[idVenta] [int] NOT NULL,
	[DeudaInicial] [decimal](18, 2) NOT NULL,
	[Saldo] [decimal](18, 2) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Creditos] PRIMARY KEY CLUSTERED 
(
	[idCredito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditosPagos]    Script Date: 24/09/2023 19:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditosPagos](
	[idPago] [int] IDENTITY(1,1) NOT NULL,
	[idCredito] [int] NOT NULL,
	[Monto] [decimal](18, 2) NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_CreditosPagos] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCompra](
	[IdDetCompra] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [decimal](18, 2) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[IdCompra] [int] NOT NULL,
 CONSTRAINT [PK_DetalleCompra] PRIMARY KEY CLUSTERED 
(
	[IdDetCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCotizacion]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCotizacion](
	[IdDetCotizacion] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [decimal](18, 2) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[SubTotalNeto] [decimal](18, 2) NOT NULL,
	[IdCotizacion] [int] NOT NULL,
 CONSTRAINT [PK_DetalleCotizacion] PRIMARY KEY CLUSTERED 
(
	[IdDetCotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleProforma]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleProforma](
	[IdDetProforma] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [decimal](18, 2) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Descuento] [varchar](50) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[IdProforma] [int] NOT NULL,
 CONSTRAINT [PK_DetalleProforma] PRIMARY KEY CLUSTERED 
(
	[IdDetProforma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleProveedor]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleProveedor](
	[IdDetProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Vendedor] [varchar](200) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Mail] [varchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
	[IdProveedor] [int] NOT NULL,
 CONSTRAINT [PK_DetalleProveedor] PRIMARY KEY CLUSTERED 
(
	[IdDetProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[IdDetVenta] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [decimal](18, 2) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[SubTotalNeto] [decimal](18, 2) NOT NULL,
	[IdVenta] [int] NOT NULL,
 CONSTRAINT [PK_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[IdDetVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Envios]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Envios](
	[IdEnvio] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NOT NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Items] [int] NOT NULL,
	[Recibio] [varchar](100) NOT NULL,
	[FechaEntrega] [date] NOT NULL,
	[FechaCreación] [date] NOT NULL,
 CONSTRAINT [PK_Envios] PRIMARY KEY CLUSTERED 
(
	[IdEnvio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](100) NOT NULL,
	[Producto] [varchar](200) NOT NULL,
	[Marca] [varchar](100) NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[PrecioCompra] [decimal](18, 2) NOT NULL,
	[Ganancia] [decimal](18, 2) NOT NULL,
	[TipoGanancia] [bit] NOT NULL,
	[PrecioVenta] [decimal](18, 2) NOT NULL,
	[Existencia] [decimal](18, 2) NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[UnidadMedida] [varchar](50) NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proformas]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proformas](
	[IdProforma] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Descuento] [varchar](50) NOT NULL,
	[Observaciones] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Proformas] PRIMARY KEY CLUSTERED 
(
	[IdProforma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
	[Proveedor] [varchar](200) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Mail] [varchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[TotalNeto] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Carrito]  WITH CHECK ADD  CONSTRAINT [FK_Carrito_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carrito] CHECK CONSTRAINT [FK_Carrito_Productos]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_DetalleProveedor] FOREIGN KEY([IdDetProveedor])
REFERENCES [dbo].[DetalleProveedor] ([IdDetProveedor])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_DetalleProveedor]
GO
ALTER TABLE [dbo].[Cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_Cotizaciones_Clientes] FOREIGN KEY([IdClietne])
REFERENCES [dbo].[Clientes] ([IdCliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cotizaciones] CHECK CONSTRAINT [FK_Cotizaciones_Clientes]
GO
ALTER TABLE [dbo].[Creditos]  WITH CHECK ADD  CONSTRAINT [FK_Creditos_Ventas] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Ventas] ([IdVenta])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Creditos] CHECK CONSTRAINT [FK_Creditos_Ventas]
GO
ALTER TABLE [dbo].[CreditosPagos]  WITH CHECK ADD  CONSTRAINT [FK_CreditosPagos_Creditos] FOREIGN KEY([idCredito])
REFERENCES [dbo].[Creditos] ([idCredito])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CreditosPagos] CHECK CONSTRAINT [FK_CreditosPagos_Creditos]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompra_Compras] FOREIGN KEY([IdCompra])
REFERENCES [dbo].[Compras] ([IdCompra])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [FK_DetalleCompra_Compras]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompra_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [FK_DetalleCompra_Productos]
GO
ALTER TABLE [dbo].[DetalleCotizacion]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCotizacion_Cotizaciones] FOREIGN KEY([IdCotizacion])
REFERENCES [dbo].[Cotizaciones] ([IdCotizacion])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleCotizacion] CHECK CONSTRAINT [FK_DetalleCotizacion_Cotizaciones]
GO
ALTER TABLE [dbo].[DetalleCotizacion]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCotizacion_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleCotizacion] CHECK CONSTRAINT [FK_DetalleCotizacion_Productos]
GO
ALTER TABLE [dbo].[DetalleProforma]  WITH CHECK ADD  CONSTRAINT [FK_DetalleProforma_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleProforma] CHECK CONSTRAINT [FK_DetalleProforma_Productos]
GO
ALTER TABLE [dbo].[DetalleProforma]  WITH CHECK ADD  CONSTRAINT [FK_DetalleProforma_Proformas] FOREIGN KEY([IdProforma])
REFERENCES [dbo].[Proformas] ([IdProforma])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleProforma] CHECK CONSTRAINT [FK_DetalleProforma_Proformas]
GO
ALTER TABLE [dbo].[DetalleProveedor]  WITH CHECK ADD  CONSTRAINT [FK_DetalleProveedor_Proveedores] FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedores] ([IdProveedor])
GO
ALTER TABLE [dbo].[DetalleProveedor] CHECK CONSTRAINT [FK_DetalleProveedor_Proveedores]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Productos]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Ventas] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Ventas] ([IdVenta])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Ventas]
GO
ALTER TABLE [dbo].[Envios]  WITH CHECK ADD  CONSTRAINT [FK_Envios_Ventas] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Ventas] ([IdVenta])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Envios] CHECK CONSTRAINT [FK_Envios_Ventas]
GO
ALTER TABLE [dbo].[Proformas]  WITH CHECK ADD  CONSTRAINT [FK_Proformas_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Proformas] CHECK CONSTRAINT [FK_Proformas_Clientes]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
/****** Object:  StoredProcedure [dbo].[CobrarVenta]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CobrarVenta]
@IdVenta AS INTEGER
AS
INSERT INTO DetalleVenta
SELECT Cantidad, IdProducto, Precio, SubTotal, Descuento, SubTotalNeto, @IdVenta FROM Carrito
DELETE FROM Carrito
GO
/****** Object:  StoredProcedure [dbo].[ComprovanteVenta]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ComprovanteVenta]
@Id AS INTEGER
AS
SELECT dbo.Clientes.Nit, dbo.Clientes.Nombres, dbo.Clientes.Apellidos, dbo.Clientes.Direccion,
		dbo.Ventas.Total, dbo.Ventas.Fecha, dbo.Ventas.Descuento as [descVenta], dbo.Ventas.TotalNeto, dbo.Ventas.IdVenta,
		dbo.Productos.Codigo, dbo.Productos.Producto, dbo.Productos.Marca, dbo.Productos.UnidadMedida,
		dbo.DetalleVenta.Cantidad, dbo.DetalleVenta.Precio, dbo.DetalleVenta.SubTotal, dbo.DetalleVenta.Descuento, dbo.DetalleVenta.SubTotalNeto
	FROM DetalleVenta INNER JOIN dbo.Productos
	ON dbo.DetalleVenta.IdProducto = dbo.Productos.IdProducto INNER JOIN dbo.Ventas
	ON dbo.DetalleVenta.IdVenta = dbo.Ventas.IdVenta INNER JOIN dbo.Clientes
	ON dbo.Ventas.IdCliente = dbo.Clientes.IdCliente
WHERE dbo.Ventas.IdVenta = @Id
GO
/****** Object:  StoredProcedure [dbo].[Cotizacion]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Cotizacion]
@Id AS INTEGER
AS
SELECT dbo.Clientes.Nit, dbo.Clientes.Nombres, dbo.Clientes.Apellidos, dbo.Clientes.Direccion,
		dbo.Cotizaciones.Total, dbo.Cotizaciones.FehcaCreacion, dbo.Cotizaciones.FechaExpiracion, dbo.Cotizaciones.Descuento as [descCotizacion], dbo.Cotizaciones.TotalNeto, dbo.Cotizaciones.IdCotizacion,
		dbo.Productos.Codigo, dbo.Productos.Producto, dbo.Productos.Marca, dbo.Productos.UnidadMedida,
		dbo.DetalleCotizacion.Cantidad, dbo.DetalleCotizacion.Precio, dbo.DetalleCotizacion.SubTotal, dbo.DetalleCotizacion.Descuento, dbo.DetalleCotizacion.SubTotalNeto
	FROM DetalleCotizacion INNER JOIN dbo.Productos
	ON dbo.DetalleCotizacion.IdProducto = dbo.Productos.IdProducto INNER JOIN dbo.Cotizaciones
	ON dbo.DetalleCotizacion.IdCotizacion = dbo.Cotizaciones.IdCotizacion INNER JOIN dbo.Clientes
	ON dbo.Cotizaciones.IdClietne = dbo.Clientes.IdCliente
WHERE dbo.DetalleCotizacion.IdCotizacion = @Id
GO
/****** Object:  StoredProcedure [dbo].[Cotizacion_caducada]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Cotizacion_caducada]
AS
UPDATE Cotizaciones SET Estado = 0 WHERE DATEDIFF(DAY, GETDATE(), FechaExpiracion) <=0
GO
/****** Object:  StoredProcedure [dbo].[DevolverVenta]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DevolverVenta]
@IdVenta AS INTEGER
AS
UPDATE Productos SET Existencia += dbo.DetalleVenta.Cantidad
FROM dbo.DetalleVenta INNER JOIN dbo.Productos
	ON dbo.DetalleVenta.IdProducto = dbo.Productos.IdProducto
WHERE dbo.DetalleVenta.IdVenta = @IdVenta
DELETE FROM Ventas WHERE IdVenta = @IdVenta
GO
/****** Object:  StoredProcedure [dbo].[Envio]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Envio]
@Id AS INTEGER
AS
SELECT dbo.Envios.Direccion, dbo.Envios.FechaEntrega, dbo.Envios.Recibio, dbo.Envios.Items, dbo.Envios.IdEnvio,
		dbo.Clientes.Nit, dbo.Clientes.Nombres, dbo.Clientes.Apellidos,
		dbo.Ventas.Total, dbo.Ventas.Descuento as [descVenta], dbo.Ventas.TotalNeto, dbo.Ventas.IdVenta,
		dbo.Productos.Codigo, dbo.Productos.Producto, dbo.Productos.Marca, dbo.Productos.UnidadMedida,
		dbo.DetalleVenta.Cantidad, dbo.DetalleVenta.Precio, dbo.DetalleVenta.SubTotal, dbo.DetalleVenta.Descuento, dbo.DetalleVenta.SubTotalNeto
	FROM Envios INNER JOIN dbo.Ventas
	ON dbo.Envios.IdVenta = dbo.Ventas.IdVenta INNER JOIN dbo.DetalleVenta
	ON dbo.DetalleVenta.IdVenta = dbo.Ventas.IdVenta INNER JOIN dbo.Productos
	ON dbo.DetalleVenta.IdProducto = dbo.Productos.IdProducto INNER JOIN dbo.Clientes
	ON dbo.Ventas.IdCliente = dbo.Clientes.IdCliente
WHERE dbo.Ventas.IdVenta = @Id
GO
/****** Object:  StoredProcedure [dbo].[Existencias_bajas]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Existencias_bajas]
@ProductoCodigo as varchar(200),
@Marca as varchar(100),
@Categoria as varchar(200),
@Proveedor as varchar(200)
AS
DECLARE @MinStock AS INTEGER
SELECT @MinStock = AlertaStockBajo FROM Configuraciones
SELECT	dbo.Productos.Codigo, dbo.Productos.Producto, dbo.Productos.Marca, dbo.Productos.Existencia, dbo.Productos.UnidadMedida,
		dbo.Proveedores.Proveedor
FROM dbo.Productos INNER JOIN dbo.Categorias
ON dbo.Productos.IdCategoria = dbo.Categorias.IdCategoria
INNER JOIN dbo.Proveedores 
ON dbo.Productos.IdProveedor = dbo.Proveedores.IdProveedor
WHERE	dbo.Productos.Existencia <= @MinStock And (dbo.Productos.Codigo like '%' + @ProductoCodigo + '%' Or dbo.Productos.Producto like '%' + @ProductoCodigo + '%') And dbo.Productos.Marca like '%' + @Marca + '%' And
		dbo.Categorias.Categoria like @Categoria + '%' And dbo.Proveedores.Proveedor like @Proveedor + '%'
GO
/****** Object:  StoredProcedure [dbo].[Inventario]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Inventario]
AS
SELECT	dbo.Productos.Codigo, dbo.Productos.Producto + ' ' + dbo.Productos.Marca + ' (' + dbo.Productos.UnidadMedida + ')' AS [Producto], dbo.Productos.Existencia,
		dbo.Proveedores.Proveedor, dbo.Productos.PrecioCompra, dbo.Productos.PrecioVenta, dbo.Proveedores.IdProveedor
FROM dbo.Productos INNER JOIN dbo.Proveedores 
ON dbo.Productos.IdProveedor = dbo.Proveedores.IdProveedor
GO
/****** Object:  StoredProcedure [dbo].[LimpiarCarrito]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LimpiarCarrito]
AS
UPDATE Productos SET Existencia += dbo.Carrito.Cantidad
FROM dbo.Productos INNER JOIN dbo.Carrito
ON dbo.Carrito.IdProducto = dbo.Productos.IdProducto
DELETE FROM Carrito
GO
/****** Object:  StoredProcedure [dbo].[VoucherCredito]    Script Date: 24/09/2023 19:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VoucherCredito]
@Id AS INTEGER
AS
SELECT dbo.Creditos.idCredito, dbo.Creditos.DeudaInicial, dbo.Creditos.Fecha AS [FechaCreacion], dbo.Creditos.idVenta, dbo.Creditos.Estado,
	dbo.CreditosPagos.Monto, dbo.CreditosPagos.Fecha AS [FechaPago],
	dbo.Clientes.Nit, dbo.Clientes.Nombres + ' ' + dbo.Clientes.Apellidos AS [Cliente]
	FROM CreditosPagos RIGHT JOIN dbo.Creditos
	ON dbo.CreditosPagos.idCredito = dbo.Creditos.idCredito INNER JOIN dbo.Ventas
	ON dbo.Creditos.idVenta = dbo.Ventas.IdVenta INNER JOIN dbo.Clientes
	ON dbo.Ventas.IdCliente = dbo.Clientes.IdCliente
WHERE dbo.Creditos.idVenta = @Id
GO
