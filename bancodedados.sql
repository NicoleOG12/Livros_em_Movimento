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

create table Livros_Emprestimos (
id int auto_increment unique not null,
idUsuario int not null,
nome varchar(50) not null,
autor varchar(50) not null,
genero varchar(25) not null,
disponibilidade boolean not null,
primary key (id),
constraint foreign key (idUsuario) references Usuario (id)
);

create table Livro_Usuario(
id int auto_increment not null,
idUsuario int not null,
idLivro int not null,
primary key (id),
constraint foreign key (idUsuario) references Usuario  (id),
constraint foreign key (idLivro) references Livros_Emprestimos (id)
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
constraint foreign key (idLivro) references Livros_Emprestimos (id)
);

---------------------------------------------------------------------------------
create table Produtos (
id int auto_increment unique not null,
nome varchar(250) not null,
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
constraint foreign key (idProduto) references Produtos (id)
);

insert into Usuario values
(1, "Maria Flor", "mariazinha@gmail.com", "maria123", "Romance"),
(2, "Chico Souza", "chiquinho@gmail.com", "chico123", "Comédia"),
(3, "Paulo Gomes", "paulo@gmail.com", "paulo123", "Literatura"),
(4, "Manuela Ferreira", "manu@gmail.com", "manu123", "Ficção"),
(5, "Larissa Lopes", "laris@gmail.com", "lari123", "Drama");



insert into Livros_Emprestimos values
(1, 1, "Para além do diário", "Anne Frank", "Diário", true),
(2, 1, "A mente de Adolf Hitler", "Walter C.", "História", true),
(3, 2, "Assassinato na casa do pastor", "Agatha Christie", "Ficção", true),
(4, 3, "E não sobrou nenhum", "Agatha Christie", "Investigação", true),
(5, 3, "O homem de giz", "C.J Tudor", "Mistério", true),
(6, 4, "Pessoas normais", "Sally Rooney", "Romance", true),
(7, 4, "A vida invisível de Addie Larue", "V.E. Schawab", "Literatura", true),
(8, 5, "Um de nós está mentindo", "Karen M.", "Ficção", true);

insert into Produtos values
(1, "Memórias póstumas de Brás Cubas", "29,99", 15),
(2, "Mais que amigos?", "50,91", 6),
(3, "A hipótese do amor", "44,90", 8),
(4, "É assim que começa", "73,63", 20),
(5, "Além da fumaça", "41,38", 10),
(6, "Bridgerton (O duque e eu)", "48,52", 16),
(7, "A garota do lago", "21,80", 12),
(8, "Como eu era antes de você", "44,92", 15),
(9, "Kit 4 marca páginas florido", "13,99", 40),
(10, "Marca páginas floral", "4,00", 30),
(11, "Kit 3 marca páginas pastel", "13,99", 25),
(12, "Marca página A noite estrelada", "5,00", 48),
(13, "Kit 4 marca páginas Collen Hoover", "25,90", 10),
(14, "Kit 4 marca páginas Harry Potter", "39,99", 20),
(15, "Kit marca páginas fofo", "14,16", 14),
(16, "Kit 5 marca páginas aleatório", "18,49", 10),
(17, "Kit 6 marca textos pastel- Stabilo", "64,99", 12),
(18, "Kit 6 marca textos pastel- MasterPrint", "34,80", 20),
(19, "Kit 6 marca textos pastel- Faber Castell", "42,60", 28),
(20, "Kit 6 marca textos- MasterPrint", "29,30", 30),
(21, "Kit 6 marca textos fofo- Cis", "36,50", 22),
(22, "Kit 4 marca textos com cheirinho- Mentos", "43,10", 10),
(23, "Kit 6 marca textos pastel- Cis", "26,70", 35),
(24, "Kit 5 marca textos neon- Bic", "40,00", 30);
