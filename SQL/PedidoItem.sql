CREATE TABLE [dbo].[PedidoItem]
(
	[Id_PedidoItem] INT NOT NULL IDENTITY(1,1),
	[Produto_Id]	INT	NOT NULL,
	[Pedido_Id]		INT	NOT NULL,
	[Quantidade]	DECIMAL(5,2) NOT NULL,
	[ValorTotal]	DECIMAL(10,2) NOT NULL,
	CONSTRAINT	[PK_PedidoItem]				PRIMARY KEY ([Id_PedidoItem]),
	CONSTRAINT	[PK_PedidoItem_Produto]	    FOREIGN KEY ([Produto_Id])	REFERENCES [dbo].[Produto]	([Id_Produto])	ON	DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT	[PK_PedidoItem_Pedido]	    FOREIGN KEY ([Pedido_Id])	REFERENCES [dbo].[Pedido]	([Id_Pedido])	ON	DELETE NO ACTION ON UPDATE NO ACTION,
)
