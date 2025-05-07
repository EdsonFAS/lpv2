create database bd_multa;

use bd_multa;

create table veiculo(
id_veiculo int primary key auto_increment not null,
modelo varchar(35) not null,
marca varchar(35) not null,
placa varchar(12) not null
);

create table multa(
id_multa int auto_increment primary key not null,
descricao varchar(50) not null,
valor double not null,
id_veiculo int not null,
foreign key (id_veiculo) references veiculo (id_veiculo)
);