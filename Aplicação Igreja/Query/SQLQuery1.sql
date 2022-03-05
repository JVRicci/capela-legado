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
alter table login add primary key (id);

create table contato(
	id int not null identity (1,1), 
	telefone varchar(15),
	celular varchar (15),
	email varchar (50)
	primary key (id));

create table endereco(
	id int not null identity (1,1),
	logradouro varchar(50),
	numero varchar(10),
	bairro varchar(40),
	cep varchar (10),
	uf varchar (3)
	primary key (id)
	);

create table dizimistas(
	id int not null identity (1,1),
	idContato int,
	idEndereco int,
	nome varchar(50),
	cpf varchar(16),
	nascimento date,
	casamento varchar(10),
	estadoCivil varchar(10),
	conjuge varchar(50),
	nascConjuge date
	primary key (id)
	);

create table dizimo(
	id int not null identity (1,1),
	idDizimista int,
	qtdRecebida float(10),
	dataRecebimento date
	primary key (id)
	);

create table catequizando(
	id int not null identity (1,1),
	idContato int,
	idEndereco int,
	idResponsavel int,
	idTurma int,
	nome varchar(40),
	nascimento date,
	faltas int,
	ativo varchar,
	primary key (id)
	);

create table catequista(
	id int not null identity (1,1),
	idContato int,
	idEndereco int,
	idTurma int,
	nome varchar(40),
	nascimento date,
	ativo varchar(10),
	primary key (id));



create table responsavel(
	id int not null identity (1,1),
	responsavel varchar(40),
	nascRespon varchar(40),
	estadoCivil varchar (10),
	tipoCasamento varchar (10),
	padrinho varchar(40),
	madrinha varchar(40),
	primary key (id));

create table turma (
	id int not null identity (1,1),
	idCatequizando int,
	idCatequista int,
	diaEncontro varchar,
	formacao varchar,
	);

create table doacao(
	id int not null identity (1,1),
	idDoador int,
	descricao varchar(25),
	destino varchar(40),
	dataReceb date,
	primary key (id));


create table doador(
	id int not null identity (1,1),
	idContato int,
	idEndereco int,
	nome varchar(40),
	primary key (id)
	);
select * from usuario
alter table usuario add ativo varchar (10);
create table evento (
	id int not null identity (1,1),
	descricao varchar (30),
	dataEvento date,
	responsavel varchar(40),
	primary key (id)
	);


create table material(
	id int not null identity (1,1),
	idEquipe int,
	idEvento int,
	descricao varchar (30),
	qtd int,
	qtdNecessario int,
	reponsavel varchar,
	primary key (id)
	)
	

create table equipe(
	id int not null identity (1,1),
	idEvento int,
	nome varchar (40),
	funcao varchar(40),
	primary key (id)
	);



create table contas (
	id int not null identity (1,1),
	descricao varchar (20),
	valor float(10),
	categoria varchar(10),
	fornecedor varchar(20),
	vencimento date,
	pagamento date,
	primary key (id)
	);
create table faltas (
	id int not null identity (1,1),
	idFalta int,
	faltasCatequese int,
	faltaMissa int,
	estado varchar(10),
	primary key (id)
	);


alter table doacao add foreign key (idDoador) references doador(id);  
alter table doacao add entregue varchar(20);
alter table material add foreign key (idEquipe) references equipe(id);
alter table material add foreign key (idEvento) references evento (id);
alter table equipe add foreign key (idEvento) references evento (id)

alter table doador add foreign key (idContato) references contato (id);
alter table doador add foreign key (idEndereco) references endereco (id);
update catequista set nascimento = '1950-12-20' where id =4;

alter table catequista add idLogin int;
alter table catequista add foreign key (idLogin) references login (id);

alter table catequizando  add faltasCatequese int, faltaMissa int, estadoFalta varchar;
select * from catequizando;
select * from usuario;
--Operaçãoes

-- alterações necessárias 
alter table usuario add idlogin int;
alter table usuario add foreign key (idlogin) references login(id);

alter table dizimo add foreign key (idDizimista) references dizimistas (id);
alter table dizimistas add foreign key (idContato) references contato (id);
alter table dizimistas add foreign key (idEndereco) references endereco (id);

alter table catequizando add foreign key (idContato) references contato(id);
alter table catequizando add foreign key (idEndereco) references endereco (id);
alter table catequizando add foreign key (idResponsavel) references responsavel (id);
alter table catequizando add turma varchar(10);
alter table catequizando add faltaEncontro int;
alter table catequizando add faltaMissa int;


alter table turma drop column idCatequizando;

alter table catequista add foreign key (idContato) references contato(id);

select*from turma;
alter table catequista add foreign key (idEndereco) references endereco (id);

alter table turma alter column diaEncontro varchar (20);
alter table turma alter column formacao varchar (20);
select * from catequizando;
-- inserts iniciais
insert into usuario 
	(nome, sexo, funcao, cpf) 
	values ('Joao Vitor Ricci', 'Masculino', 'Administrador', '999999999/99');


insert into login 
(login, senha)
values ('jvricci', 'ozy123');

insert into dizimistas 
	(nome, cpf, nascimento, casamento, estadoCivil, conjuge, nascConjuge)
	values ('James Aparecido Ricci', '999999999/99', '1963-12-24','Ambos', 'Casado', 'Ana Maria de Souza Ricci', '1964-05-31');

