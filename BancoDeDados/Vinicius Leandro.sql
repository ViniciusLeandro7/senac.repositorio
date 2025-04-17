/*EXERCICIO 1*/

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
    nome, categoria, preco
FROM
    produto
WHERE
    preco > 3000
ORDER BY preco DESC;

/*EX-2.2*/

SELECT 
    nome, cidade, idade
FROM
    cliente
WHERE
    cidade <> 'São Paulo' AND idade > 30;

/*EX-2.3*/

SELECT 
    data_pedido
FROM
    pedido
WHERE
    data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
ORDER BY data_pedido ASC;

/*EX-2.4*/

SELECT 
    estoque, nome, categoria, preco
FROM
    produto
WHERE
    estoque < 10
ORDER BY estoque ASC;

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
GROUP BY categoria;
    
/*EX-3.2*/

SELECT 
    cliente_id, COUNT(quantidade)
FROM
    pedido
GROUP BY cliente_id;

/*EX-3.3*/

SELECT 
    categoria, SUM(estoque)
FROM
    produto
GROUP BY categoria;

/*EX-3.4*/

SELECT id, produto_id, quantidade
FROM pedido
WHERE quantidade = (SELECT MAX(quantidade) FROM pedido);

/*EX-3.5*/
 
SELECT cidade, COUNT(cidade) AS total_clientes
FROM cliente
GROUP BY cidade
ORDER BY cidade DESC;

/*4.1*/
 
SELECT produto.nome, fornecedor.nome
FROM produto
JOIN fornecedor ON fornecedor.id = produto.fornecedor_id
ORDER BY fornecedor.nome;
 
/*4.2*/
 
SELECT pedido.id, pedido.data_pedido, cliente.nome, produto.nome, pedido.quantidade
FROM pedido
JOIN cliente ON cliente.id = pedido.cliente_id
JOIN produto ON produto.id = pedido.produto_id
ORDER BY pedido.data_pedido;
 
/*4.3*/
 
SELECT pedido.id, cliente.nome, produto.nome, fornecedor.nome
FROM pedido
JOIN cliente ON cliente.id = pedido.cliente_id
JOIN produto ON produto.id = pedido.produto_id
JOIN fornecedor ON fornecedor.id = fornecedor_id
ORDER BY pedido.id;

/*4.4*/

SELECT cliente.nome, SUM(quantidade) AS produtos_comprados
FROM pedido
JOIN cliente ON cliente.id = pedido.cliente_id
GROUP BY cliente.nome;

/*5.1*/

SELECT 
    nome, categoria, preco
FROM
    produto
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto
        WHERE
            categoria = 'Eletrônicos')
		AND categoria = 'Eletrônicos'
UNION SELECT 
    nome, categoria, preco
FROM
    produto
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto
        WHERE
            categoria = 'Móveis')
		AND categoria = 'Móveis';
        
/*5.2*/

UPDATE produto 
SET 
    preco = preco * 1.10
WHERE
    categoria = 'eletronicos';

select *
from produto;

/*5.3*/

DELETE FROM pedido
WHERE cliente_id = '4';

select *
from pedido;

/*5.4*/

INSERT INTO cliente (nome,cidade,idade) 
VALUES ('Ricardo Lopes','Porto Alegre', '38');

select *
from cliente;

/*5.5*/

INSERT INTO pedido (produto_id,quantidade, data_pedido, cliente_id)
VALUES
	('2','2','2024-03-25','1');
    
/*5.6*/

SELECT 
    c.nome AS cliente, prod.categoria
FROM
    pedido p
        JOIN
    cliente c ON p.cliente_id = c.id
        JOIN
    produto prod ON p.produto_id = prod.id
WHERE
    prod.categoria = 'Móveis'
GROUP BY c.nome;

