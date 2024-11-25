create database PIM_IV

use PIM_IV

create table clientes
(
    id_cliente   int identity
        constraint clientes_fisicos_pk
            primary key,
    nome         nvarchar(100) not null,
    tipo         nvarchar(8)   not null,
    documento    varchar(18)   not null,
    email        nvarchar(150) not null,
    telefone     varchar(15)   not null,
    endereco     nvarchar(150) not null,
    data_inicial date          not null
)

create table compras
(
    id_compra           int identity
        constraint compras_pk
            primary key,
    id_fornecedor       int            not null
        constraint compras_fornecedores_id_fornecedor_fk
            references fornecedores,
    nome_fornecedor     nvarchar(150)  not null,
    data_compra         date           not null,
    id_insumo           int            not null
        constraint compras_insumos_id_insumo_fk
            references insumos,
    nome_insumo         nvarchar(150)  not null,
    quantidade_comprada int            not null,
    valor_unitario      decimal(10, 2) not null,
    valor_total         decimal(10, 2) not null
)

create table culturas
(
    id_cultura          int identity
        constraint culturas_pk
            primary key,
    nome                nvarchar(100) not null,
    data_plantio        date          not null,
    data_colheita       date          not null,
    area_plantada       decimal       not null,
    quantidade_plantada int           not null,
    tipo_solo           nvarchar(50)  not null,
    tipo_irrigacao      nvarchar(100) not null,
    notas               nvarchar(max) not null
)

create table fornecedores
(
    id_fornecedor int identity
        constraint fornecedores_fisicos_pk
            primary key,
    nome          nvarchar(255) not null,
    telefone      varchar(15)   not null,
    email         nvarchar(255) not null,
    documento     varchar(18)   not null,
    endereco      nvarchar(150) not null,
    data_inicial  date          not null,
    tipo          nvarchar(8)   not null
)

create table funcionarios
(
    id_funcionario int identity
        constraint funcionarios_pk
            primary key
        constraint funcionarios_pk
            primary key,
    nome_completo  nvarchar(150)  not null,
    rg             varchar(9)     not null,
    cpf            varchar(11)    not null,
    cargo          nvarchar(75)   not null,
    email          nvarchar(75)   not null,
    telefone       varchar(11)    not null,
    salario        decimal(10, 2) not null,
    data_admissao  date           not null,
    endereco       nvarchar(150)  not null
)

create table insumos
(
    id_insumo          int identity
        constraint insumos_pk
            primary key,
    nome               nvarchar(100) not null,
    descricao          nvarchar(150) not null,
    quantidade_estoque int           not null,
    data_compra        date          not null,
    data_validade      date          not null,
    id_fornecedor      int           not null
        constraint insumos_fornecedores_id_fornecedor_fk
            references fornecedores,
    nome_fornecedor    nvarchar(150) not null
)

create table produtos
(
    Id_Produto         int identity
        constraint produtos_pk
            primary key,
    Nome               nvarchar(100)  not null,
    Descricao          nvarchar(150)  not null,
    Quantidade_Estoque int            not null,
    Preco_Unitario     decimal(10, 2) not null,
    Data_Validade      date           not null
)

create table usuarios
(
    id_usuario int identity
        constraint usuarios_pk
            primary key,
    login      nvarchar(50)  not null,
    senha      nvarchar(50)  not null,
    cargo      nvarchar(100) not null
)

create table vendas
(
    id_venda           int identity
        constraint vendas_pk
            primary key,
    id_cliente         int            not null,
    nome_cliente       nvarchar(150)  not null,
    id_produto         int            not null
        constraint vendas_produtos_Id_Produto_fk
            references produtos,
    nome_produto       nvarchar(150)  not null,
    descricao_produto  nvarchar(150)  not null,
    data_venda         date           not null,
    valor_unitario     decimal(10, 2) not null,
    quantidade_vendida int            not null,
    valor_total        decimal(10, 2) not null
)

INSERT INTO compras (id_fornecedor, nome_fornecedor, data_compra, id_insumo, nome_insumo, quantidade_comprada, valor_unitario, valor_total)
VALUES (1, N'Cresce Forte Insumos Agrícolas', '2024-04-05', 1, N'Nutriente Hidropônico 2l', 10, 149.90, 1499.00);

INSERT INTO compras (id_fornecedor, nome_fornecedor, data_compra, id_insumo, nome_insumo, quantidade_comprada, valor_unitario, valor_total)
VALUES (2, N'Dedo Verde Insumos', '2024-03-05', 2, N'Sementes de Tomate Cereja', 2500, 0.80, 2000.00);

