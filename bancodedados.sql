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
genero varchar(25) not null,
sinopse text,
estoque int not null,
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

---------------------------------------------------------------------------------
create table Produtos (
id int auto_increment unique not null,
nome varchar(250) not null,
estoque int not null,
preço decimal(10,2) not null,
primary key (id)
);

create table Pedidos (
id int auto_increment unique not null,
idUsuario int not null,
idProduto int not null,
quantidade int not null,
valor int not null,
formaPagamento varchar(20) not null,
dataPedido date not null,
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



insert into Usuarios values
(1, "Maria Flor", "mariazinha@gmail.com", "maria123"),
(2, "Chico Souza", "chiquinho@gmail.com", "chico123"),
(3, "Paulo Gomes", "paulo@gmail.com", "paulo123"),
(4, "Manuela Ferreira", "manu@gmail.com", "manu123"),
(5, "Larissa Lopes", "laris@gmail.com", "lari123");

insert into Livros values
(1, "Para além do diário", "Anne Frank", "Diário", "", 2),
(2, "A mente de Adolf Hitler", "Walter C.", "História", "", 3),
(3, "Assassinato na casa do pastor", "Agatha Christie", "Ficção", "", 1),
(4, "E não sobrou nenhum", "Agatha Christie", "Investigação", "", 1),
(5, "O homem de giz", "C.J Tudor", "Mistério", "", 4),
(6, "Pessoas normais", "Sally Rooney", "Romance", "", 2),
(7, "A vida invisível de Addie Larue", "V.E. Schawab", "Literatura", "", 1),
(8, "Um de nós está mentindo", "Karen M.", "Ficção", "", 2);

insert into Produtos values
(1, "Memórias póstumas de Brás Cubas", "29.99", 15),
(2, "Mais que amigos?", "50.91", 6),
(3, "A hipótese do amor", "44.90", 8),
(4, "É assim que começa", "73.63", 20),
(5, "Além da fumaça", "41.38", 10),
(6, "Bridgerton (O duque e eu)", "48.52", 16),
(7, "A Garota do Lago", "21.80", 12),
(8, "Como eu era antes de você", "44.92", 15),
(9, "Kit 4 marca páginas florido", "13.99", 40),
(10, "Marca páginas floral", "4.00", 30),
(11, "Kit 3 marca páginas pastel", "13.99", 25),
(12, "Marca página A noite estrelada", "5.00", 48),
(13, "Kit 4 marca páginas Collen Hoover", "25.90", 10),
(14, "Kit 4 marca páginas Harry Potter", "39.99", 20),
(15, "Kit marca páginas fofo", "14.16", 14),
(16, "Kit 5 marca páginas aleatório", "18.49", 10),
(17, "Kit 6 marca textos pastel- Stabilo", "64.99", 12),
(18, "Kit 6 marca textos pastel- MasterPrint", "34.80", 20),
(19, "Kit 6 marca textos pastel- Faber Castell", "42.60", 28),
(20, "Kit 6 marca textos- MasterPrint", "29.30", 30),
(21, "Kit 6 marca textos fofo- Cis", "36.50", 22),
(22, "Kit 4 marca textos com cheirinho- Mentos", "43.10", 10),
(23, "Kit 6 marca textos pastel- Cis", "26.70", 35),
(24, "Kit 5 marca textos neon- Bic", "40.00", 30);

insert into Administradores values
(1, "Nicole", "nicole@gmail.com", "123456");

select * from usuarios;
select * from Produtos;
select * from Livros;

