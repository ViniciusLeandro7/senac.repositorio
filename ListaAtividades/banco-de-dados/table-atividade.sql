create table atividade (
id int primary key auto_increment,
titulo varchar(100) not null,
situacao int not null default 0
);

insert into atividade (titulo) values (@titulo);

update atividade set situacao = @situacao where id = @id;

select * from atividade where situacao = 1;

SELECT * from atividade where situacao = 0;
