Use GlicNow

create table tblEstado (
Id int identity primary key,
Estado varchar (2)
)

create table tblCidade (
Id int identity primary key,
Cidade varchar(100),
EstadoId int foreign key (EstadoId) references tblEstado
)

create table tblTipoDiabete (
Id int identity primary key,
Descricao varchar(50)
) 

create table tblSexo(
Id int identity primary key,
Descricao varchar (50)
)

create table tblUsuario (
Id int identity primary key,
NomeCompleto varchar (100),
CPF varchar (11),
DataNascimento date,
Email varchar (100),
Celular varchar (11),
FotoPerfil image,
TipoDiabeteId int foreign key (TipoDiabeteId) references tblTipoDiabete,
SexoId int foreign key (SexoId) references tblSexo,
)

create table tblLogin (
Id int identity primary key,
Login varchar (50),
Password varchar (100),
Salvo bit,
UsuarioId int foreign key (UsuarioId) references tblUsuario
)

create table tblEndereco (
Id int identity primary key,
Endereco varchar (100),
Numero varchar (5),
Complemento varchar (50),
Bairro varchar(50),
CEP varchar(9),
CidadeId int foreign key (CidadeId) references tblCidade,
UsuarioId int foreign key (UsuarioId) references tblUsuario
)

create table tblGlicemia (
Id int identity primary key,
Data date,
PreCafe varchar (3),
PosCafe varchar (3),
PreAlmoco varchar (3),
PosAlmoco varchar (3),
PreJantar varchar (3),
PosJantar varchar (3),
BasalMatutino bit,
BasalNoturno bit,
Observacao varchar (1000),
UsuarioId int foreign key (UsuarioId) references tblUsuario
)

create table tblAgenda (
Id int identity primary key,
DataHora datetime,
Titulo varchar(150),
NomeMedico varchar (100),
Observacao varchar (1000),
Ativado bit,
UsuarioId int foreign key (UsuarioId) references tblUsuario
)