insert into contato
	(telefone, celular)
	values ('(17)3323-2863', '(17)98140-1982');

insert into endereco
	(logradouro, numero, bairro, cep, uf)
	values ('25 de Dezembro', '129', 'Derby Club', '14787-244', 'SP');

insert into dizimo
	(idDizimista, qtdRecebida, dataRecebimento)
	values (2, 50.00, '2019-11-13');
--updates e alter necessários
update usuario set idlogin=1 where id=1;
update dizimistas set estadoCivil= 'Casado(a)', idEndereco=1 where id=2;
alter table endereco add cidade varchar(30);
alter table dizimistas add ativo varchar (10);
alter table contato drop column email;

update endereco set cidade='Barretos' where id='1';

--seleções
SELECT l.login, l.senha, u.nome, u.funcao from login as l
join usuario as u on u.idlogin = l.id where l.login = 'jvricci' and l.senha = 'ozy123' ;

select * from usuario;

update usuario set idlogin=1 where id=1;


select * from usuario as c  join login as l on c.idlogin = l.id;
select * from dizimistas as d 
	inner join contato as c  on (d.idContato = c.id)
	inner join endereco as e on (d.idEndereco = e.id);

select d.id, d.idContato, d.idEndereco, d.nome, d.cpf,  d.nascimento, d.casamento, d.estadoCivil, d.conjuge, d.nascConjuge,
                e.logradouro, e.numero, e.bairro, e.cep, e.uf, e.cidade
                from dizimistas as d 
                inner join contato as c  on(d.idContato = c.id) 
                inner join endereco as e on(d.idEndereco = e.id);
select * from turma;

select c.nome, c.nascimento, c.faltas, c.ativo, 
	r.responsavel, r.nascRespon, r.estadoCivil, r.tipoCasamento, r.padrinho, r.madrinha,
	e.id, e.logradouro, e.numero, e.bairro, e.cep, e.uf, e.cidade,
	i.id, i.telefone, i.celular 
	from catequizando as c
	inner join responsavel as r on(c.idResponsavel = r.id)
	inner join endereco as e on(c.idEndereco = e.id)
	inner join contato as i on(c.idContato = i.id) ;


update dizimistas set idendereco = (select max(id) from endereco), idcontato = 
(select max (id) from contato) where id = (select max(id) from dizimistas); 

select idContato , idEndereco, idResponsavel from catequizando (
insert into catequizando (idContato , idEndereco, idResponsavel) values (1,1,1) where idContato=NULL , idEndereco=NULL, idResponsavel=NULL);

select * from catequizando

update catequizando set idendereco = (select max(id) from endereco), 
	idcontato = (select max(id) from contato), 
	idResponsavel = (select max(id) from responsavel) 
	where id = (select max(id) from catequizando); 

select * from usuario;
alter table doacao add tipoDoacao varchar(10);
select * from login;
update usuario set funcao = 'Administrador' where id = 1
select * from contas;
alter table contas add responsavel varchar(40), cadastrante varchar(40);
select * from catequizando;
alter table contas add recebimento date;
alter table contas add estado varchar(20) ;
alter table contas add idAuxiliar int;
alter table contas add foreign key (idAuxiliar) references usuario (id);
select * from catequizando

select * from contas;
alter table contas add forma varchar (40);
alter table contas add  parcelas int;

select * from catequizando
select * from responsavel
alter table catequizando alter column ativo varchar(40)

select * from catequisando
update contas set descricao = 'sabão', valor ='', categoria=@categoria,
fornecedor = @fornecedor, vencimento= @vencimento, pagamento=@pagamento, estado = @estado,
                     recebimento = @recebimento, parcelas=@parcelas, forma=@forma
                    where id = @id

					select * from bancoCapela..contas

					select* from catequisando
UPDATE
	bancoCapela.dbo.contas
SET
	descricao = 'Esportola de Padre', 
	valor ='', 
	categoria='Unico',
	fornecedor ='Loja de Roupas', 
	vencimento= GETDATE(),
	pagamento=GETDATE(),
	estado = 'Pago',
	recebimento = 10,
	parcelas= 2,
	forma='Cartão'
WHERE
	id = 10

	use bancoCapela
	select * from catequizando
	select * from turma
	alter table catequizando alter column turma value 

	use bancoCapela
	alter table turma add primary key (id) not null identity (1,1)
	drop table turma
	select* from turma
	select * from catequista
	select * from catequizando

	update catequizando set idTurma = 1 where id =1021
	alter table catequizando add foreign key (idTurma) references turma(id) not null
	alter table catequizando
	update  catequizando set idTurma=1009 where id=1021;update catequizando set idendereco = (select max(id) from endereco), 
                    idcontato = (select max(id) from contato), idResponsavel = (select max(id) from responsavel)
                    where id = (select max(id) from catequizando); 
	select * from catequizando

	ALTER TABLE catequizando drop constraint DF_Turma ;
	ALTER TABLE catequizando ADD CONSTRAINT DF_NomeQualquer DEFAULT 0 FOR idTurma
	update catequizando set idTurma = 2 where idTurma is NULL
	select * from catequizando
	ALTER TABLE catequizando ADD CONSTRAINT fk_turma FOREIGN KEY(idTurma) REFERENCES turma (id);