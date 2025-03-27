CREATE TABLE IF NOT EXISTS livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    data_publicacao DATETIME NOT NULL,
    numero_paginas INT NULL,
    preco DECIMAL (10 , 2) NULL,
    genero VARCHAR (30) NOT NULL,
    editora VARCHAR(50) NOT NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    autor VARCHAR(100) NOT NULL
);

SELECT 
    *
FROM
    livro;

INSERT INTO livro (titulo, data_publicacao, numero_paginas, preco, isbn, genero, editora, autor) 
VALUES (
	'Sen to Chihiro no Kamikakushi - Spirited Away Storyboards',
    '2001-01-01 21:35:48',
    648,
    931.00,
    '978-4198614393',
	'Animacao',
    'Tokuma Shoten',
    'Hayao Miyazaki'
    );
    
    



    


