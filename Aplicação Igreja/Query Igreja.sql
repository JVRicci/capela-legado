create database bancoCapela;
use bancoCapela;

create table usuario(id int not null identity(1,1),
	nome varchar(50), 
	sexo varchar(10), 
	funcao varchar(15), 
	cpf varchar(16)
	primary key(id));

create table login(
	id int not null identity (1,1),
	login varchar(20),
	senha varchar(20));


alter table usuario add idlogin int;
alter table usuario add foreign key (idlogin) references login(id);

insert into usuario 
	(nome, sexo, funcao, cpf) 
	values ('Joao Vitor Ricci', 'Masculino', 'Administrador', '999999999/99');

insert into login 
(login, senha)
values ('jvricci', 'ozy123');

update usuario set idlogin=1 where id=1;

select * from usuario as c  join login as l on c.idlogin = l.id;