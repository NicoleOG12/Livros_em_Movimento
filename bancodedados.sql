create database Gerenciamento;
use Gerenciamento;

create table Usuario (
id int auto_increment unique not null,
nome varchar(50) not null,
email varchar(50) not null,
senha varchar(50) not null,
generosDeInteresse varchar (100) not null,
primary key (id)
);

create table Login (
id int auto_increment unique not null,
idUsuario int not null,
email varchar(50) not null,
senha varchar(50) not null,
primary key (id),
constraint foreign key (idUsuario) references Usuario (id)
);

create table Livros (
id int auto_increment unique not null,
idUsuario int not null,
nome varchar(50) not null,
autor varchar(50) not null,
genero varchar(25) not null,
disponibilidade boolean not null,
primary key (id),
constraint foreign key (idUsuario) references Usuario (id),
constraint foreign key (id) references Genero (id)
);

create table Genero (
id int auto_increment unique not null,
nome varchar(25) not null
);

create table LivroGenero(
id int auto_increment unique,
idLivros int not null,
idGenero int not null,
constraint foreign key (idLivros) references Livros (id),
constraint foreign key (idGenero) references Genero (id)
);

create table Solicitacao (
id int auto_increment unique not null,
idUsuario int not null,
idLivro int not null,
dataDeSolicitacao date not null,
statusDaSolicitacao enum('pendente', 'aceito', 'recusado') not null,
dataDeDevolucao date not null, 
primary key (id),
constraint foreign key (idUsuario) references Usuario (id),
constraint foreign key (idLivro) references Livro (id)
);

---------------------------------------------------------------------------------
create table Produtos (
id int auto_increment unique not null,
nome varchar(250) not null,
descrição text not null,
valor decimal(10,2) not null,
estoque int not null,
primary key (id)
);

create table Pedido (
id int auto_increment unique not null,
idUsuario int not null,
idProduto int not null,
dataPedido date not null,
statusPedido enum('pendente', 'processando', 'entregue') not null,
primary key (id),
constraint foreign key (idUsuario) references Usuario (id),
constraint foreign key (idProduto) references Produto (id)
);
