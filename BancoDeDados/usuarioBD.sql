USE senac;

CREATE TABLE IF NOT EXISTS Cachorros (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;
    
INSERT INTO usuario (nome,email,senha) 
VALUES 
	('neymar Jr','njr@email.com','Bruna@'),
	('Maria Madalena','mmdalena@email.com','a1s2d3f4'),
    ('Pablo Vitar','p.vitar@email.com','Senh@Fort3');
    
INSERT INTO usuario (
	nome,
	email,
	senha
 ) 
 VALUES (
 'Joao Silva',
 'J.silva@email.com',
 'Senha@123'
 );
 
 INSERT INTO usuario (
 nome,
 email,
 senha
 ) 
 VALUES (
 'vinicius macedo',
 'vinicius.macedo@email.com',
 'Senha@321'
 );