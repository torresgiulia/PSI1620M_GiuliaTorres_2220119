use PSI20M_GiuliaTorres_2220119
-------------------------------------------------------------------------------------------------

-- ************************************** [Categorias]
CREATE TABLE [Categorias]
(
 [id]   int NOT NULL ,
 [nome] varchar(200) NOT NULL ,


 CONSTRAINT [PK_categorias] PRIMARY KEY CLUSTERED ([id] ASC)
);

-- ************************************** [Concelhos]
CREATE TABLE [Concelhos]
(
 [id]   int NOT NULL ,
 [nome] varchar(200) NOT NULL ,


 CONSTRAINT [PK_concelhos] PRIMARY KEY CLUSTERED ([id] ASC)
);

-- ************************************** [Vendedores]
CREATE TABLE [Vendedores]
(
 [id]          int NOT NULL ,
 [nome]        varchar(200) NOT NULL ,
 [id_concelho] int NOT NULL ,


 CONSTRAINT [PK_vendedores] PRIMARY KEY CLUSTERED ([id] ASC),
 CONSTRAINT [FK_vendedor_concelhos] FOREIGN KEY ([id_concelho])  REFERENCES [Concelhos]([id])
);




-- ************************************** [Produtos]
CREATE TABLE [Produtos]
(
 [id]          int NOT NULL ,
 [nome]        varchar(200) NOT NULL ,
 [id_vendedor] int NOT NULL ,


 CONSTRAINT [PK_produtos] PRIMARY KEY CLUSTERED ([id] ASC),
 CONSTRAINT [FK_produtos_vendedores] FOREIGN KEY ([id_vendedor])  REFERENCES [Vendedores]([id])
);





-- ************************************** [produtosCategorias]
CREATE TABLE [produtosCategorias]
(
 [id_pc]        int NOT NULL ,
 [id_categoria] int NOT NULL ,
 [id_produto]   int NOT NULL ,


 CONSTRAINT [PK_produtosCategorias] PRIMARY KEY CLUSTERED ([id_pc] ASC),
 CONSTRAINT [FK_produtosCategorias_categorias] FOREIGN KEY ([id_categoria])  REFERENCES [Categorias]([id]),
 CONSTRAINT [FK_produtosCategorias_produtos] FOREIGN KEY ([id_produto])  REFERENCES [Produtos]([id])
);

 GO






 -- ************************************** [Utilizadores]
CREATE TABLE [Utilizadores]
(
 [id]		   int IDENTITY  NOT NULL,
 [username]    varchar(50) NOT NULL ,
 [nome]        varchar(200) NOT NULL ,
 [id_concelho] int NOT NULL ,
 [telemovel]   int NULL ,
 [password]    varchar(20) NOT NULL ,
 [email]       varchar(200) NULL ,

 CONSTRAINT [PK_utilizadores] PRIMARY KEY CLUSTERED ([id]),
 CONSTRAINT [FK_utilizador_concelhos] FOREIGN KEY ([id_concelho])  REFERENCES [Concelhos]([id])
);











  -- ************************************** [utilizadoresCategorias]
CREATE TABLE [utilizadoresCategorias]
(
 [id_uc]			int IDENTITY NOT NULL ,
 [id_utilizador]    int NOT NULL ,
 [id_categoria]		int NOT NULL ,


 CONSTRAINT [PK_utilizadoresCategorias] PRIMARY KEY CLUSTERED ([id_uc] ASC),
 CONSTRAINT [FK_utilizadoresCategoria_utilizadores] FOREIGN KEY ([id_utilizador])  REFERENCES [Utilizadores]([id]),
 CONSTRAINT [FK_utilizadoresCategorias_categorias] FOREIGN KEY ([id_categoria])  REFERENCES [Categorias]([id])
);



 -- ************************************** [utilizadoresGrupos]
CREATE TABLE [utilizadoresGrupos]
(
 [id_ug]                       int IDENTITY NOT NULL ,
 [id_grupo]                    int NOT NULL ,
 [id_utilizador]			   int NOT NULL ,
 [id_utilizadorSorteado]	   int NULL ,


 CONSTRAINT [PK_utilizadoresGrupos] PRIMARY KEY CLUSTERED ([id_ug] ASC),
 CONSTRAINT [FK_utilizadoresGrupos_Grupos] FOREIGN KEY ([id_grupo])  REFERENCES [Grupos]([id]),
 CONSTRAINT [FK_utilizadoresGrupos_utilizadores] FOREIGN KEY ([id_utilizador])  REFERENCES [Utilizadores]([id]),
 CONSTRAINT [FK_utilizadoresGrupos_utilizadores_sorteado] FOREIGN KEY ([id_utilizadorSorteado])  REFERENCES [Utilizadores]([id])
);




-- ************************************** [Grupos]
CREATE TABLE [Grupos]
(
 [id]                        int IDENTITY NOT NULL ,
 [nome]                      varchar(200) NOT NULL ,
 [estado]                    varchar(50) NOT NULL ,
 [id_utilizador_lider]		 int NOT NULL ,
 [descricao]				 varchar(200) NULL,


 CONSTRAINT [PK_grupos] PRIMARY KEY CLUSTERED ([id] ASC),
 CONSTRAINT [FK_grupos_utilizadores_lider] FOREIGN KEY ([id_utilizador_lider])  REFERENCES [Utilizadores]([id])
);




