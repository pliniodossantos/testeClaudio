# testeClaudio
 Teste C#
DB: testeClaudio


create table clientes(
id_cliente int AUTO_INCREMENT primary key,
cliente varchar(100) not null,
cpf varchar(11),
uf varchar(2));


create table conteiner(
id_conteiner int AUTO_INCREMENT primary key,
codigoConteiner varchar(11),
tipo varchar(2),
estado varchar(5),
categoria varchar(10),
id_cliente int not null,
FOREIGN KEY (id_cliente) references clientes(id_cliente)
);


create table movimentacao(
id int AUTO_INCREMENT primary key,
tipoMovimentacao varchar(16),
dataInicio DATETIME,
dataFim DATETIME,
idConteiner int not null,
idCliente int not null,
FOREIGN KEY (idConteiner) references conteiner(id_conteiner),
FOREIGN KEY (idCliente) references clientes(id_cliente)
);