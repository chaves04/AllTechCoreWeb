use master
go

-- --------------------------------------------------------------------------------
-- Criar banco de dados
-- --------------------------------------------------------------------------------
DROP DATABASE IF EXISTS dbALLTechCore
go
CREATE DATABASE dbALLTechCore
go
-- --------------------------------------------------------------------------------
-- Criar usuário
-- --------------------------------------------------------------------------------
CREATE LOGIN usrAllTech WITH PASSWORD = '@lltech123', DEFAULT_DATABASE = dbALLTechCore;
go
use dbALLTechCore
go
CREATE USER usrAllTech FOR LOGIN usrAllTech;
go
-- --------------------------------------------------------------------------------
-- Criar tabela
-- --------------------------------------------------------------------------------
CREATE TABLE Cadastro
(
	ID int NOT NULL IDENTITY,
	Nome varchar(50) NOT NULL,
	Email varchar(300) NOT NULL
)

ALTER TABLE Cadastro ADD CONSTRAINT PK_Cadastro primary KEY ( ID )
ALTER TABLE Cadastro ADD CONSTRAINT UK_Cadastro_Nome unique ( Nome )
ALTER TABLE Cadastro ADD CONSTRAINT UK_Cadastro_Email unique ( email )
-- --------------------------------------------------------------------------------
-- Inserir dados
-- --------------------------------------------------------------------------------
INSERT INTO Cadastro (Nome, email ) values ( 'Alexandre Vaz', 'asantos.cs@alltechsolucoes.com.br' )
-- --------------------------------------------------------------------------------
-- Acesso a tabela
-- --------------------------------------------------------------------------------
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Cadastro TO usrAllTech;
