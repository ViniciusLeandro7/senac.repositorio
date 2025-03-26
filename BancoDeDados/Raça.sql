CREATE TABLE IF NOT EXISTS cachorro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    raça VARCHAR(100) NOT NULL,
    peso INT NOT NULL,
    pelo VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    cachorro;

INSERT INTO cachorro (
raça,
peso,
pelo
) 
VALUES 
	('srd','30','curto'),
	('Labrador ','40','curto liso'),
    ('Golden','45','longo liso'),
    ('Pastor alemão','41','longo liso'),
    ('Pastor Belga','40','curto liso'),
    ('Pastor Malinois','32','curto liso'),
    ('Boxer','35','curto liso'),
    ('Bulldog frances','19','liso'),
    ('Bulldog Inglês','29','liso'),
    ('husky','33','longo liso'),
    ('Rottweiler','45','curto liso'),
    ('Poodle','18','curto enrolado'),
    ('Coker Spaniel','17','longo liso'),
    ('Yorkshire ','5','longo liso'),
    ('Shih Tzu','10','longo liso');
    