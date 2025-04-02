CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(9) NOT NULL,
    idade INT NOT NULL,
    cidade VARCHAR(16) NOT NULL,
    saldo DECIMAL (6,2) NULL
);

select *
from cliente;

INSERT INTO cliente (nome,idade,cidade,saldo) 
VALUES 
	('Carlos','45','São paulo', 2500.00),
	('Mariana','32','Rio de janeiro', 3200.50),
	('Pedro','27','Belo Horizonte', 1500.75),
    ('Fernanda','38','Curitiba', 4200.00);

/*EX-1.1*/
SELECT 
    nome, cidade
FROM
    cliente
WHERE
    cidade LIKE 'Rio de janeiro';

/*EX-1.2*/

SELECT 
    nome, saldo
FROM
    cliente
WHERE saldo > 2000
Order by saldo;

/*EX-1.3*/

SELECT 
    nome, idade
FROM
    cliente
WHERE idade > 30
ORDER BY idade;

/*EX-2.1*/

SELECT nome, idade FROM cliente
WHERE idade between '25' and '40';

/*EX-2.2*/

SELECT 
    *
FROM
    cliente
WHERE
    nome LIKE 'F%';
    
/*EX-2.3*/

SELECT 
    nome,  cidade
FROM
    cliente
WHERE
    cidade NOT IN ('São paulo' ,'Curitiba');
    
/*EX-3.1*/

CREATE TABLE IF NOT EXISTS pedido (
    id INT AUTO_INCREMENT,
    cliente_id INT NOT NULL,
    valor DECIMAL(6 , 2 ) NOT NULL,
    data_pedido DATE NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);
 
insert into pedido (cliente_id, valor,data_pedido)
values 
	(1,500.00,'2024-03-10'),
    (2,1200.00,'2024-03-12'),
    (3,300.50,'2024-03-15'),
    (1,800.00,'2024-03-18');

/*EX-3.1*/

SELECT 
    count(data_pedido)
FROM
    pedido
WHERE
    data_pedido;
    
/*EX-3.2*/

SELECT 
    ROUND(AVG(valor), 2) AS media_valores
FROM
    pedido
WHERE
    valor;
    
/*EX-3.3*/

SELECT 
    cliente_id, valor
FROM pedido
group by 
	valor;
    
/*EX-4.1*/

SELECT 
    p.id, p.valor, c.nome
FROM
    pedido p
        INNER JOIN
    cliente c ON p.cliente_id = c.id
GROUP BY id;

/*EX-4.2*/

SELECT 
    c.nome, p.id AS pedido_id
FROM
    cliente c
        LEFT JOIN
    pedido p ON c.id = p.cliente_id;
    
/*5.1*/

SELECT 
    c.nome, p.valor, ROUND(AVG(p.valor), 2) AS media_pedidos
FROM
    cliente c
        JOIN
    pedido p ON c.id = p.cliente_id
WHERE
    valor > (SELECT 
            AVG(valor)
        FROM
            pedido);
            
/*5.2*/

SELECT 
    c.nome, p.valor
FROM
    cliente c
        JOIN
    pedido p ON c.id = p.cliente_id
WHERE
    valor > 1000;
    
/*6.1*/

INSERT INTO cliente 
	(nome,idade,cidade,saldo) 
values 	
	('Rafael', 25,'Porto Alegre', 5000.00);
    
/*6.2*/

UPDATE pedido
SET 
    valor = valor * 0.8264;
    
select *
from cliente;

/*6.3*/

DELETE FROM pedido 
WHERE
    valor < 500;

select *
from pedido;


    
    
    
    
    
    
    