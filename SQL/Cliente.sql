﻿CREATE TABLE [dbo].[Cliente]
(
	[Id_Cliente] INT NOT NULL IDENTITY(1,1),
	[Nome] VARCHAR(255) NOT NULL,
	[CPF]	VARCHAR(11) NOT NULL,
	CONSTRAINT	[PK_Cliente]				PRIMARY KEY ([Id_Cliente]),
)
