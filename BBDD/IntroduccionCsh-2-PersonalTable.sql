USE [TimeMachineDB]
GO

/****** Object:  Table [dbo].[Personal]    Script Date: 05/10/2022 1:27:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personal](
	[id_persona] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](max) NULL,
	[identificacion] [varchar](max) NULL,
	[pais] [varchar](max) NULL,
	[id_cargo] [int] NULL,
	[sueldoPorHora] [numeric](18, 0) NULL,
	[estado] [varchar](max) NULL,
	[codigo] [varchar](max) NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Personal]  WITH CHECK ADD CONSTRAINT [FK_Personal_Cargo] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[Cargo] ([id_cargo])
GO

ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [FK_Personal_Cargo]
GO


