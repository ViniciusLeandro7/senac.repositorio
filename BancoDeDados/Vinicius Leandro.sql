CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL,
    categoria VARCHAR(30) NOT NULL,
    preco DECIMAL(6 , 2 ) NOT NULL,
    estoque INT NOT NULL,
    fornecedor_id INT NOT NULL,
        PRIMARY KEY (id),
    FOREIGN KEY (fornecedor_id)
        REFERENCES fornecedor (id)
);


INSERT INTO produto (nome, categoria, preco, estoque, fornecedor_id)
VALUES 
	('Celular X','Eletrônicos',2500.00,'30','1' ),
	('Notebook Y','Eletrônicos',4800.00,'15','2' ),
	('Mesa de Madeira','Móveis',750.00,'10','3' ),
    ('Cadeira Z','Móveis',300.00,'25','3' ),
    ('TV 50"','Eletrônicos',3500.00,'8','1' );

CREATE TABLE IF NOT EXISTS fornecedor (
	id INT AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    cidade VARCHAR(30) NOT NULL,
    PRIMARY KEY (id)
);

select * 
from fornecedor;

INSERT INTO fornecedor (nome,cidade) 
VALUES 
	('TechBrasil','São paulo' ),
	('Computech','Rio de Janeiro' ),
    ('Moveis&Co','Curitiba');

CREATE TABLE IF NOT EXISTS pedido (
    id INT AUTO_INCREMENT,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL,
    data_pedido DATE NOT NULL,
    cliente_id INT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (produto_id)
        REFERENCES produto (id),
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

select * 
from pedido;

INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id)
VALUES 
	('1','2','2024-03-10','1' ),
	('3','1','2024-03-11','2' ),
	('2','1','2024-03-15','3' ),
    ('5','3','2024-03-18','1' ),
    ('4','4','2024-03-20','4' );


CREATE TABLE cliente (
    id INT AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    cidade VARCHAR(30) NOT NULL,
    idade INT NOT NULL,
    PRIMARY KEY (id)
);

select * 
from cliente;

INSERT INTO cliente (nome,cidade,idade) 
VALUES 
	('João Silva','São paulo','35' ),
	('Maria Santos','Belo Horizonte','28' ),
	('Carlos Lima','Rio de Janeiro','42' ),
    ('Fernando Rocha','Curitiba', '30');
    
/*EX-2.1*/

SELECT 
    nome,categoria,preco
FROM
    produto
WHERE preco > 3000
order by preco Desc;

/*EX-2.2*/

select
	nome, cidade, idade
from
	cliente
where cidade <> 'São Paulo' and idade > 30;

/*EX-2.3*/

select data_pedido 
from pedido
where data_pedido between'2024-03-10' and '2024-03-15'
order by data_pedido asc;

/*EX-2.4*/

select estoque, nome, categoria, preco
from produto
where estoque < 10
order by estoque asc;

/*EX-2.5*/

SELECT 
    nome, cidade
FROM
    fornecedor
WHERE
    cidade <> 'Rio de Janeiro' and nome like 'T%'; 
    
/*EX-3.1*/

SELECT 
    categoria, ROUND(AVG(preco), 5) AS preco_medio
FROM
    produto
group by
    categoria;
    
/*EX-3.2*/

select cliente_id ,count(quantidade)
from pedido
group by cliente_id;

/*EX-3.3*/

select categoria, sum(estoque)
from produto
group by categoria;

/*EX-3.4*/



