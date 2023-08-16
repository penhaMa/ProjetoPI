create database projetoPI;

use projetoPI;

drop table projeto;

create table projeto(
    codigo int primary key auto_increment not null,
    nome varchar(150) not null,
    tipo varchar(150) not null,
    descricao varchar(150) not null,
    orcamento decimal(5,2) not null,
    statu varchar(150) not null,
    prazo varchar (10) not null,
    integrante varchar(150) not null
)engine=innodb; 

create table entrar(
    login varchar(150) not null,
    senha varchar(150) not null
)engine=innodb; 

create table bancoTarefa(
	nomeProjeto varchar (150) not null,
	codigo int primary key auto_increment not null,
    integrante varchar(150) not null,
    tarefa varchar(150) not null,
    stat varchar(150) not null,
    prazo varchar (10) not null
)engine=innodb;

select * from entrar;

select * from bancoTarefa;

drop table bancoTarefa;

delete from projeto where codigo = 1;

select * from entrar where login = 'Penha' and senha = 123;
