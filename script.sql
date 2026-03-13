
create database dbBancoApp;
use dbBancoApp;
create table usuario(
IdUsu int primary key auto_increment,
nomeUsu varchar(50) not null,
Cargo varchar(50) not null,
DataNasc date
);

insert into usuario (nomeUsu,Cargo, DataNasc)
	values ('João Paulo', 'Gerente','2007-11-29'),
			('Sammuel', 'CEO','2008-01-01');
    
select * from usuario;'