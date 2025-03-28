CREATE TABLE IF NOT EXISTS editora (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    documento VARCHAR (14) UNIQUE NOT NULL
);

select distinct
	*
from
	genero;

select distinct
	*
from
    autor;
    
select distinct
	*
from
    editora;
    
iNSERT INTO editora (nome, documento)
values
('intrínseca', '21306675000133'),
('abril', '87067440000144'),
('globo', '03708536000154'),
('panini', '22455174000181'),
('rocco ltda.', '41500632000100'),
('darkside', '80731635000106'),
('marvel', '49420531000122'),
('harpercollins', '36780957000145'),
('companhia das letras', '20413077000109'),
('senac', '82535051000182'),
('biblioteca azul', '97045992000105');