INSERT INTO vendas (id_cliente, nome_cliente, id_produto, nome_produto, descricao_produto, data_venda, valor_unitario, quantidade_vendida, valor_total)
VALUES (1, N'Hortifruti São João', 1, N'Alface Crespa Hidropônica', N'Maço de Alface', '2024-05-15', 6.30, 300, 1890.00);

INSERT INTO vendas (id_cliente, nome_cliente, id_produto, nome_produto, descricao_produto, data_venda, valor_unitario, quantidade_vendida, valor_total)
VALUES (2, N'Restaurante Sabor Mineiro', 2, N'Tomate Cereja Orgânico', N'Bandeja de 250g', '2024-05-16', 8.00, 200, 1600.00);

INSERT INTO produtos (Nome, Descricao, Quantidade_Estoque, Preco_Unitario, Data_Validade)
VALUES (N'Alface Crespa Hidropônica', N'Maço de alface', 800, 6.30, '2024-05-25');

INSERT INTO produtos (Nome, Descricao, Quantidade_Estoque, Preco_Unitario, Data_Validade)
VALUES (N'Tomate Cereja Orgânico', N'Bandeja de 250g', 2700, 8.00, '2024-06-25');

INSERT INTO culturas (nome, data_plantio, data_colheita, area_plantada, quantidade_plantada, tipo_solo, tipo_irrigacao, notas)
VALUES (N'Alface Crespa', '2024-05-01', '2024-05-30', 100, 1000, N'N/A (Hidroponia)', N'Sistema de Nutrição Hidropônica', N'Cultivo em sistema hidropônico em torre vertical');

INSERT INTO culturas (nome, data_plantio, data_colheita, area_plantada, quantidade_plantada, tipo_solo, tipo_irrigacao, notas)
VALUES (N'Tomate Cereja', '2024-05-01', '2024-06-30', 150, 3000, N'Arenoso', N'Microaspersão', N'Cultivo em estufa');

INSERT INTO insumos (nome, descricao, quantidade_estoque, data_compra, data_validade, id_fornecedor, nome_fornecedor)
VALUES (N'Nutriente Hidrônico', N'Fertilizante líquido para cultivo hidropônico, medido em litros', 50, '2024-05-05', '2025-05-05', 1, N'Cresce Forte Insumos Agrícolas');

INSERT INTO insumos (nome, descricao, quantidade_estoque, data_compra, data_validade, id_fornecedor, nome_fornecedor)
VALUES (N'Substrato para Germinação', N'Substrato orgânico para germinação de sementes, medido em kg', 100, '2024-05-10', '2025-05-10', 2, N'Dedo Verde Insumos');

INSERT INTO funcionarios (nome_completo, rg, cpf, cargo, email, telefone, salario, data_admissao, endereco)
VALUES (N'Roberta dos Santos', '12.345.678-9', '234.567.890-12', N'Gerente de Produção', N'roberta.santos@exemplo.com', '(11) 11234-1234', 4700.00, '2022-04-12', N'Rua E, 356, Apto 2, Centro, São Paulo, SP, 12345-876');

INSERT INTO funcionarios (nome_completo, rg, cpf, cargo, email, telefone, salario, data_admissao, endereco)
VALUES (N'Ana Oliveira', '22.345.678-1', '294.567.890-42', N'Operador de Estufa', N'ana.oliveira@exemplo.com', '(11) 8234-1239', 3950.00, '2023-02-01', N'Rua F, 285, n/a, Centro, São Paulo, SP, 12345-576');

INSERT INTO clientes (nome, tipo, documento, email, telefone, endereco, data_inicial)
VALUES (N'Hortifruti São João', N'Jurídico', '345.678.900/0001-00', N'pedro.ribeiro@hortifruti.exemplo.com', N'(11) 1234-9876', N'Rua C, 789, n/a, Centro, São Paulo, SP, 12345-2468', '2012-04-05');

INSERT INTO clientes (nome, tipo, documento, email, telefone, endereco, data_inicial)
VALUES (N'Restaurante Sabor Mineiro', N'Jurídico', '678.912.345/0001-00', N'laura.barros@sabormineiro.exemplo.com', N'(11) 1234-1432', N'Rua D, 012, n/a, Centro, São Paulo, SP, 12345-1357', '2010-08-24');

INSERT INTO usuarios (login, senha, cargo)
VALUES (N'RSantos', N'r@12345', N'Gerente de Produção');

INSERT INTO usuarios (login, senha, cargo)
VALUES (N'AOliveira', N'a@12345', N'Operador de Estufa');

go