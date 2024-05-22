create database Gerenciamento;
use Gerenciamento;

create table Usuario (
id integer auto_increment unique,
nome varchar(50),
email varchar(50),
senha varchar(50),
generosDeInteresse varchar (100),
primary key (id)
);

create table Login (
id integer auto_increment unique,
email varchar(50),
senha varchar(50),
constraint foreign key (id) references Usuario (id)
);

create table Livros (
id integer auto_increment unique,
idUsuario int,
nome varchar(50),
autor varchar(50),
genero varchar(25),
disponibilidade boolean,
primary key (id),
constraint foreign key (id) references Genero (id)
);

create table Genero (
id integer auto_increment unique,
nome varchar(25)
);

create table LivroGenero(
id integer auto_increment unique,
constraint foreign key (id) references Livros (id),
constraint foreign key (id) references Genero (id)
);

create table Emprestimo (
id integer auto_increment unique,
idLivro int ,
idSolicitação int ,
dataDeSolicitação date,
idUsuario INT ,
statusDaSolicitacao enum('pendente', 'aceito', 'recusado'),
dataDeDevolução date, 
primary key (id)
);

create table Produtos (
id integer auto_increment unique,
nome varchar(50) not null,
valor decimal(6,2) not null
);
