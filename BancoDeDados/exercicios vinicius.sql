CREATE TABLE IF NOT EXISTS empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(6) NOT NULL,
    idade INT NOT NULL,
    departamento VARCHAR(16) NOT NULL,
    salario INT NOT NULL
);

DROP TABLE empregado;
DROP TABLE ;

INSERT INTO empregado (nome,idade,departamento,salario) 
VALUES 
	('João','30','RH', '50000'),
	('Sarah','28','TI', '60000'),
	('Miguel','35','Vendas', '55000'),
	('Ana','27','TI', '62000');
    
    SELECT 
    *
FROM
    empregado;

/*1.1*/

SELECT 
    nome, departamento
FROM
    empregado
WHERE
    departamento LIKE 'TI';

/*1.2*/
SELECT 
    nome, salario
FROM
    empregado
WHERE
    salario > 55000;

/*1.3*/
SELECT 
    *
FROM
    empregado
ORDER BY idade DESC;

/*EX-2.1*/
 
SELECT * FROM empregado
WHERE idade between '28' and '35';

/*EX-2.2*/
SELECT 
    *
FROM
    empregado
WHERE
    nome LIKE 'M%';

/*EX-2.3*/

SELECT 
    nome, departamento
FROM
    empregado
WHERE
    departamento NOT LIKE 'RH';
 
 /*EX-3.1*/
 
SELECT 
    departamento, count(departamento)
FROM empregado
group by 
	departamento;

/*EX-3.2*/

SELECT 
    AVG(salario)
FROM
    empregado
WHERE
    departamento = 'TI';
    
 /*EX-3.3*/   
    
SELECT 
    sum(salario), count(id)
FROM
    empregado
WHERE
    departamento = 'Vendas';
    
/*EX-4 (usei o drop table e criei essa nova tabela)*/ 
 
 CREATE TABLE IF NOT EXISTS departamento (
    id INT AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL,
    PRIMARY KEY (id)
);

insert into departamento (nome)
values 
('RH'),
('TI'),
('VENDAS');

SELECT 
    *
FROM
    departamento;
    
CREATE TABLE IF NOT EXISTS empregado (
	id int auto_increment,
    nome varchar(60) not null,
    idade INT NOT NULL,
    salario INT NOT NULL,
    id_departamento int not null,
    primary key (id),
    foreign key (id_departamento)
		references departamento (id)
);

INSERT INTO empregado (nome, idade, salario, id_departamento)
VALUES
	('João','30', '50000','1'),
	('Sarah','28', '60000','2'),
	('Miguel','35', '55000','3'),
	('Ana','27', '62000', '2');
 
/*EX-4.1*/
 
SELECT 
    empregado.id,
    empregado.nome AS empregado_nome,
    departamento.nome AS departamento_nome
FROM
    empregado
        JOIN
    departamento ON empregado.id_departamento = departamento.id;

/*4.2*/
    SELECT 
	departamento.id,
    departamento.nome as departamentos,
    empregado.nome as empregados
FROM 
	departamento
LEFT JOIN 
	empregado ON departamento.id = empregado.id_departamento;
    
/*EX-5.1 (fiz o reverse e voltei a primeira tabela)*/ 

SELECT 
    *
FROM
    empregado
WHERE
    salario > (SELECT 
            AVG(salario)
        FROM
            empregado);

/*EX-5.2*/

SELECT 
     nome, id_departamento
FROM
    empregado
WHERE
    id_departamento = (SELECT 
            id_departamento
        FROM
            empregado
        WHERE
            nome = 'Sarah');
            
SELECT nome, departamentoid FROM empregado
WHERE departamentoid = (SELECT departamentoid FROM empregado WHERE nome = 'Sarah');

/*EX-6.1*/

INSERT INTO empregado (nome, idade,salario, id_departamento) 
VALUES('Tomás', '43', '58000', '3');

SELECT 
    *
FROM
    empregado;

/*EX-6.2*/

UPDATE empregado 
SET salario = salario + (salario * 0.05) 
WHERE id_departamento = '2';

/*EX-6.3*/

DELETE FROM empregado
WHERE idade > 40;


    







