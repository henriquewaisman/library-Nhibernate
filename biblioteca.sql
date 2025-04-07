DROP DATABASE IF EXISTS biblioteca;
CREATE SCHEMA biblioteca;
USE biblioteca;

CREATE TABLE AUTOR(
	ID INT(9) NOT NULL,
    NOME VARCHAR(100) NOT NULL,
    DATANASCIMENTO DATE
);

ALTER TABLE AUTOR
	ADD CONSTRAINT PK_AUTOR PRIMARY KEY (ID);
    
ALTER TABLE AUTOR
	MODIFY COLUMN ID INT AUTO_INCREMENT;

CREATE TABLE EDITORA (
	ID INT(9) NOT NULL,
    NOME VARCHAR(100) NOT NULL,
    CIDADE VARCHAR(100	)
);

ALTER TABLE EDITORA
	ADD CONSTRAINT PK_EDITORA PRIMARY KEY (ID);

ALTER TABLE EDITORA
	MODIFY COLUMN ID INT AUTO_INCREMENT;
    
CREATE TABLE LIVRO(
	ID INT(9) NOT NULL,
    TITULO VARCHAR(200) NOT NULL,
    ANOPUBLICACAO INT(4) NOT NULL,
    IDAUTOR INT(9) NOT NULL,
    IDEDITORA INT(9) NOT NULL 
);

ALTER TABLE LIVRO
	ADD CONSTRAINT PK_LIVRO PRIMARY KEY (ID);
    
ALTER TABLE LIVRO
	MODIFY COLUMN ID INT AUTO_INCREMENT;
    
ALTER TABLE LIVRO
	ADD CONSTRAINT FK_LIVRO_AUTOR FOREIGN KEY (IDAUTOR)
REFERENCES AUTOR(ID);

ALTER TABLE LIVRO
	ADD CONSTRAINT FK_LIVRO_EDITORA FOREIGN KEY (IDEDITORA)
REFERENCES EDITORA(ID);

SELECT * FROM AUTOR;
SELECT * FROM EDITORA;
SELECT * FROM LIVRO;