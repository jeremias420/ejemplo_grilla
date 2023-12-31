USE [lista_img]
GO
/****** Object:  Table [dbo].[juegos]    Script Date: 28/11/2023 11:37:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[juegos](
	[jueg_id] [int] NULL,
	[jueg_titulo] [varchar](255) NULL,
	[jueg_img_path] [varchar](255) NULL,
	[jueg_check] [bit] NULL,
	[jueg_capacidad] [float] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[juegos] ([jueg_id], [jueg_titulo], [jueg_img_path], [jueg_check], [jueg_capacidad]) VALUES (1, N'Mario', N'img\mario.jpeg', 0, 10.5)
INSERT [dbo].[juegos] ([jueg_id], [jueg_titulo], [jueg_img_path], [jueg_check], [jueg_capacidad]) VALUES (2, N'Final fantasy', N'img\finalfantasy.jpeg', 0, 15.2)
INSERT [dbo].[juegos] ([jueg_id], [jueg_titulo], [jueg_img_path], [jueg_check], [jueg_capacidad]) VALUES (3, N'Metal Slug', N'img\metalslug.jpeg', 0, 8.7)
INSERT [dbo].[juegos] ([jueg_id], [jueg_titulo], [jueg_img_path], [jueg_check], [jueg_capacidad]) VALUES (4, N'Lufia 2', N'img\lufia.jpeg', 0, 12.3)
INSERT [dbo].[juegos] ([jueg_id], [jueg_titulo], [jueg_img_path], [jueg_check], [jueg_capacidad]) VALUES (5, N'Pokemon Rojo Fuego', N'img\pokemon.jpeg', 0, 14)
GO
