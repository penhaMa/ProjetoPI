create database projetoPI;

use projetoPI;

drop table projeto;

create table cadastrarKit(
    codigo int primary key auto_increment not null,
    sala varchar(150) not null,
    unidade varchar(150) not null
)engine=innodb; 

create table entrar(
    login varchar(150) not null,
    senha varchar(150) not null,
    nome varchar(150) not null,
    unidade varchar(150) not null
)engine=innodb; 

select * from entrar;

select * from bancoTarefa;

drop table bancoTarefa;

delete from projeto where codigo = 1;

select * from entrar where login = 'Penha' and senha = 123;
