drop database gerenciamento;
create database Gerenciamento;
use Gerenciamento;

create table Usuarios (
id int auto_increment unique not null,
nome varchar(50) not null,
cpf int,
celular int,
email varchar(50) not null,
senha varchar(50) not null,
imagem longblob,
primary key (id)
);

create table Administradores (
id int auto_increment unique not null,
nome varchar(50) not null,
email varchar(50) not null,
senha varchar(50) not null,
primary key (id)
);

create table Livros (
id int auto_increment unique not null,
nome varchar(50) not null,
autor varchar(50) not null,
sinopse text,
estoque int not null,
imagem longblob not null,
primary key (id)
);


create table Emprestimo (
id int auto_increment unique not null,
idUsuario int not null,
idLivro int not null,
dataDeSolicitacao date not null,
statusDaSolicitacao enum('pendente', 'aceito', 'recusado') not null,
dataDeDevolucao date not null, 
primary key (id),
constraint foreign key (idUsuario) references Usuarios (id),
constraint foreign key (idLivro) references Livros (id)
);

create table Troca(
id int auto_increment unique not null,
idUsuario int not null,
idLivro int not null,
nomeDoLivrodeTroca varchar(100),
imagem longblob not null,
dataDeSolicitacao date not null,
primary key (id),
constraint foreign key (idUsuario) references Usuarios (id),
constraint foreign key (idLivro) references Livros (id)
);

create table Produtos (
id int auto_increment unique not null,
nome varchar(250) not null,
autor varchar(50),
sinopse text,
estoque int not null,
preço decimal(10,2) not null,
imagem longblob not null,
primary key (id)
);

create table Pedidos (
id int auto_increment unique not null,
idUsuario int not null,
idProduto int not null,
quantidade int not null,
valor int not null,
formaPagamento varchar(20) not null,
dataPedido datetime not null,
constraint foreign key (idUsuario) references Usuarios (id),
constraint foreign key (idProduto) references Produtos (id)
);

create table Produtos_Pedidos(
id int auto_increment not null,
idPedido int not null,
idProduto int not null,
quantidade int not null,
valorTotal int not null,
primary key (id),
constraint foreign key (idPedido) references Pedidos (id),
constraint foreign key (idProduto) references Produtos (id)
);

create table Carrinho (
id int auto_increment unique not null,
idUsuario int not null,
idProduto int not null,
quantidade int not null,
valor int not null,
primary key (id),
constraint foreign key (idUsuario) references Usuarios (id),
constraint foreign key (idProduto) references Produtos (id)
); 




insert into Administradores values
(1, "Nicole", "nicole@gmail.com", "123456");

select * from usuarios;
select * from Produtos;
select * from Livros;

