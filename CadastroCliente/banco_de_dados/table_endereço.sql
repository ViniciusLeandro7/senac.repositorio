CREATE TABLE endereco (
    id INT PRIMARY KEY AUTO_INCREMENT,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    complemento VARCHAR(50) NULL,
    bairro VARCHAR(50) NOT NULL,
    municipio VARCHAR(50) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    cep VARCHAR(8) NOT NULL
);

INSERT INTO endereco
(logradouro, numero, bairro, municipio, estado, cep, complemento)
VALUES
('Dupret', '667', 'Vila Clementino', 'São Paulo', 'SP', '040250130', NULL),
('Lister', '25', 'São José', 'São Paulo', 'SP', '04843510', NULL);